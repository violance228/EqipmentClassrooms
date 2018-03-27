using Common.Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Common.Forms.Editing {
    public partial class FBindingListEditor<T> : Form where T : Entity {

        protected BindingList<T> Collection { get; private set; }

        private int _newItemIndex;

        public FBindingListEditor(BindingList<T> collection) {
            if(collection == null) {
                throw new ArgumentNullException("collection");
            }
            Collection = collection;
            Collection.ListChanged += Collection_ListChanged;

            InitializeComponent();

            dataGridView1.DataSource = Collection;
        }

        private void Collection_ListChanged(object sender, ListChangedEventArgs e) {
            if (e.ListChangedType == ListChangedType.ItemAdded) {
                _newItemIndex = e.NewIndex;
            }
        }

        private void FBindingListEditor_FormClosed(object sender, FormClosedEventArgs e) {
            var row = dataGridView1.Rows[_newItemIndex];
            for (int i = 0; i < dataGridView1.ColumnCount; i++) {
                if (row.Cells[i].Value != null 
                    && dataGridView1.Columns[i].Name != "Key") {
                    return;
                }
            }
            Collection.RemoveAt(_newItemIndex);
        }
    }
}
