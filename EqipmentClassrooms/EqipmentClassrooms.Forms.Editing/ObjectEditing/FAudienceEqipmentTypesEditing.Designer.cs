namespace EqipmentClassrooms.Forms.Editing.ObjectEditing
{
    partial class FAudienceEqipmentTypesEditing
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.toolStripPanel1 = new System.Windows.Forms.ToolStripPanel();
            this.labelNameTypeAudience = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelEqipmentNameType = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxNameTypeAudience = new System.Windows.Forms.ComboBox();
            this.comboBoxEqipmentNameType = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.statusStrip1, 2);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 284);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(355, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMessage
            // 
            this.toolStripStatusLabelMessage.AutoToolTip = true;
            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(340, 17);
            this.toolStripStatusLabelMessage.Spring = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxName.Location = new System.Drawing.Point(135, 2);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(218, 20);
            this.textBoxName.TabIndex = 12;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // toolStripPanel1
            // 
            this.toolStripPanel1.Location = new System.Drawing.Point(133, 78);
            this.toolStripPanel1.Name = "toolStripPanel1";
            this.toolStripPanel1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripPanel1.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripPanel1.Size = new System.Drawing.Size(0, 0);
            // 
            // labelNameTypeAudience
            // 
            this.labelNameTypeAudience.AutoSize = true;
            this.labelNameTypeAudience.Location = new System.Drawing.Point(3, 29);
            this.labelNameTypeAudience.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelNameTypeAudience.Name = "labelNameTypeAudience";
            this.labelNameTypeAudience.Size = new System.Drawing.Size(112, 13);
            this.labelNameTypeAudience.TabIndex = 0;
            this.labelNameTypeAudience.Text = "Назва типу аудиторії";
            this.labelNameTypeAudience.Click += new System.EventHandler(this.labelNameTypeAudience_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 5);
            this.labelName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Назва";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanelButtons, 2);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonOk);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonCancel);
            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(184, 250);
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
            // labelEqipmentNameType
            // 
            this.labelEqipmentNameType.AutoSize = true;
            this.labelEqipmentNameType.Location = new System.Drawing.Point(3, 56);
            this.labelEqipmentNameType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelEqipmentNameType.Name = "labelEqipmentNameType";
            this.labelEqipmentNameType.Size = new System.Drawing.Size(127, 13);
            this.labelEqipmentNameType.TabIndex = 0;
            this.labelEqipmentNameType.Text = "Назва типу обладнання";
            this.labelEqipmentNameType.Click += new System.EventHandler(this.labelEqipmentNameType_Click);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(3, 93);
            this.labelNote.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(54, 13);
            this.labelNote.TabIndex = 0;
            this.labelNote.Text = "Примітка";
            this.labelNote.Click += new System.EventHandler(this.labelNote_Click);
            // 
            // richTextBoxNote
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.richTextBoxNote, 2);
            this.richTextBoxNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxNote.Location = new System.Drawing.Point(3, 109);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.Size = new System.Drawing.Size(349, 135);
            this.richTextBoxNote.TabIndex = 6;
            this.richTextBoxNote.Text = "";
            this.richTextBoxNote.TextChanged += new System.EventHandler(this.richTextBoxNote_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelEqipmentNameType, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelNote, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxNote, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelButtons, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStripPanel1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelNameTypeAudience, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxNameTypeAudience, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxEqipmentNameType, 1, 6);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.228758F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.77124F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(355, 306);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // comboBoxNameTypeAudience
            // 
            this.comboBoxNameTypeAudience.FormattingEnabled = true;
            this.comboBoxNameTypeAudience.Location = new System.Drawing.Point(136, 27);
            this.comboBoxNameTypeAudience.Name = "comboBoxNameTypeAudience";
            this.comboBoxNameTypeAudience.Size = new System.Drawing.Size(151, 21);
            this.comboBoxNameTypeAudience.TabIndex = 14;
            this.comboBoxNameTypeAudience.SelectedIndexChanged += new System.EventHandler(this.comboBoxNameTypeAudience_SelectedIndexChanged);
            // 
            // comboBoxEqipmentNameType
            // 
            this.comboBoxEqipmentNameType.FormattingEnabled = true;
            this.comboBoxEqipmentNameType.Location = new System.Drawing.Point(136, 54);
            this.comboBoxEqipmentNameType.Name = "comboBoxEqipmentNameType";
            this.comboBoxEqipmentNameType.Size = new System.Drawing.Size(151, 21);
            this.comboBoxEqipmentNameType.TabIndex = 15;
            this.comboBoxEqipmentNameType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEqipmentNameType_SelectedIndexChanged);
            // 
            // FAudienceEqipmentTypesEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 306);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FAudienceEqipmentTypesEditing";
            this.Text = "Редагування типів аудиторій та обладнання";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelEqipmentNameType;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.RichTextBox richTextBoxNote;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ToolStripPanel toolStripPanel1;
        private System.Windows.Forms.Label labelNameTypeAudience;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxNameTypeAudience;
        private System.Windows.Forms.ComboBox comboBoxEqipmentNameType;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
    }
}