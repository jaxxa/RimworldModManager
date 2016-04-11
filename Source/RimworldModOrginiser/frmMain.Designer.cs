namespace RimworldModOrginiser
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
            this.Issues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolModGrid = new System.Windows.Forms.ToolStrip();
            this.toolModGrid_MoveUp = new System.Windows.Forms.ToolStripButton();
            this.toolModGrid_MoveDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolModGrid_Toggle = new System.Windows.Forms.ToolStripButton();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.bttnSaveAndRun = new System.Windows.Forms.Button();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblProfileLabel = new System.Windows.Forms.Label();
            this.bttnLoad = new System.Windows.Forms.Button();
            this.bttnSaveConfig = new System.Windows.Forms.Button();
            this.splitModGridAndDetails = new System.Windows.Forms.SplitContainer();
            this.txbxModDetails = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.dgrvMods_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrvMods_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrvMods_Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrvMods_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsrcModDetails = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvMods)).BeginInit();
            this.toolModGrid.SuspendLayout();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitModGridAndDetails)).BeginInit();
            this.splitModGridAndDetails.Panel1.SuspendLayout();
            this.splitModGridAndDetails.Panel2.SuspendLayout();
            this.splitModGridAndDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcModDetails)).BeginInit();
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
            this.dgrvMods_Name,
            this.Issues,
            this.dgrvMods_Author,
            this.dgrvMods_Url,
            this.dgrvMods_Description});
            this.dgrvMods.DataSource = this.bsrcModDetails;
            this.dgrvMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrvMods.Location = new System.Drawing.Point(0, 0);
            this.dgrvMods.Name = "dgrvMods";
            this.dgrvMods.ReadOnly = true;
            this.dgrvMods.Size = new System.Drawing.Size(521, 396);
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
            // Issues
            // 
            this.Issues.DataPropertyName = "Issues";
            this.Issues.HeaderText = "Issues";
            this.Issues.Name = "Issues";
            this.Issues.ReadOnly = true;
            // 
            // toolModGrid
            // 
            this.toolModGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolModGrid_MoveUp,
            this.toolModGrid_MoveDown,
            this.toolStripSeparator1,
            this.toolModGrid_Toggle});
            this.toolModGrid.Location = new System.Drawing.Point(0, 0);
            this.toolModGrid.Name = "toolModGrid";
            this.toolModGrid.Size = new System.Drawing.Size(734, 25);
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
            this.panelFooter.Controls.Add(this.bttnSaveAndRun);
            this.panelFooter.Controls.Add(this.lblProfileLabel);
            this.panelFooter.Controls.Add(this.bttnLoad);
            this.panelFooter.Controls.Add(this.bttnSaveConfig);
            this.panelFooter.Controls.Add(this.lblProfile);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 421);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(734, 40);
            this.panelFooter.TabIndex = 2;
            // 
            // bttnSaveAndRun
            // 
            this.bttnSaveAndRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnSaveAndRun.Location = new System.Drawing.Point(601, 6);
            this.bttnSaveAndRun.Name = "bttnSaveAndRun";
            this.bttnSaveAndRun.Size = new System.Drawing.Size(121, 23);
            this.bttnSaveAndRun.TabIndex = 1;
            this.bttnSaveAndRun.Text = "Save and Run";
            this.bttnSaveAndRun.UseVisualStyleBackColor = true;
            this.bttnSaveAndRun.Click += new System.EventHandler(this.bttnSaveAndRun_Click);
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(155, 3);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(95, 13);
            this.lblProfile.TabIndex = 3;
            this.lblProfile.Text = " No Profile Loaded";
            // 
            // lblProfileLabel
            // 
            this.lblProfileLabel.AutoSize = true;
            this.lblProfileLabel.Location = new System.Drawing.Point(110, 15);
            this.lblProfileLabel.Name = "lblProfileLabel";
            this.lblProfileLabel.Size = new System.Drawing.Size(39, 13);
            this.lblProfileLabel.TabIndex = 2;
            this.lblProfileLabel.Text = "Profile:";
            // 
            // bttnLoad
            // 
            this.bttnLoad.Location = new System.Drawing.Point(12, 6);
            this.bttnLoad.Name = "bttnLoad";
            this.bttnLoad.Size = new System.Drawing.Size(75, 23);
            this.bttnLoad.TabIndex = 1;
            this.bttnLoad.Text = "Load";
            this.bttnLoad.UseVisualStyleBackColor = true;
            this.bttnLoad.Click += new System.EventHandler(this.bttnLoad_Click);
            // 
            // bttnSaveConfig
            // 
            this.bttnSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnSaveConfig.Location = new System.Drawing.Point(491, 6);
            this.bttnSaveConfig.Name = "bttnSaveConfig";
            this.bttnSaveConfig.Size = new System.Drawing.Size(104, 23);
            this.bttnSaveConfig.TabIndex = 0;
            this.bttnSaveConfig.Text = "Save Mod Config";
            this.bttnSaveConfig.UseVisualStyleBackColor = true;
            this.bttnSaveConfig.Click += new System.EventHandler(this.bttnSaveConfig_Click);
            // 
            // splitModGridAndDetails
            // 
            this.splitModGridAndDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitModGridAndDetails.Location = new System.Drawing.Point(0, 25);
            this.splitModGridAndDetails.Name = "splitModGridAndDetails";
            // 
            // splitModGridAndDetails.Panel1
            // 
            this.splitModGridAndDetails.Panel1.Controls.Add(this.dgrvMods);
            // 
            // splitModGridAndDetails.Panel2
            // 
            this.splitModGridAndDetails.Panel2.Controls.Add(this.txbxModDetails);
            this.splitModGridAndDetails.Size = new System.Drawing.Size(734, 396);
            this.splitModGridAndDetails.SplitterDistance = 521;
            this.splitModGridAndDetails.TabIndex = 3;
            // 
            // txbxModDetails
            // 
            this.txbxModDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbxModDetails.Location = new System.Drawing.Point(0, 0);
            this.txbxModDetails.Multiline = true;
            this.txbxModDetails.Name = "txbxModDetails";
            this.txbxModDetails.ReadOnly = true;
            this.txbxModDetails.Size = new System.Drawing.Size(209, 396);
            this.txbxModDetails.TabIndex = 0;
            // 
            // dgrvMods_Name
            // 
            this.dgrvMods_Name.DataPropertyName = "Name";
            this.dgrvMods_Name.HeaderText = "Name";
            this.dgrvMods_Name.Name = "dgrvMods_Name";
            this.dgrvMods_Name.ReadOnly = true;
            // 
            // dgrvMods_Author
            // 
            this.dgrvMods_Author.DataPropertyName = "Author";
            this.dgrvMods_Author.HeaderText = "Author";
            this.dgrvMods_Author.Name = "dgrvMods_Author";
            this.dgrvMods_Author.ReadOnly = true;
            // 
            // dgrvMods_Url
            // 
            this.dgrvMods_Url.DataPropertyName = "Url";
            this.dgrvMods_Url.HeaderText = "Url";
            this.dgrvMods_Url.Name = "dgrvMods_Url";
            this.dgrvMods_Url.ReadOnly = true;
            // 
            // dgrvMods_Description
            // 
            this.dgrvMods_Description.DataPropertyName = "Description";
            this.dgrvMods_Description.HeaderText = "Description";
            this.dgrvMods_Description.Name = "dgrvMods_Description";
            this.dgrvMods_Description.ReadOnly = true;
            // 
            // bsrcModDetails
            // 
            this.bsrcModDetails.DataSource = typeof(RimworldModOrginiser.DataObjects.ModDetails);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.splitModGridAndDetails);
            this.Controls.Add(this.toolModGrid);
            this.Controls.Add(this.panelFooter);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "frmMain";
            this.Text = "Rimworld Mod Orginiser";
            ((System.ComponentModel.ISupportInitialize)(this.dgrvMods)).EndInit();
            this.toolModGrid.ResumeLayout(false);
            this.toolModGrid.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.splitModGridAndDetails.Panel1.ResumeLayout(false);
            this.splitModGridAndDetails.Panel2.ResumeLayout(false);
            this.splitModGridAndDetails.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitModGridAndDetails)).EndInit();
            this.splitModGridAndDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsrcModDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrvMods;
        private System.Windows.Forms.BindingSource bsrcModDetails;
        private System.Windows.Forms.ToolStrip toolModGrid;
        private System.Windows.Forms.ToolStripButton toolModGrid_MoveUp;
        private System.Windows.Forms.ToolStripButton toolModGrid_MoveDown;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button bttnSaveConfig;
        private System.Windows.Forms.Button bttnLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolModGrid_Toggle;
        private System.Windows.Forms.SplitContainer splitModGridAndDetails;
        private System.Windows.Forms.TextBox txbxModDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrvMods_SequenceDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrvMods_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Issues;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrvMods_Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrvMods_Url;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrvMods_Description;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label lblProfileLabel;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Button bttnSaveAndRun;
    }
}

