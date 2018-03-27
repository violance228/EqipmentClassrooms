using Common.Interfaces;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Common.Forms.Editing {
    public partial class FBindingListEditor<T> : Form where T : IEntity {

        protected BindingList<T> Collection;

        private int _newItemIndex;

        public FBindingListEditor(BindingList<T> collection) {
            if(collection == null) {
                throw new ArgumentNullException("collection");
            }
            Collection = collection;
            Collection.ListChanged += _list_ListChanged;
            InitializeComponent();

            dataGridView1.DataSource = Collection;
        }

        private void _list_ListChanged(object sender, ListChangedEventArgs e) {
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
