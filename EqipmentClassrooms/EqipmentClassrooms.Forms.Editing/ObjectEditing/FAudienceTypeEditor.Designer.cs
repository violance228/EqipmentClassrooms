namespace EqipmentClassrooms.Forms.Editing.ObjectEditing
{
    partial class FAudienceTypeEditor
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelNote = new System.Windows.Forms.Label();
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.labelDefinition = new System.Windows.Forms.Label();
            this.richTextBoxDefinition = new System.Windows.Forms.RichTextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.toolStripPanel1 = new System.Windows.Forms.ToolStripPanel();
            this.labelAbbreviation = new System.Windows.Forms.Label();
            this.labelNameAudience = new System.Windows.Forms.Label();
            this.comboBoxNameTypeAudience = new System.Windows.Forms.ComboBox();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMessage
            // 
            this.toolStripStatusLabelMessage.AutoToolTip = true;
            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(269, 17);
            this.toolStripStatusLabelMessage.Spring = true;
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
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanelButtons, 2);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonOk);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonCancel);
            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(113, 305);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(168, 30);
            this.flowLayoutPanelButtons.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelNote, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxNote, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelButtons, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.labelDefinition, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxDefinition, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStripPanel1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelAbbreviation, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNameAudience, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxNameTypeAudience, 1, 1);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 361);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(3, 200);
            this.labelNote.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(54, 13);
            this.labelNote.TabIndex = 0;
            this.labelNote.Text = "Примітка";
            // 
            // richTextBoxNote
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.richTextBoxNote, 2);
            this.richTextBoxNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxNote.Location = new System.Drawing.Point(3, 216);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.Size = new System.Drawing.Size(278, 83);
            this.richTextBoxNote.TabIndex = 6;
            this.richTextBoxNote.Text = "";
            this.richTextBoxNote.TextChanged += new System.EventHandler(this.richTextBoxNote_TextChanged);
            // 
            // labelDefinition
            // 
            this.labelDefinition.AutoSize = true;
            this.labelDefinition.Location = new System.Drawing.Point(3, 59);
            this.labelDefinition.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelDefinition.Name = "labelDefinition";
            this.labelDefinition.Size = new System.Drawing.Size(33, 13);
            this.labelDefinition.TabIndex = 0;
            this.labelDefinition.Text = "Опис";
            // 
            // richTextBoxDefinition
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.richTextBoxDefinition, 2);
            this.richTextBoxDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDefinition.Location = new System.Drawing.Point(3, 75);
            this.richTextBoxDefinition.Name = "richTextBoxDefinition";
            this.richTextBoxDefinition.Size = new System.Drawing.Size(278, 114);
            this.richTextBoxDefinition.TabIndex = 5;
            this.richTextBoxDefinition.Text = "";
            this.richTextBoxDefinition.TextChanged += new System.EventHandler(this.richTextBoxDefinition_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxName.Location = new System.Drawing.Point(120, 2);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(162, 20);
            this.textBoxName.TabIndex = 12;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // toolStripPanel1
            // 
            this.toolStripPanel1.Location = new System.Drawing.Point(118, 51);
            this.toolStripPanel1.Name = "toolStripPanel1";
            this.toolStripPanel1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripPanel1.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripPanel1.Size = new System.Drawing.Size(0, 0);
            // 
            // labelAbbreviation
            // 
            this.labelAbbreviation.AutoSize = true;
            this.labelAbbreviation.Location = new System.Drawing.Point(3, 29);
            this.labelAbbreviation.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelAbbreviation.Name = "labelAbbreviation";
            this.labelAbbreviation.Size = new System.Drawing.Size(112, 13);
            this.labelAbbreviation.TabIndex = 0;
            this.labelAbbreviation.Text = "Назва типу аудиторії";
            this.labelAbbreviation.Click += new System.EventHandler(this.labelAbbreviation_Click);
            // 
            // labelNameAudience
            // 
            this.labelNameAudience.AutoSize = true;
            this.labelNameAudience.Location = new System.Drawing.Point(3, 5);
            this.labelNameAudience.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelNameAudience.Name = "labelNameAudience";
            this.labelNameAudience.Size = new System.Drawing.Size(87, 13);
            this.labelNameAudience.TabIndex = 0;
            this.labelNameAudience.Text = "Назва аудиторії";
            // 
            // comboBoxNameTypeAudience
            // 
            this.comboBoxNameTypeAudience.FormattingEnabled = true;
            this.comboBoxNameTypeAudience.Location = new System.Drawing.Point(121, 27);
            this.comboBoxNameTypeAudience.Name = "comboBoxNameTypeAudience";
            this.comboBoxNameTypeAudience.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNameTypeAudience.TabIndex = 14;
            this.comboBoxNameTypeAudience.SelectedIndexChanged += new System.EventHandler(this.comboBoxNameTypeAudience_SelectedIndexChanged);
            // 
            // FAudienceTypeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FAudienceTypeEditor";
            this.Text = "Редагування типу аудиторії";
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
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.RichTextBox richTextBoxNote;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelDefinition;
        private System.Windows.Forms.RichTextBox richTextBoxDefinition;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ToolStripPanel toolStripPanel1;
        private System.Windows.Forms.Label labelAbbreviation;

        private System.Windows.Forms.Label labelNameAudience;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
        private System.Windows.Forms.ComboBox comboBoxNameTypeAudience;
        
    }
}