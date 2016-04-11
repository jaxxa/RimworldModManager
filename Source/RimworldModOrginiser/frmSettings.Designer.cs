namespace RimworldModOrginiser
{
    partial class frmSettings
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
            this.dgrvSettings = new System.Windows.Forms.DataGridView();
            this.bsrcSettings = new System.Windows.Forms.BindingSource(this.components);
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnOk = new System.Windows.Forms.Button();
            this.bttnNew = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.rimworldFolderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfigFolderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrvSettings
            // 
            this.dgrvSettings.AllowUserToAddRows = false;
            this.dgrvSettings.AllowUserToDeleteRows = false;
            this.dgrvSettings.AllowUserToOrderColumns = true;
            this.dgrvSettings.AllowUserToResizeRows = false;
            this.dgrvSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrvSettings.AutoGenerateColumns = false;
            this.dgrvSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvSettings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rimworldFolderDataGridViewTextBoxColumn,
            this.ConfigFolderDataGridViewTextBoxColumn});
            this.dgrvSettings.DataSource = this.bsrcSettings;
            this.dgrvSettings.Location = new System.Drawing.Point(12, 12);
            this.dgrvSettings.Name = "dgrvSettings";
            this.dgrvSettings.ReadOnly = true;
            this.dgrvSettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrvSettings.Size = new System.Drawing.Size(560, 358);
            this.dgrvSettings.TabIndex = 0;
            this.dgrvSettings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvSettings_CellContentClick);
            // 
            // bsrcSettings
            // 
            this.bsrcSettings.DataSource = typeof(RimworldModOrginiser.ProgramSettings.Profile);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnCancel.Location = new System.Drawing.Point(13, 376);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(75, 23);
            this.bttnCancel.TabIndex = 1;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // bttnOk
            // 
            this.bttnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnOk.Location = new System.Drawing.Point(497, 376);
            this.bttnOk.Name = "bttnOk";
            this.bttnOk.Size = new System.Drawing.Size(75, 23);
            this.bttnOk.TabIndex = 2;
            this.bttnOk.Text = "Ok";
            this.bttnOk.UseVisualStyleBackColor = true;
            this.bttnOk.Click += new System.EventHandler(this.bttnOk_Click);
            // 
            // bttnNew
            // 
            this.bttnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnNew.Location = new System.Drawing.Point(416, 376);
            this.bttnNew.Name = "bttnNew";
            this.bttnNew.Size = new System.Drawing.Size(75, 23);
            this.bttnNew.TabIndex = 3;
            this.bttnNew.Text = "New";
            this.bttnNew.UseVisualStyleBackColor = true;
            this.bttnNew.Click += new System.EventHandler(this.bttnNew_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnDelete.Location = new System.Drawing.Point(94, 376);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(75, 23);
            this.bttnDelete.TabIndex = 4;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
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
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnNew);
            this.Controls.Add(this.bttnOk);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.dgrvSettings);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrvSettings;
        private System.Windows.Forms.BindingSource bsrcSettings;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnOk;
        private System.Windows.Forms.Button bttnNew;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn rimworldFolderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfigFolderDataGridViewTextBoxColumn;
    }
}