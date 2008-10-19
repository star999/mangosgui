using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaNGOS_GUI.DataAccess;
using MaNGOS_GUI.Resources;

namespace MaNGOS_GUI
{
    public partial class serverBans : Form
    {
        public serverBans()
        {
            InitializeComponent();
        }

        private void comboBanType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBanType.SelectedIndex;

            if (radioBan.Checked == true)
            {
                switch (i)
                {
                    case 0:
                        labelChosenType.Text = hcStringResources.serverBans_CaseAccount;
                        break;
                    case 1:
                        labelChosenType.Text = hcStringResources.serverBans_CaseCharacter;
                        break;
                    case 2:
                        labelChosenType.Text = hcStringResources.serverBans_CaseIP;
                        break;
                }


                textChosenType.Visible = true;
                labelReason.Visible = true;
                textReason.Visible = true;
                labelDuration.Visible = true;
                textDuration.Visible = true;
            }
            else
            {
                if (radioUnban.Checked == true)
                {
                    switch (i)
                    {
                        case 0:
                            labelChosenType.Text = hcStringResources.serverBans_CaseAccount;
                            break;
                        case 1:
                            labelChosenType.Text = hcStringResources.serverBans_CaseCharacter;
                            break;
                        case 2:
                            labelChosenType.Text = hcStringResources.serverBans_CaseIP;
                            break;
                    }

                    textChosenType.Visible = true;
                }
                else
                {
                    comboBanType.SelectedText = "";
                    MessageBox.Show(hcStringResources.serverBans_ChooseBanUnban);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioBan.Checked == true)
                {
                    if (!String.IsNullOrEmpty(comboBanType.Text))
                    {
                        if (!String.IsNullOrEmpty(textChosenType.Text))
                        {
                            if (!String.IsNullOrEmpty(textReason.Text))
                            {
                                string commandString = "ban " + comboBanType.Text + " " + textChosenType.Text + " " +
                                                        textReason.Text + " " + textDuration.Text;
                                ManguiMain.mangosProcess.StandardInput.WriteLine(commandString);

                                ConfigAccess.updateLog(commandString);

                                MessageBox.Show(string.Format(Resources.hcStringResources.Global_CommandSuccesful, commandString));
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(hcStringResources.serverBans_EnterBanReason);
                            }
                        }
                        else
                        {
                            MessageBox.Show(hcStringResources.serverBans_EnterAccountCharIP);
                        }
                    }
                    else
                    {
                        MessageBox.Show(hcStringResources.serverBans_ChooseBanType);
                    }
                }
                else
                {
                    if (radioUnban.Checked == true)
                    {
                        if (!String.IsNullOrEmpty(comboBanType.Text))
                        {
                            if (!String.IsNullOrEmpty(textChosenType.Text))
                            {
                                string commandString = "unban " + comboBanType.Text + " " + textChosenType.Text;
                                ManguiMain.mangosProcess.StandardInput.WriteLine(commandString);

                                ConfigAccess.updateLog(commandString);

                                MessageBox.Show(string.Format(hcStringResources.Global_CommandSuccesful, commandString));
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(hcStringResources.serverBans_EnterAccountCharIP);
                            }
                        }
                        else
                        {
                            MessageBox.Show(hcStringResources.serverBans_ChooseBanType);
                        }
                    }
                    else
                    {
                        MessageBox.Show(hcStringResources.serverBans_ChooseBanUnban);
                    }
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.Global_CommandError);
            }
        }
    }
}
