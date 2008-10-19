namespace MaNGOS_GUI
{
    partial class playerLimit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerLimit));
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textPlayerLimit = new System.Windows.Forms.TextBox();
            this.labelPlayerLimit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AccessibleDescription = null;
            this.buttonUpdate.AccessibleName = null;
            resources.ApplyResources(this.buttonUpdate, "buttonUpdate");
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonUpdate.BackgroundImage = null;
            this.buttonUpdate.Font = null;
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textPlayerLimit
            // 
            this.textPlayerLimit.AccessibleDescription = null;
            this.textPlayerLimit.AccessibleName = null;
            resources.ApplyResources(this.textPlayerLimit, "textPlayerLimit");
            this.textPlayerLimit.BackgroundImage = null;
            this.textPlayerLimit.Font = null;
            this.textPlayerLimit.Name = "textPlayerLimit";
            // 
            // labelPlayerLimit
            // 
            this.labelPlayerLimit.AccessibleDescription = null;
            this.labelPlayerLimit.AccessibleName = null;
            resources.ApplyResources(this.labelPlayerLimit, "labelPlayerLimit");
            this.labelPlayerLimit.Font = null;
            this.labelPlayerLimit.Name = "labelPlayerLimit";
            // 
            // playerLimit
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textPlayerLimit);
            this.Controls.Add(this.labelPlayerLimit);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = null;
            this.Name = "playerLimit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textPlayerLimit;
        private System.Windows.Forms.Label labelPlayerLimit;
    }
}