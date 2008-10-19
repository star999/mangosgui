namespace MaNGOS_GUI
{
    partial class broadcastMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(broadcastMessage));
            this.textBroadcastMessage = new System.Windows.Forms.TextBox();
            this.buttonBroadcastMessage = new System.Windows.Forms.Button();
            this.labelBroadcastMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBroadcastMessage
            // 
            this.textBroadcastMessage.AccessibleDescription = null;
            this.textBroadcastMessage.AccessibleName = null;
            resources.ApplyResources(this.textBroadcastMessage, "textBroadcastMessage");
            this.textBroadcastMessage.BackgroundImage = null;
            this.textBroadcastMessage.Font = null;
            this.textBroadcastMessage.Name = "textBroadcastMessage";
            // 
            // buttonBroadcastMessage
            // 
            this.buttonBroadcastMessage.AccessibleDescription = null;
            this.buttonBroadcastMessage.AccessibleName = null;
            resources.ApplyResources(this.buttonBroadcastMessage, "buttonBroadcastMessage");
            this.buttonBroadcastMessage.BackgroundImage = null;
            this.buttonBroadcastMessage.Font = null;
            this.buttonBroadcastMessage.Name = "buttonBroadcastMessage";
            this.buttonBroadcastMessage.UseVisualStyleBackColor = true;
            this.buttonBroadcastMessage.Click += new System.EventHandler(this.buttonBroadcastMessage_Click);
            // 
            // labelBroadcastMessage
            // 
            this.labelBroadcastMessage.AccessibleDescription = null;
            this.labelBroadcastMessage.AccessibleName = null;
            resources.ApplyResources(this.labelBroadcastMessage, "labelBroadcastMessage");
            this.labelBroadcastMessage.Font = null;
            this.labelBroadcastMessage.Name = "labelBroadcastMessage";
            // 
            // broadcastMessage
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.labelBroadcastMessage);
            this.Controls.Add(this.buttonBroadcastMessage);
            this.Controls.Add(this.textBroadcastMessage);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = null;
            this.Name = "broadcastMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBroadcastMessage;
        private System.Windows.Forms.Button buttonBroadcastMessage;
        private System.Windows.Forms.Label labelBroadcastMessage;
    }
}