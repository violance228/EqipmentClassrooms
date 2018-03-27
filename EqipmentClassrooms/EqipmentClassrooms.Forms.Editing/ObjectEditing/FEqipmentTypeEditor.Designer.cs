namespace EqipmentClassrooms.Forms.Editing.ObjectEditing
{
    partial class FEqipmentTypeEditor
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
            this.labelNote = new System.Windows.Forms.Label();
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelRegionName = new System.Windows.Forms.Panel();
            this.comboBoxEqipmentNameType = new System.Windows.Forms.ComboBox();
            this.labelDefinition = new System.Windows.Forms.Label();
            this.richTextBoxDefinition = new System.Windows.Forms.RichTextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.labelNote, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxNote, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelButtons, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.panelRegionName, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelDefinition, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxDefinition, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 0);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.3913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.6087F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(299, 352);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // labelEqipmentNameType
            // 
            this.labelEqipmentNameType.AutoSize = true;
            this.labelEqipmentNameType.Location = new System.Drawing.Point(3, 29);
            this.labelEqipmentNameType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelEqipmentNameType.Name = "labelEqipmentNameType";
            this.labelEqipmentNameType.Size = new System.Drawing.Size(128, 13);
            this.labelEqipmentNameType.TabIndex = 0;
            this.labelEqipmentNameType.Text = "Назва виду обладнання";
            this.labelEqipmentNameType.Click += new System.EventHandler(this.labelEqipmentNameType_Click);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(3, 194);
            this.labelNote.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(54, 13);
            this.labelNote.TabIndex = 0;
            this.labelNote.Text = "Примітка";
            // 
            // richTextBoxNote
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.richTextBoxNote, 3);
            this.richTextBoxNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxNote.Location = new System.Drawing.Point(3, 210);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.Size = new System.Drawing.Size(293, 80);
            this.richTextBoxNote.TabIndex = 6;
            this.richTextBoxNote.Text = "";
            this.richTextBoxNote.TextChanged += new System.EventHandler(this.richTextBoxNote_TextChanged);
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanelButtons, 3);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonOk);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonCancel);
            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(128, 296);
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
            this.statusStrip1.Size = new System.Drawing.Size(299, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMessage
            // 
            this.toolStripStatusLabelMessage.AutoToolTip = true;
            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(284, 17);
            this.toolStripStatusLabelMessage.Spring = true;
            // 
            // panelRegionName
            // 
            this.panelRegionName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.panelRegionName, 2);
            this.panelRegionName.Controls.Add(this.comboBoxEqipmentNameType);
            this.panelRegionName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegionName.Location = new System.Drawing.Point(136, 26);
            this.panelRegionName.Margin = new System.Windows.Forms.Padding(2);
            this.panelRegionName.Name = "panelRegionName";
            this.panelRegionName.Size = new System.Drawing.Size(161, 21);
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
            this.comboBoxEqipmentNameType.Size = new System.Drawing.Size(161, 21);
            this.comboBoxEqipmentNameType.Sorted = true;
            this.comboBoxEqipmentNameType.TabIndex = 1;
            this.comboBoxEqipmentNameType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEqipmentNameType_SelectedIndexChanged);
            // 
            // labelDefinition
            // 
            this.labelDefinition.AutoSize = true;
            this.labelDefinition.Location = new System.Drawing.Point(3, 57);
            this.labelDefinition.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelDefinition.Name = "labelDefinition";
            this.labelDefinition.Size = new System.Drawing.Size(33, 13);
            this.labelDefinition.TabIndex = 0;
            this.labelDefinition.Text = "Опис";
            // 
            // richTextBoxDefinition
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.richTextBoxDefinition, 3);
            this.richTextBoxDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDefinition.Location = new System.Drawing.Point(3, 73);
            this.richTextBoxDefinition.Name = "richTextBoxDefinition";
            this.richTextBoxDefinition.Size = new System.Drawing.Size(293, 110);
            this.richTextBoxDefinition.TabIndex = 5;
            this.richTextBoxDefinition.Text = "";
            this.richTextBoxDefinition.TextChanged += new System.EventHandler(this.richTextBoxDefinition_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 5);
            this.labelName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(102, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Назва обладнання";
            // 
            // textBoxName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxName, 2);
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxName.Location = new System.Drawing.Point(136, 2);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(161, 20);
            this.textBoxName.TabIndex = 12;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // FEqipmentTypeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 352);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FEqipmentTypeEditor";
            this.Text = "Редагування типів обладнання";
            this.Load += new System.EventHandler(this.FEqipmentTypeEditor_Load);
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
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.RichTextBox richTextBoxNote;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
        private System.Windows.Forms.Panel panelRegionName;

        private System.Windows.Forms.ComboBox comboBoxEqipmentNameType;
        private System.Windows.Forms.Label labelDefinition;
        private System.Windows.Forms.RichTextBox richTextBoxDefinition;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        
    }
}