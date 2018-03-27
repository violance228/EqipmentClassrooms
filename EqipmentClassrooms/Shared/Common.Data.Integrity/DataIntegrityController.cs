using Common.Data.Integrity.Interfaces;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Common.Data.Integrity {
    public abstract class DataIntegrityController<T, D> 
        : IDataIntegrityController<T> where T : IEntity {
        //protected
        public D DataSet { get; private set; }

        private readonly BindingList<T> _dataCollection;
        private readonly List<T> _prevCollection = new List<T>();

        //public
        protected BindingList<T> DataCollection {
            get { return _dataCollection; }
        }

        public DataIntegrityController(D dataSet, BindingList<T> collection) {
            #region граничні оператори
            if (dataSet == null) {
                throw new ArgumentNullException(
                    "Для створення контролера цілісності "
                    + "даних типу " + typeof(T).Name
                    + " потрібно вказати об'єкт набору даних "
                    + "типу " + typeof(D).Name);
            }
            if (collection == null) {
                throw new ArgumentNullException(
                    "Для створення контролера цілісності "
                    + "даних типу " + typeof(T).Name
                    + " потрібно вказати об'єкт колекції");
            }
            //перевірка приналежності колекції набору
            #endregion                
            DataSet = dataSet;
            _dataCollection = collection;
            _prevCollection.AddRange(collection);
            AutoEnsuringIntegrity = true;
        }

        private bool _autoEnsuringIntegrity;

        public bool AutoEnsuringIntegrity {
            get {
                return _autoEnsuringIntegrity;
            }
            set {
                if (value) {
                    EnsureTotalIntegrity();
                    SetEventHandlers();
                }
                else {
                    UnsetEventHandlers();
                }
                _autoEnsuringIntegrity = value;
            }
        }

        private void UnsetEventHandlers() {
            _dataCollection.ListChanged -= _dataCollection_ListChanged; 
        }

        private void SetEventHandlers() {
            _dataCollection.ListChanged += _dataCollection_ListChanged;
        }

        private void _dataCollection_ListChanged(object sender, ListChangedEventArgs e) {
            switch (e.ListChangedType) {
                case ListChangedType.ItemAdded:
                    CheckDuplicationAndRemove(e.NewIndex);
                    HandleAdding();
                    break;
                case ListChangedType.ItemDeleted:
                    HandleRemoving();
                    break;
                case ListChangedType.ItemChanged:
                    HandleChanging();
                    break;
            }
        }

        private void CheckDuplicationAndRemove(int newIndex) {
            var addedItem = _dataCollection[newIndex];
            int count = _dataCollection.Count(e => e.Key == addedItem.Key);
            if(count > 1) {
                _dataCollection.RemoveAt(newIndex);
                throw new InvalidOperationException(
                    "Спроба повторно додати об'єкт з ключем " + addedItem.Key);
            }
        }

        private void HandleAdding() {
            var addedItem = GetAddedItem();
            if (addedItem == null) {
                return;
            }
            EnsureIntegrityOfAdding(addedItem);
            _prevCollection.Add(addedItem);
        }

        private T GetAddedItem() {
            var addedItem = _dataCollection.Except(_prevCollection)
                .FirstOrDefault();
            return addedItem;
        }

        private void HandleRemoving() {
            var removedItem = GetRemovedItem();
            if (removedItem == null) {
                return;
            }
            if (!_prevCollection.Contains(removedItem))
                return;
            EnsureIntegrityOfRemoving(removedItem);
            _prevCollection.Remove(removedItem);
        }

        private T GetRemovedItem() {
            var removedItem = _prevCollection.Except(_dataCollection)
                .FirstOrDefault();
            return removedItem;
        }

        private void HandleChanging() {
            var oldItem = GetRemovedItem();
            var newItem = GetAddedItem();
            if(newItem.Key != oldItem.Key) {
                EnsureIntegrityOfChanging(oldItem, newItem);
            }
            _prevCollection.Remove(oldItem);
            _prevCollection.Add(newItem);
        }

        protected abstract void EnsureIntegrityOfAdding(T item);

        protected abstract void EnsureIntegrityOfRemoving(T item);

        protected abstract void EnsureIntegrityOfChanging(T oldItem, T newItem);

        public abstract void EnsureTotalIntegrity();

    }
}
