namespace RimworldModManager.Forms.Research
{
    partial class frmResearch
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
            this.bttnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnLoad
            // 
            this.bttnLoad.Location = new System.Drawing.Point(12, 12);
            this.bttnLoad.Name = "bttnLoad";
            this.bttnLoad.Size = new System.Drawing.Size(93, 23);
            this.bttnLoad.TabIndex = 0;
            this.bttnLoad.Text = "Load Research";
            this.bttnLoad.UseVisualStyleBackColor = true;
            this.bttnLoad.Click += new System.EventHandler(this.bttnLoad_Click);
            // 
            // frmResearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 414);
            this.Controls.Add(this.bttnLoad);
            this.Name = "frmResearch";
            this.Text = "frmResearch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnLoad;
    }
}