namespace MaNGOS_GUI
{
    partial class serverBans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serverBans));
            this.comboBanType = new System.Windows.Forms.ComboBox();
            this.labelBanType = new System.Windows.Forms.Label();
            this.radioBan = new System.Windows.Forms.RadioButton();
            this.radioUnban = new System.Windows.Forms.RadioButton();
            this.labelChosenType = new System.Windows.Forms.Label();
            this.textChosenType = new System.Windows.Forms.TextBox();
            this.textReason = new System.Windows.Forms.TextBox();
            this.labelReason = new System.Windows.Forms.Label();
            this.textDuration = new System.Windows.Forms.TextBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBanType
            // 
            this.comboBanType.FormattingEnabled = true;
            this.comboBanType.Items.AddRange(new object[] {
            resources.GetString("comboBanType.Items"),
            resources.GetString("comboBanType.Items1"),
            resources.GetString("comboBanType.Items2")});
            resources.ApplyResources(this.comboBanType, "comboBanType");
            this.comboBanType.Name = "comboBanType";
            this.comboBanType.SelectedIndexChanged += new System.EventHandler(this.comboBanType_SelectedIndexChanged);
            // 
            // labelBanType
            // 
            resources.ApplyResources(this.labelBanType, "labelBanType");
            this.labelBanType.Name = "labelBanType";
            // 
            // radioBan
            // 
            resources.ApplyResources(this.radioBan, "radioBan");
            this.radioBan.Name = "radioBan";
            this.radioBan.TabStop = true;
            this.radioBan.UseVisualStyleBackColor = true;
            // 
            // radioUnban
            // 
            resources.ApplyResources(this.radioUnban, "radioUnban");
            this.radioUnban.Name = "radioUnban";
            this.radioUnban.TabStop = true;
            this.radioUnban.UseVisualStyleBackColor = true;
            // 
            // labelChosenType
            // 
            resources.ApplyResources(this.labelChosenType, "labelChosenType");
            this.labelChosenType.Name = "labelChosenType";
            // 
            // textChosenType
            // 
            resources.ApplyResources(this.textChosenType, "textChosenType");
            this.textChosenType.Name = "textChosenType";
            // 
            // textReason
            // 
            resources.ApplyResources(this.textReason, "textReason");
            this.textReason.Name = "textReason";
            // 
            // labelReason
            // 
            resources.ApplyResources(this.labelReason, "labelReason");
            this.labelReason.Name = "labelReason";
            // 
            // textDuration
            // 
            resources.ApplyResources(this.textDuration, "textDuration");
            this.textDuration.Name = "textDuration";
            // 
            // labelDuration
            // 
            resources.ApplyResources(this.labelDuration, "labelDuration");
            this.labelDuration.Name = "labelDuration";
            // 
            // buttonUpdate
            // 
            resources.ApplyResources(this.buttonUpdate, "buttonUpdate");
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // serverBans
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textDuration);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.textReason);
            this.Controls.Add(this.labelReason);
            this.Controls.Add(this.textChosenType);
            this.Controls.Add(this.labelChosenType);
            this.Controls.Add(this.radioUnban);
            this.Controls.Add(this.radioBan);
            this.Controls.Add(this.labelBanType);
            this.Controls.Add(this.comboBanType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "serverBans";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBanType;
        private System.Windows.Forms.RadioButton radioUnban;
        private System.Windows.Forms.Label labelChosenType;
        private System.Windows.Forms.TextBox textChosenType;
        private System.Windows.Forms.TextBox textReason;
        private System.Windows.Forms.Label labelReason;
        private System.Windows.Forms.TextBox textDuration;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Button buttonUpdate;
        public System.Windows.Forms.ComboBox comboBanType;
        public System.Windows.Forms.RadioButton radioBan;
    }
}