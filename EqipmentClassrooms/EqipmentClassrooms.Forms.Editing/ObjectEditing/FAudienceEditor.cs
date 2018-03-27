using EqipmentClassrooms.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace EqipmentClassrooms.Forms.Editing.ObjectEditing
{
    public partial class FAudienceEditor : Form
    {
        public FAudienceEditor()
        {
            InitializeComponent();
            AllowUserToAddNameTypeAudience = false;
        }

        private bool _allowUserToAddNameTypeAudience;

        public bool AllowUserToAddNameTypeAudience
        {
            get { return _allowUserToAddNameTypeAudience; }
            set
            {
                _allowUserToAddNameTypeAudience = value;
                comboBoxNameTypeAudience.DropDownStyle = _allowUserToAddNameTypeAudience ?
                    ComboBoxStyle.DropDown : ComboBoxStyle.DropDownList;
            }
        }
        public IEnumerable<string> AudienceEqipmentTypesNames
        {
            set
            {
                comboBoxNameTypeAudience.Items.Clear();
                if (value == null) return;
                foreach (var obj in value)
                {
                    comboBoxNameTypeAudience.Items.Add(obj);
                }
            }
        }
        private bool _readOnly;

        public bool ReadOnly
        {
            get { return _readOnly; }
            set
            {
                _readOnly = value;
                SetEditableProperties();
                ShowStatusMessage(_readOnly ?
                    "Перегляд даних" : "Редагування даних");
            }
        }
        private void SetEditableProperties()
        {
            buttonOk.Visible = !_readOnly;
            textBoxName.ReadOnly = _readOnly;
            richTextBoxNote.ReadOnly = _readOnly;
            textBoxNumber.ReadOnly = _readOnly;
        }
        void ShowStatusMessage(string message)
        {
            toolStripStatusLabelMessage.Text = message;
        }

        private void SetControlsState()
        {
            SetEditableProperties();
        }

        private void FAudienceEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
        private void FAudienceEditor_Load(object sender, EventArgs e)
        {
            SetControlsState();
        }

  



        private void control_TextChanged(object sender, EventArgs e)
        {
          
        }



        private Audience _current = new Audience();

        public Audience Current
        {
            get { return _current.Clone(); }
            set
            {
                if (value == null)
                {
                    _current = new Audience();
                }
                else
                {
                    _current = value.Clone();
                }
                ShowMembers();
            }
        }
        private void ShowMembers()
        {
            textBoxName.Text = _current.Name;
            comboBoxNameTypeAudience.Text = _current.NameTypeAudience;
            textBoxNumber.Text = _current.Number.ToString();
            richTextBoxNote.Text = _current.Note;
        }

        private void richTextBoxDefinition_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                _current.Name = textBoxName.Text.Trim();
                _current.NameTypeAudience = comboBoxNameTypeAudience.Text.Trim();
                string s = (textBoxNumber.Text ?? "").Trim();
                if (s != "") _current.Number = uint.Parse(s);
                _current.Note = richTextBoxNote.Text.Trim();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ShowStatusMessage(ex.Message);
            }
        }

        private void richTextBoxNote_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void labelNameTypeAudience_Click(object sender, EventArgs e)
        {

        }

        private void toolStripPanel1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNameTypeAudience_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabelMessage_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelButtons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void labelNote_Click(object sender, EventArgs e)
        {

        }

        private void labelNumber_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxNameTypeAudience_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
