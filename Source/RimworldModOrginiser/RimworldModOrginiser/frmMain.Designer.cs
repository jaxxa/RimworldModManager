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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolModGrid = new System.Windows.Forms.ToolStrip();
            this.toolModGrid_MoveUp = new System.Windows.Forms.ToolStripButton();
            this.toolModGrid_MoveDown = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnSaveConfig = new System.Windows.Forms.Button();
            this.bttnLoad = new System.Windows.Forms.Button();
            this.Sequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExistsInConfig = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ExistsInDisk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolModGrid_Toggle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsrcModDetails = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolModGrid.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcModDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sequence,
            this.nameDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.ExistsInConfig,
            this.ExistsInDisk});
            this.dataGridView1.DataSource = this.bsrcModDetails;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(735, 410);
            this.dataGridView1.TabIndex = 0;
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
            this.toolModGrid.Size = new System.Drawing.Size(735, 25);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.bttnLoad);
            this.panel1.Controls.Add(this.bttnSaveConfig);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 40);
            this.panel1.TabIndex = 2;
            // 
            // bttnSaveConfig
            // 
            this.bttnSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnSaveConfig.Location = new System.Drawing.Point(648, 6);
            this.bttnSaveConfig.Name = "bttnSaveConfig";
            this.bttnSaveConfig.Size = new System.Drawing.Size(75, 23);
            this.bttnSaveConfig.TabIndex = 0;
            this.bttnSaveConfig.Text = "Save Config";
            this.bttnSaveConfig.UseVisualStyleBackColor = true;
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
            // Sequence
            // 
            this.Sequence.DataPropertyName = "Sequence";
            this.Sequence.HeaderText = "Sequence";
            this.Sequence.Name = "Sequence";
            this.Sequence.ReadOnly = true;
            this.Sequence.Width = 75;
            // 
            // ExistsInConfig
            // 
            this.ExistsInConfig.DataPropertyName = "ExistsInConfig";
            this.ExistsInConfig.HeaderText = "ExistsInConfig";
            this.ExistsInConfig.Name = "ExistsInConfig";
            this.ExistsInConfig.ReadOnly = true;
            // 
            // ExistsInDisk
            // 
            this.ExistsInDisk.DataPropertyName = "ExistsInDisk";
            this.ExistsInDisk.HeaderText = "ExistsInDisk";
            this.ExistsInDisk.Name = "ExistsInDisk";
            this.ExistsInDisk.ReadOnly = true;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsrcModDetails
            // 
            this.bsrcModDetails.DataSource = typeof(RimworldModOrginiser.DataObjects.ModDetails);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 475);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolModGrid);
            this.Name = "frmMain";
            this.Text = "Rimworld Mod Orginiser";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolModGrid.ResumeLayout(false);
            this.toolModGrid.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsrcModDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsrcModDetails;
        private System.Windows.Forms.ToolStrip toolModGrid;
        private System.Windows.Forms.ToolStripButton toolModGrid_MoveUp;
        private System.Windows.Forms.ToolStripButton toolModGrid_MoveDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttnSaveConfig;
        private System.Windows.Forms.Button bttnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExistsInConfig;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExistsInDisk;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolModGrid_Toggle;
    }
}

