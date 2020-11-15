using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Ping _ping = new Ping();
        public Form1()
        {



            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {



            lblresult.Text = "";


            // string myip = int.Parse(Octet1.Value.ToString()) + "." + Octet2.Value.ToString() + "." + Octet3.Value.ToString() + "." + Octet4.Value.ToString();
            string s = Octet1.Value.ToString() + "." + Octet2.Value.ToString() + "." + Octet3.Value.ToString() + "." + Octet1.Value.ToString();
            IPAddress myip = IPAddress.Parse(s);
            // PingReply pingreply = _ping.Send(myip, 1000);

            PingReply[] pingreply = new PingReply[4];


            if (chkhostname.Checked == true)
            {
                try
                {
                    for (int i = 0; i < 2; i++)
                    {
                        pingreply[i] = _ping.Send(txthostname.Text, 1000);
                        lblresult.Text += pingreply[i].Status.ToString();
                        if (pingreply[i].Status == IPStatus.Success)
                        {
                            Beep(400, 1000);
                            lblresult.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblresult.ForeColor = Color.Red;
                            lblresult.Text+= pingreply[i].Status.ToString();
                            Beep(1000, 1000); Beep(100, 200); Beep(1000, 1000); Beep(100, 500); Beep(1000, 1000); Beep(100, 500);
                        }
                    }

                    
                }
                catch (Exception r)
                {

                    MessageBox.Show(r.Message+"Invalid IP Address","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            else
            {
                try
                {
                    for (int i = 0; i < 4; i++)
                    {
                        pingreply[i] = _ping.Send(myip, 1000);
                        lblresult.Text += pingreply[i].Status.ToString();
                        if (pingreply[i].Status == IPStatus.Success)
                        {
                            Beep(400, 1000);
                            lblresult.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblresult.ForeColor = Color.Red;
                            lblresult.Text = pingreply[i].Status.ToString();
                            Beep(1000, 1000); Beep(100, 200); Beep(1000, 1000); Beep(100, 500); Beep(1000, 1000); Beep(100, 500);
                        }

                    }
                    
                }
                catch (Exception r)
                {

                    MessageBox.Show(r.Message);
                }

            }



            //MessageBox.Show(pingreply.Status.ToString());

        }





        private static void Beep(int frequency, int Timer)
        {
            System.Console.Beep(frequency, Timer);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txthostname.Enabled = false;
            loadnic();
            loadgateways();
            IPHostEntry IPHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] IPs = IPHostEntry.AddressList;

            foreach (IPAddress IPAddress in IPHostEntry.AddressList)
            {

                lblprivateip.Text += "\n---" + IPAddress.ToString() + "\n";
            }

            lblpublicip.Text = Get_Internet_IP_Address();



        }

        void loadnic()
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var item in adapters)
            {
                txtnetworkinterfaces.Text += item.Name + "   " + item.Description + "-------";
            }


        }
        void loadgateways()
        {

            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                GatewayIPAddressInformationCollection addresses = adapterProperties.GatewayAddresses;

                foreach (GatewayIPAddressInformation address in addresses)
                {

                    lblgateways.Text += "\n\n" + address.Address.ToString() + "\n";

                }


            }
        }


        public static void DisplayGatewayAddresses()
        {

            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();


        }

        string Get_Internet_IP_Address()
        {
            string InternetIP = null;
            try
            {
                InternetIP = new WebClient().DownloadString("http://icanhazip.com");
                return InternetIP;
            }
            catch (Exception)
            {

                lblpublicip.Text = "NO Internet";
                return "NO Internet";
            }

        }

        private void btndevicemanager_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("devmgmt.msc");
            }
            catch (Exception r)
            {

                MessageBox.Show("Try Again", "Error", MessageBoxButtons.OK);
            }


        }

        private void btnprinters_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("cmd", "/C control printers");
            }
            catch (Exception r)
            {

                MessageBox.Show("Try Again", "Error", MessageBoxButtons.OK);
            }


        }

        private void btncmd_Click(object sender, EventArgs e)
        {
            try
            {

                if (chkhostname.Checked)
                {
                    ExecuteCommand(@"psexec \\" +txthostname.Text + " -i -d -s cmd.exe", true);
                }
                else
                {
                    string s = Octet1.Value.ToString() + "." + Octet2.Value.ToString() + "." + Octet3.Value.ToString() + "." + Octet1.Value.ToString();
                    IPAddress myip = IPAddress.Parse(s);
                    ExecuteCommand(@"psexec \\" +txthostname.Text + " -i -d -s cmd.exe", true);

                    

                }


            }
            catch (Exception r)
            {

                MessageBox.Show("Try Again", "Error", MessageBoxButtons.OK);
            }



        }

        private void btntaskmanager_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Taskmgr.exe");
            }
            catch (Exception r)
            {

                MessageBox.Show("Try Again", "Error", MessageBoxButtons.OK);
            }

        }

        private void btnregedit_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("regedit.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnconnections_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteCommand("ncpa.cpl", false);
            }
            catch (Exception r)
            {

                MessageBox.Show("Try Again", "Error", MessageBoxButtons.OK);
            }

        }
        public void ExecuteCommand(string Command, bool show = true)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/K " + Command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = true;
            if (!show) processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process process = Process.Start(processInfo);
        }

        private void Octet1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            //    e.Handled = true;
        }

        [STAThread]
        private void btnrun_Click(object sender, EventArgs e)
        {
            try
            {
                Shell32.Shell shell = new Shell32.Shell();
                shell.FileRun();
            }
            catch (Exception r)
            {

                MessageBox.Show("Try Again", "Error", MessageBoxButtons.OK);
            }

        }

        private void btncontrolpanel_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteCommand("control panel", false);
            }
            catch (Exception r)
            {

                MessageBox.Show("Try Again", "Error", MessageBoxButtons.OK);
            }

        }

        private void btnrefreshtxtnetworkinterfaces_Click(object sender, EventArgs e)
        {
            try
            {
                txtnetworkinterfaces.Text = "";
                loadnic();
            }
            catch (Exception r)
            {

                MessageBox.Show("Try Again", "Error", MessageBoxButtons.OK);
            }

        }

        private void btntrace_Click(object sender, EventArgs e)
        {
            try
            {

                if (chkhostname.Checked)
                {
                    ExecuteCommand("tracert -d " + txthostname.Text, true);
                }
                else
                {
                    string s = Octet1.Value.ToString() + "." + Octet2.Value.ToString() + "." + Octet3.Value.ToString() + "." + Octet1.Value.ToString();
                    IPAddress myip = IPAddress.Parse(s);
                    ExecuteCommand("tracert -d " + myip, true);
                }


            }
            catch (Exception r)
            {

                MessageBox.Show("Try Again", "Error", MessageBoxButtons.OK);
            }

        }

        private void btnnslookup_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkhostname.Checked)
                {
                    ExecuteCommand("nslookup " + txthostname.Text, true);
                }
                else
                {
                    string s = Octet1.Value.ToString() + "." + Octet2.Value.ToString() + "." + Octet3.Value.ToString() + "." + Octet1.Value.ToString();
                    IPAddress myip = IPAddress.Parse(s);
                    ExecuteCommand("nslookup " + myip, true);

                }

            }
            catch (Exception r)
            {

                MessageBox.Show("Try Again", "Error", MessageBoxButtons.OK);
            }


        }

        private void btnservices_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteCommand("services.msc", false);
            }
            catch (Exception r)
            {

                MessageBox.Show("Try Again", "Error", MessageBoxButtons.OK);
            }

        }



        private void Octet4_Enter(object sender, EventArgs e)
        {
            Octet4.Select(0, Octet4.Value.ToString().Length);
            //MessageBox.Show("En");
        }

        private void Octet3_Click(object sender, EventArgs e)
        {
            Octet3.Select(0, Octet3.Value.ToString().Length);
        }

        private void Octet4_Click(object sender, EventArgs e)
        {
            Octet4.Select(0, Octet4.Value.ToString().Length);
        }

        private void Octet2_Click(object sender, EventArgs e)
        {
            Octet2.Select(0, Octet2.Value.ToString().Length);
        }

        private void Octet1_Click(object sender, EventArgs e)
        {
            Octet1.Select(0, Octet1.Value.ToString().Length);
        }

        private void chkhostname_CheckedChanged(object sender, EventArgs e)
        {
            txthostname.Enabled = !txthostname.Enabled;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                if (chkhostname.Checked)
                {
                    ExecuteCommand(@"psexec \\"+ txthostname.Text + "'cmd.exe' / c shutdown / f / r  / t 10 " , true);
                }
                else
                {
                    string s = Octet1.Value.ToString() + "." + Octet2.Value.ToString() + "." + Octet3.Value.ToString() + "." + Octet1.Value.ToString();
                    IPAddress myip = IPAddress.Parse(s);
                    ExecuteCommand(@"psexec \\" + txthostname.Text + "'cmd.exe' / c shutdown / f / r  / t 10 ", true);
                }


            }
            catch (Exception r)
            {

                MessageBox.Show("Try Again", "Error", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (chkhostname.Checked)
                {
                    ExecuteCommand("ping -t " + txthostname.Text, true);
                }
                else
                {
                    string s = Octet1.Value.ToString() + "." + Octet2.Value.ToString() + "." + Octet3.Value.ToString() + "." + Octet1.Value.ToString();
                    IPAddress myip = IPAddress.Parse(s);
                    ExecuteCommand("ping -t " + myip, true);
                }


            }
            catch (Exception r)
            {

                MessageBox.Show("Try Again", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
