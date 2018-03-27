using System;

namespace EqipmentClassrooms.Forms.Editing.ObjectEditing
{
    partial class FEqipmentEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolTip1 = new System.Windows.Forms.ToolTip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCountryName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanelData = new System.Windows.Forms.FlowLayoutPanel();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStripPicker = new System.Windows.Forms.ContextMenuStrip();
            this.mnuPickerShowCheckBox = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPickerShowUpDown = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxEqipmentNameType = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.flowLayoutPanelData.SuspendLayout();
            this.contextMenuStripPicker.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelCountryName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDescription, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxDescription, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelData, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelDate, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.20765F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.79235F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 388);
            this.tableLayoutPanel1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.tableLayoutPanel1, "Вікно редагування даних чисельності населення країни");
            // 
            // labelCountryName
            // 
            this.labelCountryName.AutoSize = true;
            this.labelCountryName.Location = new System.Drawing.Point(3, 5);
            this.labelCountryName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelCountryName.Name = "labelCountryName";
            this.labelCountryName.Size = new System.Drawing.Size(130, 13);
            this.labelCountryName.TabIndex = 0;
            this.labelCountryName.Text = "Назва типу  обладнання";
            this.labelCountryName.Click += new System.EventHandler(this.labelCountryName_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(3, 141);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(54, 13);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Примітка";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(139, 82);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(138, 20);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // richTextBoxDescription
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.richTextBoxDescription, 2);
            this.richTextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDescription.Location = new System.Drawing.Point(3, 157);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(274, 169);
            this.richTextBoxDescription.TabIndex = 6;
            this.richTextBoxDescription.Text = "";
            this.richTextBoxDescription.TextChanged += new System.EventHandler(this.richTextBoxDescription_TextChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel2, 2);
            this.flowLayoutPanel2.Controls.Add(this.buttonOk);
            this.flowLayoutPanel2.Controls.Add(this.buttonCancel);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(109, 332);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(168, 30);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(3, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(78, 24);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "Зберегти";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(87, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(78, 24);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Відмінити";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.statusStrip1, 2);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 366);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(280, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMessage
            // 
            this.toolStripStatusLabelMessage.AutoToolTip = true;
            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(265, 17);
            this.toolStripStatusLabelMessage.Spring = true;
            // 
            // flowLayoutPanelData
            // 
            this.flowLayoutPanelData.AutoSize = true;
            this.flowLayoutPanelData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelData.Controls.Add(this.dateTimePickerDate);
            this.flowLayoutPanelData.Controls.Add(this.textBoxDate);
            this.flowLayoutPanelData.Location = new System.Drawing.Point(138, 27);
            this.flowLayoutPanelData.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelData.Name = "flowLayoutPanelData";
            this.flowLayoutPanelData.Size = new System.Drawing.Size(105, 50);
            this.flowLayoutPanelData.TabIndex = 8;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Checked = false;
            this.dateTimePickerDate.ContextMenuStrip = this.contextMenuStripPicker;
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(3, 3);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.ShowCheckBox = true;
            this.dateTimePickerDate.Size = new System.Drawing.Size(99, 20);
            this.dateTimePickerDate.TabIndex = 2;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // contextMenuStripPicker
            // 
            this.contextMenuStripPicker.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripPicker.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPickerShowCheckBox,
            this.mnuPickerShowUpDown});
            this.contextMenuStripPicker.Name = "contextMenuStripTicket";
            this.contextMenuStripPicker.Size = new System.Drawing.Size(220, 48);
            // 
            // mnuPickerShowCheckBox
            // 
            this.mnuPickerShowCheckBox.Checked = true;
            this.mnuPickerShowCheckBox.CheckOnClick = true;
            this.mnuPickerShowCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuPickerShowCheckBox.Name = "mnuPickerShowCheckBox";
            this.mnuPickerShowCheckBox.Size = new System.Drawing.Size(219, 22);
            this.mnuPickerShowCheckBox.Text = "Відображувати &прапорець";
            // 
            // mnuPickerShowUpDown
            // 
            this.mnuPickerShowUpDown.CheckOnClick = true;
            this.mnuPickerShowUpDown.Name = "mnuPickerShowUpDown";
            this.mnuPickerShowUpDown.Size = new System.Drawing.Size(219, 22);
            this.mnuPickerShowUpDown.Text = "Відображувати &регулятор";
            // 
            // textBoxDate
            // 
            this.textBoxDate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxDate.Location = new System.Drawing.Point(2, 28);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.comboBoxEqipmentNameType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(138, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 21);
            this.panel1.TabIndex = 10;
            // 
            // comboBoxEqipmentNameType
            // 
            this.comboBoxEqipmentNameType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxEqipmentNameType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEqipmentNameType.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxEqipmentNameType.FormattingEnabled = true;
            this.comboBoxEqipmentNameType.Items.AddRange(new object[] {
            "Автоматизированное управление комплексом",
            "Источники аудио и видеосигналов",
            "Оборудование для звукоусиления речи и музыки",
            "Общая характеристика учебных аудиторий",
            "Система отображения графической информации",
            "Системы тестирования и голосования",
            "Функциональная или спец мебель"});
            this.comboBoxEqipmentNameType.Location = new System.Drawing.Point(0, 0);
            this.comboBoxEqipmentNameType.Name = "comboBoxEqipmentNameType";
            this.comboBoxEqipmentNameType.Size = new System.Drawing.Size(140, 21);
            this.comboBoxEqipmentNameType.Sorted = true;
            this.comboBoxEqipmentNameType.TabIndex = 1;
            this.comboBoxEqipmentNameType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEqipmentNameType_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 84);
            this.labelName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(69, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Обладнання";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(3, 30);
            this.labelDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Дата";
            // 
            // FEqipmentEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 388);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FEqipmentEditor";
            this.Text = "Редагування обладнання";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flowLayoutPanelData.ResumeLayout(false);
            this.flowLayoutPanelData.PerformLayout();
            this.contextMenuStripPicker.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void textBoxCountryName_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCountryName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelData;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPicker;
        private System.Windows.Forms.ToolStripMenuItem mnuPickerShowCheckBox;
        private System.Windows.Forms.ToolStripMenuItem mnuPickerShowUpDown;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDate;
      
        private System.Windows.Forms.ComboBox comboBoxEqipmentNameType;
    }
}