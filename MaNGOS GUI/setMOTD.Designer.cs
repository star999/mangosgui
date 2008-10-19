namespace MaNGOS_GUI
{
    partial class setMOTD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setMOTD));
            this.labelSetMOTD = new System.Windows.Forms.Label();
            this.buttonSetMOTD = new System.Windows.Forms.Button();
            this.textSetMOTD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelSetMOTD
            // 
            this.labelSetMOTD.AccessibleDescription = null;
            this.labelSetMOTD.AccessibleName = null;
            resources.ApplyResources(this.labelSetMOTD, "labelSetMOTD");
            this.labelSetMOTD.Font = null;
            this.labelSetMOTD.Name = "labelSetMOTD";
            // 
            // buttonSetMOTD
            // 
            this.buttonSetMOTD.AccessibleDescription = null;
            this.buttonSetMOTD.AccessibleName = null;
            resources.ApplyResources(this.buttonSetMOTD, "buttonSetMOTD");
            this.buttonSetMOTD.BackgroundImage = null;
            this.buttonSetMOTD.Font = null;
            this.buttonSetMOTD.Name = "buttonSetMOTD";
            this.buttonSetMOTD.UseVisualStyleBackColor = true;
            this.buttonSetMOTD.Click += new System.EventHandler(this.buttonSetMOTD_Click);
            // 
            // textSetMOTD
            // 
            this.textSetMOTD.AccessibleDescription = null;
            this.textSetMOTD.AccessibleName = null;
            resources.ApplyResources(this.textSetMOTD, "textSetMOTD");
            this.textSetMOTD.BackgroundImage = null;
            this.textSetMOTD.Font = null;
            this.textSetMOTD.Name = "textSetMOTD";
            // 
            // setMOTD
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.labelSetMOTD);
            this.Controls.Add(this.buttonSetMOTD);
            this.Controls.Add(this.textSetMOTD);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = null;
            this.Name = "setMOTD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSetMOTD;
        private System.Windows.Forms.Button buttonSetMOTD;
        private System.Windows.Forms.TextBox textSetMOTD;
    }
}