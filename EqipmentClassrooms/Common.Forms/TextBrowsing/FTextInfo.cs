using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common.Forms.TextBrowsing
{
    public partial class FTextInfo : Form
    {
        public FTextInfo()
        {
            InitializeComponent();
        }
        public string Title { 
        get{ return Text; }
            set { Text = value; }
}
        public string Information
        {
            get { return richTextBox1.Text; }
            set { richTextBox1.Text = value; }
        }

        private void FTextInfo_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
