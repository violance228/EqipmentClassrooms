using System;
using System.Collections.Generic;
using System.Linq;
using EqipmentClassrooms.Domain;
using System.Windows.Forms;

namespace EqipmentClassrooms.Forms.Editing.ObjectEditing
{
    public partial class FEqipmentEditor : Form
    {
        public FEqipmentEditor()
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
        void ShowStatusMessage(string message)
        {
            toolStripStatusLabelMessage.Text = message;
        }

        private void SetEditableProperties()
        {
            buttonOk.Visible = !_readOnly;
            textBoxName.ReadOnly = _readOnly;
            richTextBoxDescription.ReadOnly = _readOnly;
            dateTimePickerDate.Visible = !_readOnly;
        }
        private void FEqipmentEditor_Load(object sender, EventArgs e)
        {
            SetControlsState();
        }

        private void SetControlsState()
        {
            SetEditableProperties();
        }

        private void FEqipmentEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void control_TextChanged(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control == null) return;
            toolTip1.SetToolTip(control, control.Text);
        }

        private Eqipment _current = new Eqipment();

        public Eqipment Current
        {
            get { return _current.Copy(); }
            set
            {
                if (value == null)
                {
                    _current = new Eqipment();
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
            richTextBoxDescription.Text = _current.Description;
            if(_current.Date.HasValue) {
                dateTimePickerDate.Value = _current.Date.Value;
                dateTimePickerDate.Checked = true;
                textBoxDate.Text = _current.Date.Value.ToString("d");
            } else {
                dateTimePickerDate.Checked = false;
                textBoxDate.Text = "";
            }
        }

        private void textBoxEqipmentNameType_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void labelCountryName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control == null) return;
            toolTip1.SetToolTip(control, control.Text);
        }

        private void richTextBoxDescription_TextChanged(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control == null) return;
            toolTip1.SetToolTip(control, control.Text);
        }

        

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            _current.Date = dateTimePickerDate.Value;
            SetControlsState();
        }
        private void dateTimePickerDate_Leave(object sender, EventArgs e)
        {
            if (!dateTimePickerDate.Checked)
            {
                _current.Date = null;
                dateTimePickerDate.Select();
                SetControlsState();
            }
        }
        private void dateTimePickerDate_MouseUp(object sender, MouseEventArgs e)
        {
            if (!dateTimePickerDate.Checked)
            {
                _current.Date = null;
                ShowStatusMessage("Потрібно вказати дату");
            }
            SetControlsState();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                _current.Name = textBoxName.Text.Trim();
                _current.EqipmentNameType = comboBoxEqipmentNameType.Text.Trim();
               
                _current.Description = richTextBoxDescription.Text;
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ShowStatusMessage(ex.Message);
            }
        }

        private void comboBoxEqipmentNameType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
