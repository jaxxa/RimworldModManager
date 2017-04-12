namespace RimworldModManager
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
            this.txbxConfigFolder = new System.Windows.Forms.TextBox();
            this.bttnOk = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.lblSaveFolder = new System.Windows.Forms.Label();
            this.lblRimworldFolder = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.bttnChooseRimworldFolder = new System.Windows.Forms.Button();
            this.bttnChooseConfigFolder = new System.Windows.Forms.Button();
            this.txbxWorkshopFolder = new System.Windows.Forms.TextBox();
            this.bttnChooseWorkshopFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbxRimworldFolder
            // 
            this.txbxRimworldFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxRimworldFolder.Location = new System.Drawing.Point(102, 42);
            this.txbxRimworldFolder.Name = "txbxRimworldFolder";
            this.txbxRimworldFolder.Size = new System.Drawing.Size(240, 20);
            this.txbxRimworldFolder.TabIndex = 0;
            // 
            // txbxConfigFolder
            // 
            this.txbxConfigFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxConfigFolder.Location = new System.Drawing.Point(102, 71);
            this.txbxConfigFolder.Name = "txbxConfigFolder";
            this.txbxConfigFolder.Size = new System.Drawing.Size(240, 20);
            this.txbxConfigFolder.TabIndex = 1;
            // 
            // bttnOk
            // 
            this.bttnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.bttnOk, 2);
            this.bttnOk.Location = new System.Drawing.Point(306, 135);
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
            this.bttnCancel.Location = new System.Drawing.Point(3, 135);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(75, 23);
            this.bttnCancel.TabIndex = 3;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // lblSaveFolder
            // 
            this.lblSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaveFolder.AutoSize = true;
            this.lblSaveFolder.Location = new System.Drawing.Point(3, 75);
            this.lblSaveFolder.Name = "lblSaveFolder";
            this.lblSaveFolder.Size = new System.Drawing.Size(93, 13);
            this.lblSaveFolder.TabIndex = 4;
            this.lblSaveFolder.Text = "ConfigFolder:";
            // 
            // lblRimworldFolder
            // 
            this.lblRimworldFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRimworldFolder.AutoSize = true;
            this.lblRimworldFolder.Location = new System.Drawing.Point(3, 46);
            this.lblRimworldFolder.Name = "lblRimworldFolder";
            this.lblRimworldFolder.Size = new System.Drawing.Size(93, 13);
            this.lblRimworldFolder.TabIndex = 5;
            this.lblRimworldFolder.Text = "RimworldFolder:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblInstructions, 2);
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(3, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(185, 18);
            this.lblInstructions.TabIndex = 6;
            this.lblInstructions.Text = "Please createa new profile:";
            // 
            // bttnChooseRimworldFolder
            // 
            this.bttnChooseRimworldFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnChooseRimworldFolder.Location = new System.Drawing.Point(348, 41);
            this.bttnChooseRimworldFolder.Name = "bttnChooseRimworldFolder";
            this.bttnChooseRimworldFolder.Size = new System.Drawing.Size(33, 23);
            this.bttnChooseRimworldFolder.TabIndex = 7;
            this.bttnChooseRimworldFolder.Text = "...";
            this.bttnChooseRimworldFolder.UseVisualStyleBackColor = true;
            this.bttnChooseRimworldFolder.Click += new System.EventHandler(this.bttnChooseRimworldFolder_Click);
            // 
            // bttnChooseConfigFolder
            // 
            this.bttnChooseConfigFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnChooseConfigFolder.Location = new System.Drawing.Point(348, 70);
            this.bttnChooseConfigFolder.Name = "bttnChooseConfigFolder";
            this.bttnChooseConfigFolder.Size = new System.Drawing.Size(33, 23);
            this.bttnChooseConfigFolder.TabIndex = 8;
            this.bttnChooseConfigFolder.Text = "...";
            this.bttnChooseConfigFolder.UseVisualStyleBackColor = true;
            this.bttnChooseConfigFolder.Click += new System.EventHandler(this.bttnChooseSaveFolder_Click);
            // 
            // txbxWorkshopFolder
            // 
            this.txbxWorkshopFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxWorkshopFolder.Location = new System.Drawing.Point(102, 100);
            this.txbxWorkshopFolder.Name = "txbxWorkshopFolder";
            this.txbxWorkshopFolder.Size = new System.Drawing.Size(240, 20);
            this.txbxWorkshopFolder.TabIndex = 9;
            // 
            // bttnChooseWorkshopFolder
            // 
            this.bttnChooseWorkshopFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnChooseWorkshopFolder.Location = new System.Drawing.Point(348, 99);
            this.bttnChooseWorkshopFolder.Name = "bttnChooseWorkshopFolder";
            this.bttnChooseWorkshopFolder.Size = new System.Drawing.Size(33, 23);
            this.bttnChooseWorkshopFolder.TabIndex = 10;
            this.bttnChooseWorkshopFolder.Text = "...";
            this.bttnChooseWorkshopFolder.UseVisualStyleBackColor = true;
            this.bttnChooseWorkshopFolder.Click += new System.EventHandler(this.bttnChooseWorkshopFolder_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "WorkShop Folder:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblRimworldFolder, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bttnChooseWorkshopFolder, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txbxWorkshopFolder, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txbxRimworldFolder, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblInstructions, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bttnOk, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.bttnCancel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.bttnChooseConfigFolder, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSaveFolder, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txbxConfigFolder, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bttnChooseRimworldFolder, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 161);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // frmNewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "frmNewProfile";
            this.Text = "NewProfile";
            this.Load += new System.EventHandler(this.frmNewProfile_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbxRimworldFolder;
        private System.Windows.Forms.TextBox txbxConfigFolder;
        private System.Windows.Forms.Button bttnOk;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Label lblSaveFolder;
        private System.Windows.Forms.Label lblRimworldFolder;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button bttnChooseRimworldFolder;
        private System.Windows.Forms.Button bttnChooseConfigFolder;
        private System.Windows.Forms.TextBox txbxWorkshopFolder;
        private System.Windows.Forms.Button bttnChooseWorkshopFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}