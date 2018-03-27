using EqipmentClassrooms.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EqipmentClassrooms.Forms.Editing.ObjectEditing
{
    public partial class FEqipmentTypeEditor : Form
    {
        public FEqipmentTypeEditor()
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
                comboBoxEqipmentNameType.Items.AddRange(value.ToArray());
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
        void ShowStatusMessage(string message)
        {
            toolStripStatusLabelMessage.Text = message;
        }

        private void SetEditableProperties()
        {
            buttonOk.Visible = !_readOnly;
            textBoxName.ReadOnly = _readOnly;
            comboBoxEqipmentNameType.Visible = !_readOnly;
            richTextBoxNote.ReadOnly = _readOnly;
            richTextBoxDefinition.ReadOnly = _readOnly;
        }

        private void FEqipmentTypeEditor_Load(object sender, EventArgs e)
        {
            SetControlsState();
        }

        private void SetControlsState()
        {
            SetEditableProperties();
        }

        private void FEqipmentTypeEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private EqipmentType _current = new EqipmentType();

        public EqipmentType Current
        {
            get { return _current.Copy(); }
            set
            {
                if (value == null)
                {
                    _current = new EqipmentType();
                }
                else
                {
                    _current = value.Copy();
                }
                ShowMembers();
                SetControlsState();
            }
        }

        private void ShowMembers()
        {
            textBoxName.Text = _current.Name;
            comboBoxEqipmentNameType.Text = _current.EqipmentNameType;
            
            richTextBoxDefinition.Text = _current.Definition;
            richTextBoxNote.Text = _current.Note;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void labelEqipmentNameType_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEqipmentNameType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBoxDefinition_TextChanged(object sender, EventArgs e)
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
                _current.EqipmentNameType = comboBoxEqipmentNameType.Text;
                _current.Definition = richTextBoxDefinition.Text;
                _current.Note = richTextBoxNote.Text.Trim();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ShowStatusMessage(ex.Message);
            }
        }
    }
}
