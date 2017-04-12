namespace RimworldModManager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dgrvMods = new System.Windows.Forms.DataGridView();
            this.dgrvMods_SequenceDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrvMods_DiskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrvMods_XMLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrvMods_Issues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrvMods_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsrcModDetails = new System.Windows.Forms.BindingSource(this.components);
            this.toolModGrid = new System.Windows.Forms.ToolStrip();
            this.toolModGrid_MoveUp = new System.Windows.Forms.ToolStripButton();
            this.toolModGrid_MoveDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolModGrid_Toggle = new System.Windows.Forms.ToolStripButton();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.bttnSaveAndRun = new System.Windows.Forms.Button();
            this.bttnSaveConfig = new System.Windows.Forms.Button();
            this.lblProfileLabel = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.splitModGridAndDetails = new System.Windows.Forms.SplitContainer();
            this.txbxModDetails = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.tabcMain = new System.Windows.Forms.TabControl();
            this.tabcMain_ProfileSelection = new System.Windows.Forms.TabPage();
            this.panlProfileSelectionFooter = new System.Windows.Forms.Panel();
            this.bttnSaveProfile = new System.Windows.Forms.Button();
            this.bttnLoadProfile = new System.Windows.Forms.Button();
            this.bttnNew = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.dgrvSettings = new System.Windows.Forms.DataGridView();
            this.rimworldFolderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfigFolderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkshopFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsrcSettings = new System.Windows.Forms.BindingSource(this.components);
            this.tabcMain_ModManager = new System.Windows.Forms.TabPage();
            this.panl_MainFooter = new System.Windows.Forms.Panel();
            this.bttnManageResearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvMods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcModDetails)).BeginInit();
            this.toolModGrid.SuspendLayout();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitModGridAndDetails)).BeginInit();
            this.splitModGridAndDetails.Panel1.SuspendLayout();
            this.splitModGridAndDetails.Panel2.SuspendLayout();
            this.splitModGridAndDetails.SuspendLayout();
            this.tabcMain.SuspendLayout();
            this.tabcMain_ProfileSelection.SuspendLayout();
            this.panlProfileSelectionFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcSettings)).BeginInit();
            this.tabcMain_ModManager.SuspendLayout();
            this.panl_MainFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrvMods
            // 
            this.dgrvMods.AllowUserToAddRows = false;
            this.dgrvMods.AllowUserToDeleteRows = false;
            this.dgrvMods.AllowUserToResizeRows = false;
            this.dgrvMods.AutoGenerateColumns = false;
            this.dgrvMods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvMods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgrvMods_SequenceDescription,
            this.dgrvMods_DiskName,
            this.dgrvMods_XMLName,
            this.dgrvMods_Issues,
            this.dgrvMods_Author});
            this.dgrvMods.DataSource = this.bsrcModDetails;
            this.dgrvMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrvMods.Location = new System.Drawing.Point(0, 0);
            this.dgrvMods.Name = "dgrvMods";
            this.dgrvMods.ReadOnly = true;
            this.dgrvMods.Size = new System.Drawing.Size(511, 315);
            this.dgrvMods.TabIndex = 0;
            this.dgrvMods.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvMods_CellDoubleClick);
            this.dgrvMods.SelectionChanged += new System.EventHandler(this.dgrvMods_SelectionChanged);
            // 
            // dgrvMods_SequenceDescription
            // 
            this.dgrvMods_SequenceDescription.DataPropertyName = "SequenceDescription";
            this.dgrvMods_SequenceDescription.HeaderText = "Sequence";
            this.dgrvMods_SequenceDescription.Name = "dgrvMods_SequenceDescription";
            this.dgrvMods_SequenceDescription.ReadOnly = true;
            // 
            // dgrvMods_DiskName
            // 
            this.dgrvMods_DiskName.DataPropertyName = "DiskName";
            this.dgrvMods_DiskName.HeaderText = "DiskName";
            this.dgrvMods_DiskName.Name = "dgrvMods_DiskName";
            this.dgrvMods_DiskName.ReadOnly = true;
            // 
            // dgrvMods_XMLName
            // 
            this.dgrvMods_XMLName.DataPropertyName = "XMLName";
            this.dgrvMods_XMLName.HeaderText = "XMLName";
            this.dgrvMods_XMLName.Name = "dgrvMods_XMLName";
            this.dgrvMods_XMLName.ReadOnly = true;
            // 
            // dgrvMods_Issues
            // 
            this.dgrvMods_Issues.DataPropertyName = "Issues";
            this.dgrvMods_Issues.HeaderText = "Issues";
            this.dgrvMods_Issues.Name = "dgrvMods_Issues";
            this.dgrvMods_Issues.ReadOnly = true;
            // 
            // dgrvMods_Author
            // 
            this.dgrvMods_Author.DataPropertyName = "Author";
            this.dgrvMods_Author.HeaderText = "Author";
            this.dgrvMods_Author.Name = "dgrvMods_Author";
            this.dgrvMods_Author.ReadOnly = true;
            // 
            // bsrcModDetails
            // 
            this.bsrcModDetails.DataSource = typeof(RimworldModManager.DataObjects.ModDetails);
            // 
            // toolModGrid
            // 
            this.toolModGrid.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolModGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolModGrid_MoveUp,
            this.toolModGrid_MoveDown,
            this.toolStripSeparator1,
            this.toolModGrid_Toggle});
            this.toolModGrid.Location = new System.Drawing.Point(3, 3);
            this.toolModGrid.Name = "toolModGrid";
            this.toolModGrid.Size = new System.Drawing.Size(720, 25);
            this.toolModGrid.TabIndex = 1;
            this.toolModGrid.Text = "toolStrip1";
            // 
            // toolModGrid_MoveUp
            // 
            this.toolModGrid_MoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolModGrid_MoveUp.Image = ((System.Drawing.Image)(resources.GetObject("toolModGrid_MoveUp.Image")));
            this.toolModGrid_MoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolModGrid_MoveUp.Name = "toolModGrid_MoveUp";
            this.toolModGrid_MoveUp.Size = new System.Drawing.Size(59, 22);
            this.toolModGrid_MoveUp.Text = "Move Up";
            this.toolModGrid_MoveUp.Click += new System.EventHandler(this.toolModGrid_MoveUp_Click);
            // 
            // toolModGrid_MoveDown
            // 
            this.toolModGrid_MoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolModGrid_MoveDown.Image = ((System.Drawing.Image)(resources.GetObject("toolModGrid_MoveDown.Image")));
            this.toolModGrid_MoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolModGrid_MoveDown.Name = "toolModGrid_MoveDown";
            this.toolModGrid_MoveDown.Size = new System.Drawing.Size(75, 22);
            this.toolModGrid_MoveDown.Text = "Move Down";
            this.toolModGrid_MoveDown.Click += new System.EventHandler(this.toolModGrid_MoveDown_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolModGrid_Toggle
            // 
            this.toolModGrid_Toggle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolModGrid_Toggle.Image = ((System.Drawing.Image)(resources.GetObject("toolModGrid_Toggle.Image")));
            this.toolModGrid_Toggle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolModGrid_Toggle.Name = "toolModGrid_Toggle";
            this.toolModGrid_Toggle.Size = new System.Drawing.Size(47, 22);
            this.toolModGrid_Toggle.Text = "Toggle";
            this.toolModGrid_Toggle.Click += new System.EventHandler(this.toolModGrid_Toggle_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.bttnManageResearch);
            this.panelFooter.Controls.Add(this.bttnSaveAndRun);
            this.panelFooter.Controls.Add(this.bttnSaveConfig);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(3, 343);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(720, 40);
            this.panelFooter.TabIndex = 2;
            // 
            // bttnSaveAndRun
            // 
            this.bttnSaveAndRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnSaveAndRun.Location = new System.Drawing.Point(587, 6);
            this.bttnSaveAndRun.Name = "bttnSaveAndRun";
            this.bttnSaveAndRun.Size = new System.Drawing.Size(121, 23);
            this.bttnSaveAndRun.TabIndex = 1;
            this.bttnSaveAndRun.Text = "Save and Run";
            this.bttnSaveAndRun.UseVisualStyleBackColor = true;
            this.bttnSaveAndRun.Click += new System.EventHandler(this.bttnSaveAndRun_Click);
            // 
            // bttnSaveConfig
            // 
            this.bttnSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnSaveConfig.Location = new System.Drawing.Point(477, 6);
            this.bttnSaveConfig.Name = "bttnSaveConfig";
            this.bttnSaveConfig.Size = new System.Drawing.Size(104, 23);
            this.bttnSaveConfig.TabIndex = 0;
            this.bttnSaveConfig.Text = "Save Mod Config";
            this.bttnSaveConfig.UseVisualStyleBackColor = true;
            this.bttnSaveConfig.Click += new System.EventHandler(this.bttnSaveConfig_Click);
            // 
            // lblProfileLabel
            // 
            this.lblProfileLabel.AutoSize = true;
            this.lblProfileLabel.Location = new System.Drawing.Point(12, 3);
            this.lblProfileLabel.Name = "lblProfileLabel";
            this.lblProfileLabel.Size = new System.Drawing.Size(39, 13);
            this.lblProfileLabel.TabIndex = 2;
            this.lblProfileLabel.Text = "Profile:";
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(57, 3);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(95, 13);
            this.lblProfile.TabIndex = 3;
            this.lblProfile.Text = " No Profile Loaded";
            // 
            // splitModGridAndDetails
            // 
            this.splitModGridAndDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitModGridAndDetails.Location = new System.Drawing.Point(3, 28);
            this.splitModGridAndDetails.Name = "splitModGridAndDetails";
            // 
            // splitModGridAndDetails.Panel1
            // 
            this.splitModGridAndDetails.Panel1.Controls.Add(this.dgrvMods);
            // 
            // splitModGridAndDetails.Panel2
            // 
            this.splitModGridAndDetails.Panel2.Controls.Add(this.txbxModDetails);
            this.splitModGridAndDetails.Size = new System.Drawing.Size(720, 315);
            this.splitModGridAndDetails.SplitterDistance = 511;
            this.splitModGridAndDetails.TabIndex = 3;
            // 
            // txbxModDetails
            // 
            this.txbxModDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbxModDetails.Location = new System.Drawing.Point(0, 0);
            this.txbxModDetails.Multiline = true;
            this.txbxModDetails.Name = "txbxModDetails";
            this.txbxModDetails.ReadOnly = true;
            this.txbxModDetails.Size = new System.Drawing.Size(205, 315);
            this.txbxModDetails.TabIndex = 0;
            // 
            // tabcMain
            // 
            this.tabcMain.Controls.Add(this.tabcMain_ProfileSelection);
            this.tabcMain.Controls.Add(this.tabcMain_ModManager);
            this.tabcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcMain.Location = new System.Drawing.Point(0, 0);
            this.tabcMain.Name = "tabcMain";
            this.tabcMain.SelectedIndex = 0;
            this.tabcMain.Size = new System.Drawing.Size(734, 412);
            this.tabcMain.TabIndex = 1;
            // 
            // tabcMain_ProfileSelection
            // 
            this.tabcMain_ProfileSelection.Controls.Add(this.panlProfileSelectionFooter);
            this.tabcMain_ProfileSelection.Controls.Add(this.dgrvSettings);
            this.tabcMain_ProfileSelection.Location = new System.Drawing.Point(4, 22);
            this.tabcMain_ProfileSelection.Name = "tabcMain_ProfileSelection";
            this.tabcMain_ProfileSelection.Padding = new System.Windows.Forms.Padding(3);
            this.tabcMain_ProfileSelection.Size = new System.Drawing.Size(726, 386);
            this.tabcMain_ProfileSelection.TabIndex = 1;
            this.tabcMain_ProfileSelection.Text = "Profile Selection";
            this.tabcMain_ProfileSelection.UseVisualStyleBackColor = true;
            // 
            // panlProfileSelectionFooter
            // 
            this.panlProfileSelectionFooter.AutoScroll = true;
            this.panlProfileSelectionFooter.Controls.Add(this.bttnSaveProfile);
            this.panlProfileSelectionFooter.Controls.Add(this.bttnLoadProfile);
            this.panlProfileSelectionFooter.Controls.Add(this.bttnNew);
            this.panlProfileSelectionFooter.Controls.Add(this.bttnDelete);
            this.panlProfileSelectionFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panlProfileSelectionFooter.Location = new System.Drawing.Point(3, 347);
            this.panlProfileSelectionFooter.Name = "panlProfileSelectionFooter";
            this.panlProfileSelectionFooter.Size = new System.Drawing.Size(720, 36);
            this.panlProfileSelectionFooter.TabIndex = 10;
            // 
            // bttnSaveProfile
            // 
            this.bttnSaveProfile.Location = new System.Drawing.Point(284, 8);
            this.bttnSaveProfile.Name = "bttnSaveProfile";
            this.bttnSaveProfile.Size = new System.Drawing.Size(75, 23);
            this.bttnSaveProfile.TabIndex = 10;
            this.bttnSaveProfile.Text = "Save Profile";
            this.bttnSaveProfile.UseVisualStyleBackColor = true;
            this.bttnSaveProfile.Click += new System.EventHandler(this.bttnSaveProfile_Click);
            // 
            // bttnLoadProfile
            // 
            this.bttnLoadProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnLoadProfile.Location = new System.Drawing.Point(640, 8);
            this.bttnLoadProfile.Name = "bttnLoadProfile";
            this.bttnLoadProfile.Size = new System.Drawing.Size(75, 23);
            this.bttnLoadProfile.TabIndex = 7;
            this.bttnLoadProfile.Text = "Load Profile";
            this.bttnLoadProfile.UseVisualStyleBackColor = true;
            this.bttnLoadProfile.Click += new System.EventHandler(this.bttnLoadProfile_Click);
            // 
            // bttnNew
            // 
            this.bttnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnNew.Location = new System.Drawing.Point(559, 8);
            this.bttnNew.Name = "bttnNew";
            this.bttnNew.Size = new System.Drawing.Size(75, 23);
            this.bttnNew.TabIndex = 8;
            this.bttnNew.Text = "New";
            this.bttnNew.UseVisualStyleBackColor = true;
            this.bttnNew.Click += new System.EventHandler(this.bttnNew_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnDelete.Location = new System.Drawing.Point(5, 8);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(75, 23);
            this.bttnDelete.TabIndex = 9;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // dgrvSettings
            // 
            this.dgrvSettings.AllowUserToAddRows = false;
            this.dgrvSettings.AllowUserToDeleteRows = false;
            this.dgrvSettings.AllowUserToOrderColumns = true;
            this.dgrvSettings.AllowUserToResizeRows = false;
            this.dgrvSettings.AutoGenerateColumns = false;
            this.dgrvSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvSettings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rimworldFolderDataGridViewTextBoxColumn,
            this.ConfigFolderDataGridViewTextBoxColumn,
            this.WorkshopFolder});
            this.dgrvSettings.DataSource = this.bsrcSettings;
            this.dgrvSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrvSettings.Location = new System.Drawing.Point(3, 3);
            this.dgrvSettings.Name = "dgrvSettings";
            this.dgrvSettings.ReadOnly = true;
            this.dgrvSettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrvSettings.Size = new System.Drawing.Size(720, 380);
            this.dgrvSettings.TabIndex = 5;
            // 
            // rimworldFolderDataGridViewTextBoxColumn
            // 
            this.rimworldFolderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rimworldFolderDataGridViewTextBoxColumn.DataPropertyName = "RimworldFolder";
            this.rimworldFolderDataGridViewTextBoxColumn.HeaderText = "RimworldFolder";
            this.rimworldFolderDataGridViewTextBoxColumn.Name = "rimworldFolderDataGridViewTextBoxColumn";
            this.rimworldFolderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ConfigFolderDataGridViewTextBoxColumn
            // 
            this.ConfigFolderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ConfigFolderDataGridViewTextBoxColumn.DataPropertyName = "ConfigFolder";
            this.ConfigFolderDataGridViewTextBoxColumn.HeaderText = "ConfigFolder";
            this.ConfigFolderDataGridViewTextBoxColumn.Name = "ConfigFolderDataGridViewTextBoxColumn";
            this.ConfigFolderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // WorkshopFolder
            // 
            this.WorkshopFolder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WorkshopFolder.DataPropertyName = "WorkshopFolder";
            this.WorkshopFolder.HeaderText = "WorkshopFolder";
            this.WorkshopFolder.Name = "WorkshopFolder";
            this.WorkshopFolder.ReadOnly = true;
            // 
            // bsrcSettings
            // 
            this.bsrcSettings.DataSource = typeof(RimworldModManager.ProgramSettings.Profile);
            // 
            // tabcMain_ModManager
            // 
            this.tabcMain_ModManager.Controls.Add(this.splitModGridAndDetails);
            this.tabcMain_ModManager.Controls.Add(this.toolModGrid);
            this.tabcMain_ModManager.Controls.Add(this.panelFooter);
            this.tabcMain_ModManager.Location = new System.Drawing.Point(4, 22);
            this.tabcMain_ModManager.Name = "tabcMain_ModManager";
            this.tabcMain_ModManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabcMain_ModManager.Size = new System.Drawing.Size(726, 386);
            this.tabcMain_ModManager.TabIndex = 0;
            this.tabcMain_ModManager.Text = "Mod Manager";
            this.tabcMain_ModManager.UseVisualStyleBackColor = true;
            // 
            // panl_MainFooter
            // 
            this.panl_MainFooter.Controls.Add(this.lblProfileLabel);
            this.panl_MainFooter.Controls.Add(this.lblProfile);
            this.panl_MainFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panl_MainFooter.Location = new System.Drawing.Point(0, 412);
            this.panl_MainFooter.Name = "panl_MainFooter";
            this.panl_MainFooter.Size = new System.Drawing.Size(734, 49);
            this.panl_MainFooter.TabIndex = 11;
            // 
            // bttnManageResearch
            // 
            this.bttnManageResearch.Location = new System.Drawing.Point(8, 6);
            this.bttnManageResearch.Name = "bttnManageResearch";
            this.bttnManageResearch.Size = new System.Drawing.Size(110, 23);
            this.bttnManageResearch.TabIndex = 2;
            this.bttnManageResearch.Text = "Manage Research";
            this.bttnManageResearch.UseVisualStyleBackColor = true;
            this.bttnManageResearch.Click += new System.EventHandler(this.bttnManageResearch_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.tabcMain);
            this.Controls.Add(this.panl_MainFooter);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "frmMain";
            this.Text = "Rimworld Mod Orginiser";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvMods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcModDetails)).EndInit();
            this.toolModGrid.ResumeLayout(false);
            this.toolModGrid.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.splitModGridAndDetails.Panel1.ResumeLayout(false);
            this.splitModGridAndDetails.Panel2.ResumeLayout(false);
            this.splitModGridAndDetails.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitModGridAndDetails)).EndInit();
            this.splitModGridAndDetails.ResumeLayout(false);
            this.tabcMain.ResumeLayout(false);
            this.tabcMain_ProfileSelection.ResumeLayout(false);
            this.panlProfileSelectionFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcSettings)).EndInit();
            this.tabcMain_ModManager.ResumeLayout(false);
            this.tabcMain_ModManager.PerformLayout();
            this.panl_MainFooter.ResumeLayout(false);
            this.panl_MainFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrvMods;
        private System.Windows.Forms.BindingSource bsrcModDetails;
        private System.Windows.Forms.ToolStrip toolModGrid;
        private System.Windows.Forms.ToolStripButton toolModGrid_MoveUp;
        private System.Windows.Forms.ToolStripButton toolModGrid_MoveDown;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button bttnSaveConfig;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolModGrid_Toggle;
        private System.Windows.Forms.SplitContainer splitModGridAndDetails;
        private System.Windows.Forms.TextBox txbxModDetails;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label lblProfileLabel;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Button bttnSaveAndRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrvMods_SequenceDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrvMods_DiskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrvMods_XMLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrvMods_Issues;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrvMods_Author;
        private System.Windows.Forms.TabControl tabcMain;
        private System.Windows.Forms.TabPage tabcMain_ProfileSelection;
        private System.Windows.Forms.TabPage tabcMain_ModManager;
        private System.Windows.Forms.DataGridView dgrvSettings;
        private System.Windows.Forms.BindingSource bsrcSettings;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnNew;
        private System.Windows.Forms.Button bttnLoadProfile;
        private System.Windows.Forms.Panel panlProfileSelectionFooter;
        private System.Windows.Forms.Panel panl_MainFooter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rimworldFolderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfigFolderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkshopFolder;
        private System.Windows.Forms.Button bttnSaveProfile;
        private System.Windows.Forms.Button bttnManageResearch;
    }
}

