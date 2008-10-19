namespace MaNGOS_GUI
{
    partial class loadDump
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadDump));
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textAccountName = new System.Windows.Forms.TextBox();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.AccessibleDescription = null;
            this.buttonLoad.AccessibleName = null;
            resources.ApplyResources(this.buttonLoad, "buttonLoad");
            this.buttonLoad.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonLoad.BackgroundImage = null;
            this.buttonLoad.Font = null;
            this.buttonLoad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textAccountName
            // 
            this.textAccountName.AccessibleDescription = null;
            this.textAccountName.AccessibleName = null;
            resources.ApplyResources(this.textAccountName, "textAccountName");
            this.textAccountName.BackgroundImage = null;
            this.textAccountName.Font = null;
            this.textAccountName.Name = "textAccountName";
            // 
            // labelAccountName
            // 
            this.labelAccountName.AccessibleDescription = null;
            this.labelAccountName.AccessibleName = null;
            resources.ApplyResources(this.labelAccountName, "labelAccountName");
            this.labelAccountName.Font = null;
            this.labelAccountName.Name = "labelAccountName";
            // 
            // textFileName
            // 
            this.textFileName.AccessibleDescription = null;
            this.textFileName.AccessibleName = null;
            resources.ApplyResources(this.textFileName, "textFileName");
            this.textFileName.BackgroundImage = null;
            this.textFileName.Font = null;
            this.textFileName.Name = "textFileName";
            // 
            // labelFileName
            // 
            this.labelFileName.AccessibleDescription = null;
            this.labelFileName.AccessibleName = null;
            resources.ApplyResources(this.labelFileName, "labelFileName");
            this.labelFileName.Font = null;
            this.labelFileName.Name = "labelFileName";
            // 
            // loadDump
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textAccountName);
            this.Controls.Add(this.labelAccountName);
            this.Controls.Add(this.textFileName);
            this.Controls.Add(this.labelFileName);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = null;
            this.Name = "loadDump";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textAccountName;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.Label labelFileName;
    }
}