using Common.Events;
using Common.Forms.TextBrowsing.Base;

namespace Common.Forms.TextBrowsing {
    public partial class FTextInfo : FInfoDialog {

        public FTextInfo() {
            InitializeComponent();
            base.InformationChanged += FTextInfo_InformationChanged;
        }

        void FTextInfo_InformationChanged(object sender, StringEventArgs e) {
            //throw new System.NotImplementedException();
            richTextBox1.Text = base.Information; 
        }

        private void richTextBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void FTextInfo_Load(object sender, System.EventArgs e)
        {

        }
    }
}
