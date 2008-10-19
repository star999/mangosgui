namespace MaNGOS_GUI
{
    partial class setBC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setBC));
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelBC = new System.Windows.Forms.Label();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.comboBC = new System.Windows.Forms.ComboBox();
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
            // labelBC
            // 
            this.labelBC.AccessibleDescription = null;
            this.labelBC.AccessibleName = null;
            resources.ApplyResources(this.labelBC, "labelBC");
            this.labelBC.Font = null;
            this.labelBC.Name = "labelBC";
            // 
            // labelAccountName
            // 
            this.labelAccountName.AccessibleDescription = null;
            this.labelAccountName.AccessibleName = null;
            resources.ApplyResources(this.labelAccountName, "labelAccountName");
            this.labelAccountName.Font = null;
            this.labelAccountName.Name = "labelAccountName";
            // 
            // comboBC
            // 
            this.comboBC.AccessibleDescription = null;
            this.comboBC.AccessibleName = null;
            resources.ApplyResources(this.comboBC, "comboBC");
            this.comboBC.BackgroundImage = null;
            this.comboBC.Font = null;
            this.comboBC.FormattingEnabled = true;
            this.comboBC.Items.AddRange(new object[] {
            resources.GetString("comboBC.Items"),
            resources.GetString("comboBC.Items1")});
            this.comboBC.Name = "comboBC";
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
            // setBC
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.accountComboBox1);
            this.Controls.Add(this.comboBC);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelBC);
            this.Controls.Add(this.labelAccountName);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = null;
            this.Name = "setBC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelBC;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.ComboBox comboBC;
        private MaNGOS_GUI.Controls.AccountComboBox accountComboBox1;
    }
}