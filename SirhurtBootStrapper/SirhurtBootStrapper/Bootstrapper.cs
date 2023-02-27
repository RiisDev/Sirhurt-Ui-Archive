using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirhurtBootStrapper
{
    public partial class Main : Form
    {
		public static string SirHurtPath = Directory.GetCurrentDirectory();
		public static string dataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		public static string dataFolderName = "Roblox\\Versions";
		public static string ROBLOXPath = Path.Combine(dataFolderPath, dataFolderName);

        public Main()
        {
            InitializeComponent();
        }
		public string CalculateMD5Hash(string input)
		{
			HashAlgorithm hashAlgorithm = MD5.Create();
			byte[] bytes = Encoding.ASCII.GetBytes(input);
			byte[] array = hashAlgorithm.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("X2"));
			}
			return stringBuilder.ToString();
		}

		public static void CopyFilesRecursively(DirectoryInfo source, DirectoryInfo target)
        {
            foreach (DirectoryInfo directoryInfo in source.GetDirectories())
            {
                CopyFilesRecursively(directoryInfo, target.CreateSubdirectory(directoryInfo.Name));
            }
            foreach (FileInfo fileInfo in source.GetFiles())
            {
                fileInfo.CopyTo(Path.Combine(target.FullName, fileInfo.Name));
            }
        }

        private void InitDown()
        {
			new Thread(async delegate ()
			{
				//Thread.CurrentThread.IsBackground = true;
				Directory.CreateDirectory(SirHurtPath + "\\bin");
				Directory.CreateDirectory(SirHurtPath + "\\bin\\schemes");
				if (!Directory.Exists(SirHurtPath))
				{
					label1.Invoke(new Action(() => { label1.Text = "Creating Directory.."; }));
					Directory.CreateDirectory(SirHurtPath);
					DownloadProgress.Invoke(new Action(() => { DownloadProgress.Value += 5; }));
				}
				if (!Directory.Exists(SirHurtPath + "\\workspace"))
				{
					label1.Invoke(new Action(() => { label1.Text = "Creating workspace directory.."; }));
					Directory.CreateDirectory(SirHurtPath + "\\workspace");
				}
				if (!Directory.Exists(SirHurtPath + "\\autoexe"))
				{
					label1.Invoke(new Action(() => { label1.Text = "Creating autorun directory.."; }));
					Directory.CreateDirectory(SirHurtPath + "\\autoexe");
					using (WebClient webClient = new WebClient())
					{
						DialogResult dialogResult = MessageBox.Show("Would you like to download the autoexec file?", "Sirhurt V4 BootStrapper", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
						if (dialogResult == DialogResult.Yes)
							webClient.DownloadFile("https://sirhurt.net/asshurt/update/v4/loaded.lua", SirHurtPath + "\\autoexe\\loaded.lua");
					}
				}
				try
				{
					if (!File.Exists(SirHurtPath + "\\sirh.dat"))
					{
						File.Create(SirHurtPath + "\\sirh.dat").Dispose();
					}
					if (File.Exists(SirHurtPath + "\\SirHurt.new"))
					{
						File.Delete(SirHurtPath + "\\SirHurt.new");
					}
					if (File.Exists(SirHurtPath + "\\SirHurt V4.exe"))
					{
						File.Delete(SirHurtPath + "\\SirHurt V4.exe");
					}
					if (File.Exists(SirHurtPath + "\\SirHurt.dll"))
					{
						File.Delete(SirHurtPath + "\\SirHurt.dll");
					}
				}
				catch (IOException)
				{
					if (File.Exists(SirHurtPath + "\\SirHurt.dll"))
					{
						File.Move(SirHurtPath + "\\SirHurt.dll", Path.GetRandomFileName());
					}
				}
				try
				{
					WebClient webClient2 = new WebClient();
					label1.Invoke(new Action(() => { label1.Text = "Downloading SirHurt.."; }));

					string Latest_DLL = new WebClient().DownloadString("https://sirhurt.net/asshurt/update/v4/fetch_version.php");
					string DLL_Hash = new WebClient().DownloadString("https://sirhurt.net/asshurt/update/v4/fetch_sirhurt_version.php");

					if (Latest_DLL == "Failed: A update has not yet been released for this ROBLOX build.")
					{
						MessageBox.Show("An error occured while trying to update to the latest version of SirHurt V4. SirHurt has not yet released a new build for this ROBLOX version. Try again later!");
						Environment.Exit(0);
					}

					var wtKey = Registry.CurrentUser.OpenSubKey("Software\\Asshurt", true);
					if (wtKey != null)
					{
						wtKey.SetValue("VHASH", CalculateMD5Hash(DLL_Hash), RegistryValueKind.String);
					}

					webClient2.DownloadFile(Latest_DLL, SirHurtPath + "\\SirHurt.new");
					DownloadProgress.Invoke(new Action(() => { DownloadProgress.Value += 10; }));
					await Task.Delay(50);
					label1.Invoke(new Action(() => { label1.Text = "Downloading Injector.."; }));
					if (!File.Exists(SirHurtPath + "\\SirHurtInjector.dll"))
					{
						webClient2.DownloadFile("https://sirhurt.net/asshurt/update/v4/SirHurtInjector.dll", SirHurtPath + "\\SirHurtInjector.dll");
					}
					DownloadProgress.Invoke(new Action(() => { DownloadProgress.Value += 10; }));
					await Task.Delay(50);
					label1.Invoke(new Action(() => { label1.Text = "Downloading Discord Handler.."; }));
					if (!File.Exists(SirHurtPath + "\\DCJ.dll"))
					{
						webClient2.DownloadFile("https://sirhurt.net/asshurt/update/v4/DCJ.dll", SirHurtPath + "\\DCJ.dll");
					}
					DownloadProgress.Invoke(new Action(() => { DownloadProgress.Value += 10; }));
					await Task.Delay(50);
					label1.Invoke(new Action(() => { label1.Text = "Downloading executeable.."; }));
					webClient2.DownloadFile("https://sirhurt.net/asshurt/update/v4/GUI.exe", SirHurtPath + "\\SirHurt V4.exe");
					if (!File.Exists(SirHurtPath + "\\ScintillaNET.dll"))
					{
						webClient2.DownloadFile("https://sirhurt.net/asshurt/update/v4/ScintillaNET.dll", SirHurtPath + "\\ScintillaNET.dll");
					}
					webClient2.DownloadFile("https://sirhurt.net/asshurt/update/v4/intellisense.json", SirHurtPath + "\\bin\\intellisense.json");
					webClient2.DownloadFile("https://sirhurt.net/asshurt/update/v4/settings.json", SirHurtPath + "\\bin\\schemes\\settings.json");
					DownloadProgress.Invoke(new Action(() => { DownloadProgress.Value += 20; }));
					await Task.Delay(50);
					label1.Invoke(new Action(() => { label1.Text = "Renaming variables..."; }));
					if (!File.Exists(SirHurtPath + "\\SirHurt.new"))
					{
						MessageBox.Show("SirHurt was not able to be downloaded. Try turning off your anti virus software than restarting.");
						Environment.Exit(0);
					}
					else
					{
						File.Move(SirHurtPath + "\\SirHurt.new", SirHurtPath + "\\SirHurt.dll");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(string.Format("An error occured. Make sure any anti virus software is disabled and all instances of sirhurt are closed. Try running the bootstrapper as an administrator. The thrown error: ({0})\n Details: ({1})\n", ex.Message, ex.InnerException));
					Environment.Exit(0);
				}
				DownloadProgress.Invoke(new Action(async() =>
				{
					while (DownloadProgress.Value <= DownloadProgress.MaxValue)
					{
						if (DownloadProgress.Value >= DownloadProgress.MaxValue)
						{
							break;
						}
						DownloadProgress.Value += 10;
						await Task.Delay(50);
					}
				}));
				string text = Path.Combine(SirHurtPath, "SirHurt V4.exe");
				if (File.Exists(text))
				{
					label1.Invoke(new Action(() => { label1.Text = "Completed. Starting SirHurt.."; }));
					Process.Start(text);
					await Task.Delay(1000);
					base.Invoke(new Action(() => { Close(); }));
					Thread.CurrentThread.Abort();
				}
			}).Start();
		}

        private void Main_Load(object sender, EventArgs e)
        {
			foreach (Process proc in Process.GetProcessesByName("SirHurt V4"))
				proc.Kill();
			DownloadProgress.Value = 5;
			InitDown();
        }
    }
}
