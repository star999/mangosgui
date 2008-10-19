namespace MaNGOS_GUI
{
    partial class teleChar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teleChar));
            this.buttonTeleport = new System.Windows.Forms.Button();
            this.textCharacterName = new System.Windows.Forms.TextBox();
            this.labelCharacterName = new System.Windows.Forms.Label();
            this.labelChooseLocation = new System.Windows.Forms.Label();
            this.comboLocations = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonTeleport
            // 
            this.buttonTeleport.AccessibleDescription = null;
            this.buttonTeleport.AccessibleName = null;
            resources.ApplyResources(this.buttonTeleport, "buttonTeleport");
            this.buttonTeleport.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonTeleport.BackgroundImage = null;
            this.buttonTeleport.Font = null;
            this.buttonTeleport.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonTeleport.Name = "buttonTeleport";
            this.buttonTeleport.UseVisualStyleBackColor = false;
            this.buttonTeleport.Click += new System.EventHandler(this.buttonTeleport_Click);
            // 
            // textCharacterName
            // 
            this.textCharacterName.AccessibleDescription = null;
            this.textCharacterName.AccessibleName = null;
            resources.ApplyResources(this.textCharacterName, "textCharacterName");
            this.textCharacterName.BackgroundImage = null;
            this.textCharacterName.Font = null;
            this.textCharacterName.Name = "textCharacterName";
            // 
            // labelCharacterName
            // 
            this.labelCharacterName.AccessibleDescription = null;
            this.labelCharacterName.AccessibleName = null;
            resources.ApplyResources(this.labelCharacterName, "labelCharacterName");
            this.labelCharacterName.Font = null;
            this.labelCharacterName.Name = "labelCharacterName";
            // 
            // labelChooseLocation
            // 
            this.labelChooseLocation.AccessibleDescription = null;
            this.labelChooseLocation.AccessibleName = null;
            resources.ApplyResources(this.labelChooseLocation, "labelChooseLocation");
            this.labelChooseLocation.Font = null;
            this.labelChooseLocation.Name = "labelChooseLocation";
            // 
            // comboLocations
            // 
            this.comboLocations.AccessibleDescription = null;
            this.comboLocations.AccessibleName = null;
            resources.ApplyResources(this.comboLocations, "comboLocations");
            this.comboLocations.BackgroundImage = null;
            this.comboLocations.Font = null;
            this.comboLocations.FormattingEnabled = true;
            this.comboLocations.Name = "comboLocations";
            // 
            // teleChar
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.comboLocations);
            this.Controls.Add(this.labelChooseLocation);
            this.Controls.Add(this.buttonTeleport);
            this.Controls.Add(this.textCharacterName);
            this.Controls.Add(this.labelCharacterName);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = null;
            this.Name = "teleChar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTeleport;
        private System.Windows.Forms.TextBox textCharacterName;
        private System.Windows.Forms.Label labelCharacterName;
        private System.Windows.Forms.Label labelChooseLocation;
        private System.Windows.Forms.ComboBox comboLocations;
    }
}