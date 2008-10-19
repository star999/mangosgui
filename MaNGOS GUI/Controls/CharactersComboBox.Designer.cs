namespace MaNGOS_GUI.Controls
{
    partial class CharactersComboBox
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboCharacters = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboCharacters
            // 
            this.comboCharacters.FormattingEnabled = true;
            this.comboCharacters.Location = new System.Drawing.Point(0, 0);
            this.comboCharacters.Name = "comboCharacters";
            this.comboCharacters.Size = new System.Drawing.Size(121, 21);
            this.comboCharacters.TabIndex = 0;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCharacters;
    }
}
