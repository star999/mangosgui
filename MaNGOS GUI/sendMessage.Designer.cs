namespace MaNGOS_GUI
{
    partial class sendMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sendMessage));
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.labelCharacterName = new System.Windows.Forms.Label();
            this.textCharacterName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.AccessibleDescription = null;
            this.labelMessage.AccessibleName = null;
            resources.ApplyResources(this.labelMessage, "labelMessage");
            this.labelMessage.Font = null;
            this.labelMessage.Name = "labelMessage";
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.AccessibleDescription = null;
            this.buttonSendMessage.AccessibleName = null;
            resources.ApplyResources(this.buttonSendMessage, "buttonSendMessage");
            this.buttonSendMessage.BackgroundImage = null;
            this.buttonSendMessage.Font = null;
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // textMessage
            // 
            this.textMessage.AccessibleDescription = null;
            this.textMessage.AccessibleName = null;
            resources.ApplyResources(this.textMessage, "textMessage");
            this.textMessage.BackgroundImage = null;
            this.textMessage.Font = null;
            this.textMessage.Name = "textMessage";
            // 
            // labelCharacterName
            // 
            this.labelCharacterName.AccessibleDescription = null;
            this.labelCharacterName.AccessibleName = null;
            resources.ApplyResources(this.labelCharacterName, "labelCharacterName");
            this.labelCharacterName.Font = null;
            this.labelCharacterName.Name = "labelCharacterName";
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
            // sendMessage
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.labelCharacterName);
            this.Controls.Add(this.textCharacterName);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.textMessage);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = null;
            this.Name = "sendMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Label labelCharacterName;
        private System.Windows.Forms.TextBox textCharacterName;
    }
}