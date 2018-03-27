using System;
using System.Collections.Generic;
using EqipmentClassrooms.Domain;
using System.Windows.Forms;

namespace EqipmentClassrooms.Forms.Editing.ObjectEditing
{
    public partial class FEqipmentAudienceEditor : Form
    {
        public FEqipmentAudienceEditor()
        {
            InitializeComponent();
            AllowUserToAddEqipmentNameType = false;
        }
        private bool _allowUserToAddEqipmentNameType;
        public bool AllowUserToAddEqipmentNameType
        {
            get { return _allowUserToAddEqipmentNameType; }
            set
            {
                _allowUserToAddEqipmentNameType = value;
                comboBoxEqipmentNameType.DropDownStyle = _allowUserToAddEqipmentNameType ?
                    ComboBoxStyle.DropDown : ComboBoxStyle.DropDownList;
            }
        }
        public IEnumerable<string> EqipmentNameTypes
        {
            set
            {
                comboBoxEqipmentNameType.Items.Clear();
                if (value == null) return;
                foreach (var obj in value)
                {
                    comboBoxEqipmentNameType.Items.Add(obj);
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
            textBoxNumber1.ReadOnly = _readOnly;
            textBoxInventoryNumber.ReadOnly = _readOnly;
        }
        void ShowStatusMessage(string message)
        {
            toolStripStatusLabelMessage.Text = message;
        }
        private void SetControlsState()
        {
            SetEditableProperties();
        }

        private void FEqipmentAudienceEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void FEqipmentAudienceEditor_Load(object sender, EventArgs e)
        {
            SetControlsState();
        }
        private EqipmentAudience _current = new EqipmentAudience();

        public EqipmentAudience Current
        {
            get { return _current.Clone(); }
            set
            {
                if (value == null)
                {
                    _current = new EqipmentAudience();
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
            comboBoxEqipmentNameType.Text = _current.EqipmentNameType;
            textBoxNumber1.Text = _current.Number1.ToString();
            textBoxInventoryNumber.Text = _current.InventoryNumber.ToString();
            richTextBoxNote.Text = _current.Note;
        }

        private void comboBoxEqipmentNameType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInventoryNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEqipmentNameType_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                _current.Name = textBoxName.Text.Trim();
                _current.EqipmentNameType = comboBoxEqipmentNameType.Text.Trim();
                string s = (textBoxNumber1.Text ?? "").Trim();
                if (s != "") _current.Number1 = uint.Parse(s);
                _current.Note = richTextBoxNote.Text.Trim();
                string m = (textBoxInventoryNumber.Text ?? "").Trim();
                if (m != "") _current.InventoryNumber = uint.Parse(s);
                _current.Note = richTextBoxNote.Text.Trim();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ShowStatusMessage(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void labelNote_Click(object sender, EventArgs e)
        {

        }

        private void labelNumber1_Click(object sender, EventArgs e)
        {

        }

        private void labelEqipmentNameType_Click(object sender, EventArgs e)
        {

        }

        private void labelInventoryNumber_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
