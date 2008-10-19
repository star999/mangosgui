namespace MaNGOS_GUI
{
    partial class writeDump
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(writeDump));
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelPlayerNameOrGuid = new System.Windows.Forms.Label();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.comboboxplayer = new MaNGOS_GUI.Controls.CharactersComboBox();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.AccessibleDescription = null;
            this.buttonCreate.AccessibleName = null;
            resources.ApplyResources(this.buttonCreate, "buttonCreate");
            this.buttonCreate.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonCreate.BackgroundImage = null;
            this.buttonCreate.Font = null;
            this.buttonCreate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelPlayerNameOrGuid
            // 
            this.labelPlayerNameOrGuid.AccessibleDescription = null;
            this.labelPlayerNameOrGuid.AccessibleName = null;
            resources.ApplyResources(this.labelPlayerNameOrGuid, "labelPlayerNameOrGuid");
            this.labelPlayerNameOrGuid.Font = null;
            this.labelPlayerNameOrGuid.Name = "labelPlayerNameOrGuid";
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
            // comboboxplayer
            // 
            this.comboboxplayer.AccessibleDescription = null;
            this.comboboxplayer.AccessibleName = null;
            resources.ApplyResources(this.comboboxplayer, "comboboxplayer");
            this.comboboxplayer.BackgroundImage = null;
            this.comboboxplayer.DataSource = ((object)(resources.GetObject("comboboxplayer.DataSource")));
            this.comboboxplayer.Font = null;
            this.comboboxplayer.FormattingEnabled = true;
            this.comboboxplayer.Name = "comboboxplayer";
            // 
            // writeDump
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.comboboxplayer);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelPlayerNameOrGuid);
            this.Controls.Add(this.textFileName);
            this.Controls.Add(this.labelFileName);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = null;
            this.Name = "writeDump";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label labelPlayerNameOrGuid;
        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.Label labelFileName;
        private MaNGOS_GUI.Controls.CharactersComboBox comboboxplayer;
    }
}