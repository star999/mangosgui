namespace MaNGOS_GUI
{
    partial class deleteAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteAccount));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textAccountName = new System.Windows.Forms.TextBox();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.buttonDelete, "buttonDelete");
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textAccountName
            // 
            resources.ApplyResources(this.textAccountName, "textAccountName");
            this.textAccountName.Name = "textAccountName";
            this.textAccountName.TextChanged += new System.EventHandler(this.textAccountName_TextChanged);
            // 
            // labelAccountName
            // 
            resources.ApplyResources(this.labelAccountName, "labelAccountName");
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Click += new System.EventHandler(this.labelAccountName_Click);
            // 
            // deleteAccount
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textAccountName);
            this.Controls.Add(this.labelAccountName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "deleteAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textAccountName;
        private System.Windows.Forms.Label labelAccountName;
    }
}