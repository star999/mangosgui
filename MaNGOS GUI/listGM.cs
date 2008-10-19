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
    public partial class listGM : Form
    {
        public listGM()
        {
            InitializeComponent();

            ServerData sData = new ServerData();
            DataTable gmList = sData.getGM();

            dataGMList.ReadOnly = true;
            dataGMList.AllowUserToAddRows = false;
            dataGMList.AllowUserToDeleteRows = false;
            dataGMList.DataSource = gmList;
        }

        private void setColumnWidth()
        {
            int column = 0;

            while (column < dataGMList.Columns.Count)
            {
                dataGMList.Columns[column].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                column++;
            }
        }
    }
}
