using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaNGOS_GUI.DataAccess;

namespace MaNGOS_GUI.Controls
{
    public partial class CharactersComboBox : ComboBox
    {
        private IList<string> characterList = new List<string>();

        public CharactersComboBox()
        {
            InitializeComponent();

            try
            {
                ServerData sd = new ServerData();
                characterList = sd.getCharacters();
                comboCharacters.DataSource = characterList;
            }
            catch (Exception ex)
            { 
                //this.Items.Add(Resources.hcStringResources.Global_ErrorConnectingDBShort); 
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
