using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMENUM
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ports = SerialPort.GetPortNames();
            string port_list = "";

            foreach (string port in ports)
            {
                port_list += (port + "\n");
            }

            var notification = new System.Windows.Forms.NotifyIcon()
            {
                Visible = true,
                Icon = System.Drawing.SystemIcons.Information,
                BalloonTipIcon = ToolTipIcon.None, // Setting this property results in a process GUID appearing at the bottom of the balloontip
                BalloonTipTitle = "Serial Ports Found:",
                BalloonTipText = port_list,
            };

            //notification.BalloonTipClicked += new EventHandler(notifyIcon_BaloonTipClicked);
            notification.ShowBalloonTip(5000);

            notification.Dispose();

            //Process.Start(@"C:\Program Files\PuTTY\putty.exe");
        }

        /*
        static void notifyIcon_BaloonTipClicked(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\PuTTY\putty.exe");
        }*/
    }
}