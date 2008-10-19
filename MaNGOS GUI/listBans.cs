using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaNGOS_GUI.DataAccess;

namespace MaNGOS_GUI
{
    public partial class listBans : Form
    {
        public listBans()
        {
            InitializeComponent();

            ServerData sData = new ServerData();
            DataTable bans = sData.getBans();

            dataBanList.ReadOnly = true;
            dataBanList.AllowUserToAddRows = false;
            dataBanList.AllowUserToDeleteRows = false;
            dataBanList.DataSource = bans;

            setColumnWidth();
        }

        private void setColumnWidth()
        {
            int column = 0;

            while (column < dataBanList.Columns.Count)
            {
                dataBanList.Columns[column].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                column++;
            }

        }
    }
}
