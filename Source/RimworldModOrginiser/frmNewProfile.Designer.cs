namespace RimworldModOrginiser
{
    partial class frmNewProfile
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
            this.txbxRimworldFolder = new System.Windows.Forms.TextBox();
            this.txbxSaveFolder = new System.Windows.Forms.TextBox();
            this.bttnOk = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.lblSaveFolder = new System.Windows.Forms.Label();
            this.lblRimworldFolder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnChooseRimworldFolder = new System.Windows.Forms.Button();
            this.bttnChooseSaveFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbxRimworldFolder
            // 
            this.txbxRimworldFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxRimworldFolder.Location = new System.Drawing.Point(100, 48);
            this.txbxRimworldFolder.Name = "txbxRimworldFolder";
            this.txbxRimworldFolder.Size = new System.Drawing.Size(235, 20);
            this.txbxRimworldFolder.TabIndex = 0;
            // 
            // txbxSaveFolder
            // 
            this.txbxSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxSaveFolder.Location = new System.Drawing.Point(100, 94);
            this.txbxSaveFolder.Name = "txbxSaveFolder";
            this.txbxSaveFolder.Size = new System.Drawing.Size(235, 20);
            this.txbxSaveFolder.TabIndex = 1;
            // 
            // bttnOk
            // 
            this.bttnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnOk.Location = new System.Drawing.Point(297, 226);
            this.bttnOk.Name = "bttnOk";
            this.bttnOk.Size = new System.Drawing.Size(75, 23);
            this.bttnOk.TabIndex = 2;
            this.bttnOk.Text = "Ok";
            this.bttnOk.UseVisualStyleBackColor = true;
            this.bttnOk.Click += new System.EventHandler(this.bttnOk_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnCancel.Location = new System.Drawing.Point(12, 226);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(75, 23);
            this.bttnCancel.TabIndex = 3;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // lblSaveFolder
            // 
            this.lblSaveFolder.AutoSize = true;
            this.lblSaveFolder.Location = new System.Drawing.Point(12, 97);
            this.lblSaveFolder.Name = "lblSaveFolder";
            this.lblSaveFolder.Size = new System.Drawing.Size(64, 13);
            this.lblSaveFolder.TabIndex = 4;
            this.lblSaveFolder.Text = "SaveFolder:";
            // 
            // lblRimworldFolder
            // 
            this.lblRimworldFolder.AutoSize = true;
            this.lblRimworldFolder.Location = new System.Drawing.Point(12, 51);
            this.lblRimworldFolder.Name = "lblRimworldFolder";
            this.lblRimworldFolder.Size = new System.Drawing.Size(82, 13);
            this.lblRimworldFolder.TabIndex = 5;
            this.lblRimworldFolder.Text = "RimworldFolder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please createa new profile:";
            // 
            // bttnChooseRimworldFolder
            // 
            this.bttnChooseRimworldFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnChooseRimworldFolder.Location = new System.Drawing.Point(341, 45);
            this.bttnChooseRimworldFolder.Name = "bttnChooseRimworldFolder";
            this.bttnChooseRimworldFolder.Size = new System.Drawing.Size(33, 23);
            this.bttnChooseRimworldFolder.TabIndex = 7;
            this.bttnChooseRimworldFolder.Text = "...";
            this.bttnChooseRimworldFolder.UseVisualStyleBackColor = true;
            this.bttnChooseRimworldFolder.Click += new System.EventHandler(this.bttnChooseRimworldFolder_Click);
            // 
            // bttnChooseSaveFolder
            // 
            this.bttnChooseSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnChooseSaveFolder.Location = new System.Drawing.Point(341, 92);
            this.bttnChooseSaveFolder.Name = "bttnChooseSaveFolder";
            this.bttnChooseSaveFolder.Size = new System.Drawing.Size(33, 23);
            this.bttnChooseSaveFolder.TabIndex = 8;
            this.bttnChooseSaveFolder.Text = "...";
            this.bttnChooseSaveFolder.UseVisualStyleBackColor = true;
            this.bttnChooseSaveFolder.Click += new System.EventHandler(this.bttnChooseSaveFolder_Click);
            // 
            // frmNewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.bttnChooseSaveFolder);
            this.Controls.Add(this.bttnChooseRimworldFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRimworldFolder);
            this.Controls.Add(this.lblSaveFolder);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnOk);
            this.Controls.Add(this.txbxSaveFolder);
            this.Controls.Add(this.txbxRimworldFolder);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "frmNewProfile";
            this.Text = "NewProfile";
            this.Load += new System.EventHandler(this.frmNewProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbxRimworldFolder;
        private System.Windows.Forms.TextBox txbxSaveFolder;
        private System.Windows.Forms.Button bttnOk;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Label lblSaveFolder;
        private System.Windows.Forms.Label lblRimworldFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnChooseRimworldFolder;
        private System.Windows.Forms.Button bttnChooseSaveFolder;
    }
}