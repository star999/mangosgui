namespace MaNGOS_GUI
{
    partial class setPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setPassword));
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.textValidatePassword = new System.Windows.Forms.TextBox();
            this.labelValidatePassword = new System.Windows.Forms.Label();
            this.accountComboBox1 = new MaNGOS_GUI.Controls.AccountComboBox();
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
            // textPassword
            // 
            this.textPassword.AccessibleDescription = null;
            this.textPassword.AccessibleName = null;
            resources.ApplyResources(this.textPassword, "textPassword");
            this.textPassword.BackgroundImage = null;
            this.textPassword.Font = null;
            this.textPassword.Name = "textPassword";
            // 
            // labelPassword
            // 
            this.labelPassword.AccessibleDescription = null;
            this.labelPassword.AccessibleName = null;
            resources.ApplyResources(this.labelPassword, "labelPassword");
            this.labelPassword.Font = null;
            this.labelPassword.Name = "labelPassword";
            // 
            // labelAccountName
            // 
            this.labelAccountName.AccessibleDescription = null;
            this.labelAccountName.AccessibleName = null;
            resources.ApplyResources(this.labelAccountName, "labelAccountName");
            this.labelAccountName.Font = null;
            this.labelAccountName.Name = "labelAccountName";
            // 
            // textValidatePassword
            // 
            this.textValidatePassword.AccessibleDescription = null;
            this.textValidatePassword.AccessibleName = null;
            resources.ApplyResources(this.textValidatePassword, "textValidatePassword");
            this.textValidatePassword.BackgroundImage = null;
            this.textValidatePassword.Font = null;
            this.textValidatePassword.Name = "textValidatePassword";
            // 
            // labelValidatePassword
            // 
            this.labelValidatePassword.AccessibleDescription = null;
            this.labelValidatePassword.AccessibleName = null;
            resources.ApplyResources(this.labelValidatePassword, "labelValidatePassword");
            this.labelValidatePassword.Font = null;
            this.labelValidatePassword.Name = "labelValidatePassword";
            // 
            // accountComboBox1
            // 
            this.accountComboBox1.AccessibleDescription = null;
            this.accountComboBox1.AccessibleName = null;
            resources.ApplyResources(this.accountComboBox1, "accountComboBox1");
            this.accountComboBox1.BackgroundImage = null;
            this.accountComboBox1.DataSource = ((object)(resources.GetObject("accountComboBox1.DataSource")));
            this.accountComboBox1.Font = null;
            this.accountComboBox1.FormattingEnabled = true;
            this.accountComboBox1.Name = "accountComboBox1";
            // 
            // setPassword
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.accountComboBox1);
            this.Controls.Add(this.textValidatePassword);
            this.Controls.Add(this.labelValidatePassword);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelAccountName);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = null;
            this.Name = "setPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.TextBox textValidatePassword;
        private System.Windows.Forms.Label labelValidatePassword;
        private MaNGOS_GUI.Controls.AccountComboBox accountComboBox1;
    }
}