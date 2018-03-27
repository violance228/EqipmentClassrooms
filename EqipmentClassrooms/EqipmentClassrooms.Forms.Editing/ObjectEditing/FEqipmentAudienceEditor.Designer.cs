namespace EqipmentClassrooms.Forms.Editing.ObjectEditing
{
    partial class FEqipmentAudienceEditor
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEqipmentNameType = new System.Windows.Forms.Label();
            this.labelNumber1 = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelRegionName = new System.Windows.Forms.Panel();
            this.comboBoxEqipmentNameType = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInventoryNumber = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxInventoryNumber = new System.Windows.Forms.TextBox();
            this.textBoxNumber1 = new System.Windows.Forms.TextBox();
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelRegionName.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelEqipmentNameType, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelNumber1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelNote, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelButtons, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.panelRegionName, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelInventoryNumber, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxInventoryNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNumber1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxNote, 1, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.145078F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.85492F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(323, 352);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // labelEqipmentNameType
            // 
            this.labelEqipmentNameType.AutoSize = true;
            this.labelEqipmentNameType.Location = new System.Drawing.Point(3, 53);
            this.labelEqipmentNameType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelEqipmentNameType.Name = "labelEqipmentNameType";
            this.labelEqipmentNameType.Size = new System.Drawing.Size(127, 13);
            this.labelEqipmentNameType.TabIndex = 0;
            this.labelEqipmentNameType.Text = "Назва типу обладнання";
            this.labelEqipmentNameType.Click += new System.EventHandler(this.labelEqipmentNameType_Click);
            // 
            // labelNumber1
            // 
            this.labelNumber1.AutoSize = true;
            this.labelNumber1.Location = new System.Drawing.Point(3, 78);
            this.labelNumber1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelNumber1.Name = "labelNumber1";
            this.labelNumber1.Size = new System.Drawing.Size(89, 13);
            this.labelNumber1.TabIndex = 0;
            this.labelNumber1.Text = "Номер аудиторії";
            this.labelNumber1.Click += new System.EventHandler(this.labelNumber1_Click);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(3, 112);
            this.labelNote.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(54, 13);
            this.labelNote.TabIndex = 0;
            this.labelNote.Text = "Примітка";
            this.labelNote.Click += new System.EventHandler(this.labelNote_Click);
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanelButtons, 3);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonOk);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonCancel);
            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(152, 296);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(168, 30);
            this.flowLayoutPanelButtons.TabIndex = 6;
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
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // statusStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.statusStrip1, 3);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 330);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(323, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMessage
            // 
            this.toolStripStatusLabelMessage.AutoToolTip = true;
            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(308, 17);
            this.toolStripStatusLabelMessage.Spring = true;
            // 
            // panelRegionName
            // 
            this.panelRegionName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.panelRegionName, 2);
            this.panelRegionName.Controls.Add(this.comboBoxEqipmentNameType);
            this.panelRegionName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegionName.Location = new System.Drawing.Point(135, 50);
            this.panelRegionName.Margin = new System.Windows.Forms.Padding(2);
            this.panelRegionName.Name = "panelRegionName";
            this.panelRegionName.Size = new System.Drawing.Size(186, 21);
            this.panelRegionName.TabIndex = 10;
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
            this.comboBoxEqipmentNameType.Size = new System.Drawing.Size(186, 21);
            this.comboBoxEqipmentNameType.Sorted = true;
            this.comboBoxEqipmentNameType.TabIndex = 1;
            this.comboBoxEqipmentNameType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEqipmentNameType_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 5);
            this.labelName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(87, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Назва аудиторії";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelInventoryNumber
            // 
            this.labelInventoryNumber.AutoSize = true;
            this.labelInventoryNumber.Location = new System.Drawing.Point(3, 29);
            this.labelInventoryNumber.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelInventoryNumber.Name = "labelInventoryNumber";
            this.labelInventoryNumber.Size = new System.Drawing.Size(104, 13);
            this.labelInventoryNumber.TabIndex = 0;
            this.labelInventoryNumber.Text = "Інвентарний номер";
            this.labelInventoryNumber.Click += new System.EventHandler(this.labelInventoryNumber_Click);
            // 
            // textBoxName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxName, 2);
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxName.Location = new System.Drawing.Point(135, 2);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(186, 20);
            this.textBoxName.TabIndex = 12;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxInventoryNumber
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxInventoryNumber, 2);
            this.textBoxInventoryNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxInventoryNumber.Location = new System.Drawing.Point(135, 26);
            this.textBoxInventoryNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxInventoryNumber.Name = "textBoxInventoryNumber";
            this.textBoxInventoryNumber.Size = new System.Drawing.Size(186, 20);
            this.textBoxInventoryNumber.TabIndex = 12;
            this.textBoxInventoryNumber.TextChanged += new System.EventHandler(this.textBoxInventoryNumber_TextChanged);
            // 
            // textBoxNumber1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxNumber1, 2);
            this.textBoxNumber1.Location = new System.Drawing.Point(135, 75);
            this.textBoxNumber1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumber1.Name = "textBoxNumber1";
            this.textBoxNumber1.Size = new System.Drawing.Size(99, 20);
            this.textBoxNumber1.TabIndex = 12;
            this.textBoxNumber1.TextChanged += new System.EventHandler(this.textBoxNumber1_TextChanged);
            // 
            // richTextBoxNote
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.richTextBoxNote, 3);
            this.richTextBoxNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxNote.Location = new System.Drawing.Point(3, 128);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.Size = new System.Drawing.Size(317, 162);
            this.richTextBoxNote.TabIndex = 6;
            this.richTextBoxNote.Text = "";
            this.richTextBoxNote.TextChanged += new System.EventHandler(this.richTextBoxNote_TextChanged);
            // 
            // FEqipmentAudienceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 352);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FEqipmentAudienceEditor";
            this.Text = "Редагування обладнання аудиторій";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelRegionName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelEqipmentNameType;
        private System.Windows.Forms.Label labelNumber1;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.RichTextBox richTextBoxNote;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
        private System.Windows.Forms.Panel panelRegionName;

        private System.Windows.Forms.ComboBox comboBoxEqipmentNameType;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInventoryNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxInventoryNumber;
        private System.Windows.Forms.TextBox textBoxNumber1;
    }
}