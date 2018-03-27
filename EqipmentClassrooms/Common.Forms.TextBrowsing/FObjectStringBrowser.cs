using Common.Events;
using Common.Forms.TextBrowsing.Base;
using Common.Forms.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Common.Forms.TextBrowsing
{
    public partial class FObjectStringBrowser : FInfoDialog,
        IObjectStringBrowser, IFormDialog
    {
        protected SortedList<string, string> objectsInfo = new SortedList<string, string>();
        public FObjectStringBrowser()
        {
            InitializeComponent();
            base.InformationChanged += FObjectStringBrowser_InformationChanged;
        }

        private void FObjectStringBrowser_InformationChanged(
          object sender, StringEventArgs e)
        {
            //throw new NotImplementedException();
            richTextBoxInfo.Text = base.Information;
            splitContainer1.Panel1Collapsed = true;
        }

        private void listBoxKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxInfo.Text = objectsInfo[listBoxKeys.SelectedItem.ToString()];
        }

        public void AddStringPair(string key, string value)
        {
            objectsInfo[key] = value;
            listBoxKeys.Items.Clear();
            listBoxKeys.Items.AddRange(objectsInfo.Keys.ToArray());
            if (listBoxKeys.Items.Count >= 0)
                listBoxKeys.SelectedIndex = 0;
            splitContainer1.Panel1Collapsed = false;
        }

        public Form Form
        {
            get { return this; }
        }
        //public void SetDataStringableObject(IDataStringable value) {
        //    Information = value.ToDataString();
        //}

        //public void SetObject(Object value) {
        //    Information = value.ToString();
        //}

        private void richTextBoxInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuFile_Click(object sender, EventArgs e)
        {

        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title =
                "Зберегти текстове представлення даних у файл";
            dialog.Filter = String.Format(
                "Текстові файли (*.txt)|*.txt");
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, this.Information);
            }
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FObjectStringBrowser_Load(object sender, EventArgs e)
        {

        }
    }
}
