using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EqipmentClassrooms.Domain;

namespace EqipmentClassrooms.Forms.Editing.ObjectEditing
{
    public partial class FAudienceTypeEditor : Form
    {
        public FAudienceTypeEditor()
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


        private void FAudienceEditor_Load(object sender, EventArgs e)
        {
            SetControlsState();
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

        private void control_TextChanged(object sender, EventArgs e)
        {
           
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

        void ShowStatusMessage(string message)
        {
            toolStripStatusLabelMessage.Text = message;
        }

        private void SetEditableProperties()
        {
            buttonOk.Visible = !_readOnly;
            textBoxName.ReadOnly = _readOnly;
            comboBoxNameTypeAudience.Visible = _readOnly;

            richTextBoxNote.ReadOnly = _readOnly;
        }
        private AudienceType _current = new AudienceType();

        public AudienceType Current
        {
            get { return _current.Clone(); }
            set
            {
                if (value == null)
                {
                    _current = new AudienceType();
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
            textBoxName.Text = _current.Name ?? "";
            comboBoxNameTypeAudience.Text = _current.NameTypeAudience ?? "";
            richTextBoxDefinition.Text = _current.Definition;
            richTextBoxNote.Text = _current.Note ?? "";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void richTextBoxDefinition_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxNameTypeAudience_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxNote_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void labelAbbreviation_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxNameTypeAudience_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            _current.Name = textBoxName.Text.Trim();
            _current.NameTypeAudience = comboBoxNameTypeAudience.Text;
            _current.Definition = richTextBoxDefinition.Text;
            _current.Note = richTextBoxNote.Text.Trim();
        }
    }
}
