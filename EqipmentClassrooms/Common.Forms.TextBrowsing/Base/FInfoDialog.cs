using Common.Events;
using Common.Forms.Interfaces;
using System;
using System.Windows.Forms;

namespace Common.Forms.TextBrowsing.Base
{

    public partial class FInfoDialog : Form, IInfoDialog
    {

        public event EventHandler<StringEventArgs> InformationChanged;

        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                this.Text = title;
            }
        }

        private string information;

        public string Information
        {
            get { return information; }
            set
            {
                information = value;
                if (InformationChanged != null)
                {
                    InformationChanged(this, new StringEventArgs(information));
                }
            }
        }

        public FInfoDialog()
        {
            InitializeComponent();
        }

        void IInfoDialog.ShowDialog()
        {
            this.ShowDialog();
        }

        private void FInfoDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
