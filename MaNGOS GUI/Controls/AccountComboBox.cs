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
    public partial class AccountComboBox : ComboBox
    {
        public AccountComboBox()
        {
            InitializeComponent();

            try
            {
                ServerData sd = new ServerData();
                this.DataSource = sd.getAccounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
