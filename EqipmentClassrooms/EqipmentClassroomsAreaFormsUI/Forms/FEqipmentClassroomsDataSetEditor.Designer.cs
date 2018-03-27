namespace CountriesAreaFormsUI.Forms
{
    partial class FCountriesAreaDataSetEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCountriesAreaDataSetEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAsText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataLoadTestData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditing = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditingEditEntityData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparatorEditingEntityData = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditingAddObject = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditingEditObject = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditingDeleteObject = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageListEditing = new System.Windows.Forms.ImageList(this.components);
            this.toolStripPanelTop = new System.Windows.Forms.ToolStripPanel();
            this.toolStripStandard = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripEditing = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.listBoxEntityObjects = new System.Windows.Forms.ListBox();
            this.labelEntityObjects = new System.Windows.Forms.Label();
            this.richTextBoxObjectData = new System.Windows.Forms.RichTextBox();
            this.labelObjectData = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEntities = new System.Windows.Forms.Label();
            this.listBoxEntities = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStripPanelTop.SuspendLayout();
            this.toolStripStandard.SuspendLayout();
            this.toolStripEditing.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuData,
            this.menuEditing});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(428, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.menuFileSaveAsText,
            this.menuFileClose,
            this.toolStripSeparator2,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(48, 20);
            this.menuFile.Text = "&Файл";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(211, 22);
            this.menuFileNew.Text = "&Новий...";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(211, 22);
            this.menuFileOpen.Text = "&Відкрити...";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(211, 22);
            this.menuFileSave.Text = "&Зберегти";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
            | System.Windows.Forms.Keys.S)));
            this.menuFileSaveAs.Size = new System.Drawing.Size(211, 22);
            this.menuFileSaveAs.Text = "Зберегти &як...";
            this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
            // 
            // menuFileSaveAsText
            // 
            this.menuFileSaveAsText.Name = "menuFileSaveAsText";
            this.menuFileSaveAsText.Size = new System.Drawing.Size(211, 22);
            this.menuFileSaveAsText.Text = "Зберегти як &текст...";
            this.menuFileSaveAsText.Click += new System.EventHandler(this.menuFileSaveAsText_Click);
            // 
            // menuFileClose
            // 
            this.menuFileClose.Name = "menuFileClose";
            this.menuFileClose.Size = new System.Drawing.Size(211, 22);
            this.menuFileClose.Text = "За&крити";
            this.menuFileClose.Click += new System.EventHandler(this.menuFileClose_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(208, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuFileExit.Size = new System.Drawing.Size(211, 22);
            this.menuFileExit.Text = "Ви&хід";
            // 
            // menuData
            // 
            this.menuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDataLoadTestData});
            this.menuData.Name = "menuData";
            this.menuData.Size = new System.Drawing.Size(43, 20);
            this.menuData.Text = "Да&ні";
            // 
            // menuDataLoadTestData
            // 
            this.menuDataLoadTestData.Name = "menuDataLoadTestData";
            this.menuDataLoadTestData.Size = new System.Drawing.Size(211, 22);
            this.menuDataLoadTestData.Text = "Завантажити тестові дані";
            this.menuDataLoadTestData.Click += new System.EventHandler(this.menuDataLoadTestData_Click);
            // 
            // menuEditing
            // 
            this.menuEditing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditingEditEntityData,
            this.menuSeparatorEditingEntityData,
            this.menuEditingAddObject,
            this.menuEditingEditObject,
            this.menuEditingDeleteObject});
            this.menuEditing.Name = "menuEditing";
            this.menuEditing.Size = new System.Drawing.Size(59, 20);
            this.menuEditing.Text = "&Правка";
            // 
            // menuEditingEditEntityData
            // 
            this.menuEditingEditEntityData.Name = "menuEditingEditEntityData";
            this.menuEditingEditEntityData.Size = new System.Drawing.Size(312, 22);
            this.menuEditingEditEntityData.Text = "Редагувати дані &сутності...";
            this.menuEditingEditEntityData.Click += new System.EventHandler(this.menuEditingEditEntityData_Click);
            // 
            // menuSeparatorEditingEntityData
            // 
            this.menuSeparatorEditingEntityData.Name = "menuSeparatorEditingEntityData";
            this.menuSeparatorEditingEntityData.Size = new System.Drawing.Size(309, 6);
            // 
            // menuEditingAddObject
            // 
            this.menuEditingAddObject.Name = "menuEditingAddObject";
            this.menuEditingAddObject.Size = new System.Drawing.Size(312, 22);
            this.menuEditingAddObject.Text = "&Додати об\'єкт вибраної сутності";
            // 
            // menuEditingEditObject
            // 
            this.menuEditingEditObject.Name = "menuEditingEditObject";
            this.menuEditingEditObject.Size = new System.Drawing.Size(312, 22);
            this.menuEditingEditObject.Text = "&Редагувати дані вибраного об\'єкта сутності";
            // 
            // menuEditingDeleteObject
            // 
            this.menuEditingDeleteObject.Name = "menuEditingDeleteObject";
            this.menuEditingDeleteObject.Size = new System.Drawing.Size(312, 22);
            this.menuEditingDeleteObject.Text = "&Видалити вибраний об\'єкт сутності";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 211);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(428, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMessage
            // 
            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(417, 17);
            this.toolStripStatusLabelMessage.Spring = true;
            // 
            // imageListEditing
            // 
            this.imageListEditing.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListEditing.ImageStream")));
            this.imageListEditing.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListEditing.Images.SetKeyName(0, "add");
            this.imageListEditing.Images.SetKeyName(1, "edit");
            this.imageListEditing.Images.SetKeyName(2, "delete");
            // 
            // toolStripPanelTop
            // 
            this.toolStripPanelTop.Controls.Add(this.toolStripStandard);
            this.toolStripPanelTop.Controls.Add(this.toolStripEditing);
            this.toolStripPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripPanelTop.Location = new System.Drawing.Point(0, 24);
            this.toolStripPanelTop.Name = "toolStripPanelTop";
            this.toolStripPanelTop.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripPanelTop.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripPanelTop.Size = new System.Drawing.Size(428, 27);
            // 
            // toolStripStandard
            // 
            this.toolStripStandard.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripStandard.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripStandard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonOpen,
            this.toolStripSeparator3,
            this.toolStripButtonSave});
            this.toolStripStandard.Location = new System.Drawing.Point(4, 0);
            this.toolStripStandard.Name = "toolStripStandard";
            this.toolStripStandard.Size = new System.Drawing.Size(90, 27);
            this.toolStripStandard.TabIndex = 2;
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = global::CountriesAreaFormsUI.Properties.Resources.New_document;
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonNew.Text = "toolStripButton1";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = global::CountriesAreaFormsUI.Properties.Resources.document_open;
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonOpen.Text = "toolStripButton2";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::EqipmentClassroomsAreaFormsUI.Properties.Resources.save;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonSave.Text = "toolStripButton3";
            this.toolStripButtonSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // toolStripEditing
            // 
            this.toolStripEditing.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEditing.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripEditing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripSeparator5,
            this.toolStripButtonDelete});
            this.toolStripEditing.Location = new System.Drawing.Point(97, 0);
            this.toolStripEditing.Name = "toolStripEditing";
            this.toolStripEditing.Size = new System.Drawing.Size(90, 27);
            this.toolStripEditing.TabIndex = 3;
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(24, 24);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(24, 24);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(24, 24);
            // 
            // listBoxEntityObjects
            // 
            this.listBoxEntityObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxEntityObjects.FormattingEnabled = true;
            this.listBoxEntityObjects.Location = new System.Drawing.Point(2, 76);
            this.listBoxEntityObjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxEntityObjects.Name = "listBoxEntityObjects";
            this.listBoxEntityObjects.Size = new System.Drawing.Size(124, 82);
            this.listBoxEntityObjects.Sorted = true;
            this.listBoxEntityObjects.TabIndex = 1;
            this.listBoxEntityObjects.SelectedIndexChanged += new System.EventHandler(this.listBoxEntityObjects_SelectedIndexChanged);
            // 
            // labelEntityObjects
            // 
            this.labelEntityObjects.AutoSize = true;
            this.labelEntityObjects.Location = new System.Drawing.Point(2, 61);
            this.labelEntityObjects.Margin = new System.Windows.Forms.Padding(2, 6, 2, 0);
            this.labelEntityObjects.Name = "labelEntityObjects";
            this.labelEntityObjects.Size = new System.Drawing.Size(90, 13);
            this.labelEntityObjects.TabIndex = 0;
            this.labelEntityObjects.Text = "Об\'єкти сутності";
            // 
            // richTextBoxObjectData
            // 
            this.richTextBoxObjectData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBoxObjectData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxObjectData.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxObjectData.Location = new System.Drawing.Point(130, 21);
            this.richTextBoxObjectData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxObjectData.Name = "richTextBoxObjectData";
            this.richTextBoxObjectData.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.richTextBoxObjectData, 3);
            this.richTextBoxObjectData.Size = new System.Drawing.Size(296, 137);
            this.richTextBoxObjectData.TabIndex = 1;
            this.richTextBoxObjectData.Text = "";
            this.richTextBoxObjectData.WordWrap = false;
            this.richTextBoxObjectData.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxObjectData_LinkClicked);
            this.richTextBoxObjectData.TextChanged += new System.EventHandler(this.richTextBoxObjectData_TextChanged);
            // 
            // labelObjectData
            // 
            this.labelObjectData.AutoSize = true;
            this.labelObjectData.Location = new System.Drawing.Point(130, 6);
            this.labelObjectData.Margin = new System.Windows.Forms.Padding(2, 6, 2, 0);
            this.labelObjectData.Name = "labelObjectData";
            this.labelObjectData.Size = new System.Drawing.Size(126, 13);
            this.labelObjectData.TabIndex = 0;
            this.labelObjectData.Text = "Дані вибраного об\'єкта";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.listBoxEntityObjects, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxObjectData, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelEntities, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelEntityObjects, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelObjectData, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxEntities, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 51);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(428, 160);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // labelEntities
            // 
            this.labelEntities.AutoSize = true;
            this.labelEntities.Location = new System.Drawing.Point(2, 6);
            this.labelEntities.Margin = new System.Windows.Forms.Padding(2, 6, 2, 0);
            this.labelEntities.Name = "labelEntities";
            this.labelEntities.Size = new System.Drawing.Size(68, 13);
            this.labelEntities.TabIndex = 0;
            this.labelEntities.Text = "Сутності ПО";
            // 
            // listBoxEntities
            // 
            this.listBoxEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxEntities.FormattingEnabled = true;
            this.listBoxEntities.Location = new System.Drawing.Point(2, 21);
            this.listBoxEntities.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxEntities.Name = "listBoxEntities";
            this.listBoxEntities.Size = new System.Drawing.Size(124, 32);
            this.listBoxEntities.TabIndex = 5;
            this.listBoxEntities.SelectedIndexChanged += new System.EventHandler(this.listBoxEntities_SelectedIndexChanged);
            // 
            // FCountriesAreaDataSetEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 233);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStripPanelTop);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(444, 272);
            this.Name = "FCountriesAreaDataSetEditor";
            this.Text = "FCountriesAreaDataSetEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripPanelTop.ResumeLayout(false);
            this.toolStripPanelTop.PerformLayout();
            this.toolStripStandard.ResumeLayout(false);
            this.toolStripStandard.PerformLayout();
            this.toolStripEditing.ResumeLayout(false);
            this.toolStripEditing.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        protected System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFileClose;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAsText;
        private System.Windows.Forms.ImageList imageListEditing;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
        private System.Windows.Forms.ToolStripMenuItem menuData;
        private System.Windows.Forms.ToolStripMenuItem menuDataLoadTestData;
        private System.Windows.Forms.ToolStripMenuItem menuEditing;
        private System.Windows.Forms.ToolStripMenuItem menuEditingEditEntityData;
        private System.Windows.Forms.ToolStripSeparator menuSeparatorEditingEntityData;
        private System.Windows.Forms.ToolStripMenuItem menuEditingAddObject;
        private System.Windows.Forms.ToolStripMenuItem menuEditingEditObject;
        private System.Windows.Forms.ToolStripMenuItem menuEditingDeleteObject;
        private System.Windows.Forms.ToolStripPanel toolStripPanelTop;
        private System.Windows.Forms.ListBox listBoxEntityObjects;
        private System.Windows.Forms.Label labelEntityObjects;
        private System.Windows.Forms.RichTextBox richTextBoxObjectData;
        private System.Windows.Forms.Label labelObjectData;
        private System.Windows.Forms.ToolStrip toolStripStandard;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStrip toolStripEditing;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelEntities;
        private System.Windows.Forms.ListBox listBoxEntities;
    }
}