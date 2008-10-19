namespace MaNGOS_GUI
{
    partial class kickCharacter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kickCharacter));
            this.buttonKick = new System.Windows.Forms.Button();
            this.textCharacterName = new System.Windows.Forms.TextBox();
            this.labelCharacterName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonKick
            // 
            this.buttonKick.BackColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.buttonKick, "buttonKick");
            this.buttonKick.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonKick.Name = "buttonKick";
            this.buttonKick.UseVisualStyleBackColor = false;
            this.buttonKick.Click += new System.EventHandler(this.buttonKick_Click);
            // 
            // textCharacterName
            // 
            resources.ApplyResources(this.textCharacterName, "textCharacterName");
            this.textCharacterName.Name = "textCharacterName";
            // 
            // labelCharacterName
            // 
            resources.ApplyResources(this.labelCharacterName, "labelCharacterName");
            this.labelCharacterName.Name = "labelCharacterName";
            // 
            // kickCharacter
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonKick);
            this.Controls.Add(this.textCharacterName);
            this.Controls.Add(this.labelCharacterName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "kickCharacter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKick;
        private System.Windows.Forms.TextBox textCharacterName;
        private System.Windows.Forms.Label labelCharacterName;
    }
}