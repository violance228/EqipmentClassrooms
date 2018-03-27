using System;
using System.Collections.Generic;
using EqipmentClassrooms.Domain;
using System.Windows.Forms;

namespace EqipmentClassrooms.Forms.Editing.ObjectEditing
{
    public partial class FAudienceEqipmentTypesEditing : Form
    {
        public FAudienceEqipmentTypesEditing()
        {
            InitializeComponent();
            AllowUserToAddNameTypeAudience = false;
            AllowUserToAddNameTypeEqipment = false;
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

        private bool _allowUserToAddNameTypeEqipment;

        public bool AllowUserToAddNameTypeEqipment
        {
            get { return _allowUserToAddNameTypeEqipment; }
            set
            {
                _allowUserToAddNameTypeEqipment = value;
                comboBoxEqipmentNameType.DropDownStyle = _allowUserToAddNameTypeEqipment ?
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
        public IEnumerable<string> NameTypeAudiences
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
            
        }
        void ShowStatusMessage(string message)
        {
            toolStripStatusLabelMessage.Text = message;
        }

        private void SetControlsState()
        {
            SetEditableProperties();
        }

        private void FAudienceEqipmentTypesEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
        private void FAudienceEqipmentTypesEditor_Load(object sender, EventArgs e)
        {
            SetControlsState();
        }

        private AudienceEqipmentTypes _current = new AudienceEqipmentTypes();

        public AudienceEqipmentTypes Current
        {
            get { return _current.Clone(); }
            set
            {
                if (value == null)
                {
                    _current = new AudienceEqipmentTypes();
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
            comboBoxEqipmentNameType.Text = _current.NameTypeEqipment;
            richTextBoxNote.Text = _current.Note;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxNameTypeAudience_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEqipmentNameType_SelectedIndexChanged(object sender, EventArgs e)
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
                _current.NameTypeAudience = comboBoxNameTypeAudience.Text.Trim();
                _current.NameTypeEqipment = comboBoxEqipmentNameType.Text.Trim();
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

        private void labelEqipmentNameType_Click(object sender, EventArgs e)
        {

        }

        private void labelNameTypeAudience_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
