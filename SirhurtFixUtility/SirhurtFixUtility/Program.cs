using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirhurtFixUtility
{

    class Program
    {

        public static bool Online()
        {
            WebRequest request = WebRequest.Create("https://sirhurt.net/");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response == null || response.StatusCode != HttpStatusCode.OK)
                return false;
            return true;
        }

        private static void UnableToLoad()
        {
            RegistryKey localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("> Checking real time protection settings...");
            RegistryKey registryKey = localKey.OpenSubKey("SOFTWARE\\Microsoft\\Windows Defender\\Real-Time Protection");
            if (registryKey.GetValue("DisableRealtimeMonitoring") as string == "1")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Real Time Protection is disabled!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Real Time Protection is enabled, please disable it!");
                Process.Start("ms-settings:windowsdefender");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("> Scanning processes for other anti-viruses...");
            foreach (Process proc in Process.GetProcesses())
            {
                if (proc.ProcessName.ToLower().Contains("anti") || proc.ProcessName.ToLower().Contains("malware"))
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"Potential anti-virus found: {proc.ProcessName}");
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("> Scanning for antivirus installs...");
            foreach (string File in Directory.GetDirectories($"C:\\Program Files"))
            {
                if (File.ToLower().Contains("malware") || File.ToLower().Contains("anti"))
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"Potential anti-virus found: {File}");
                }
            }
            foreach (string File in Directory.GetDirectories($"C:\\Program Files (x86)"))
            {
                if (File.ToLower().Contains("malware") || File.ToLower().Contains("anti"))
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"Potential anti-virus found: {File}");
                }
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Option (1) has ran successfully, program will close in 5 seconds!");
            Thread.Sleep(5000);
            Process.GetCurrentProcess().Kill();
        }

        static void Main(string[] args)
        {


            if (!Directory.Exists($"{Environment.CurrentDirectory}\\bin") || !File.Exists($"{Environment.CurrentDirectory}\\SirHurtInjector.dll")) { MessageBox.Show("This tool needs to be ran in the Sirhurt directory!", "OOP", MessageBoxButtons.OK, MessageBoxIcon.Error); Process.GetCurrentProcess().Kill(); }

            Console.WriteLine(@"                                      
                        ██████▓▓▓▓▓▓▓▓
                    ██████▒▒▒▒▒▒▒▒▒▒▓▓████
                  ████      ▒▒▒▒▒▒▒▒▒▒▓▓████
                ████          ▒▒▒▒▒▒▒▒▓▓░░████
              ████▓▓          ▒▒▒▒▒▒▒▒▓▓░░░░████
            ████░░▓▓▒▒      ▒▒▒▒▒▒▒▒▒▒▓▓░░░░░░██
            ██░░░░▓▓▒▒▒▒▒▒▒▒▒▒    ▒▒▒▒▓▓    ░░██
          ████░░░░▓▓▒▒░░▒▒▒▒▒▒▒▒▒▒░░▒▒▓
        ██████░░  ▓▓▒▒░░▒▒▒▒▒▒▒▒▒▒░░░░▓▓
     ░████████    ▓▓  ░░▒▒▒▒▒▒▒▒▒▒░░  ▓▓
      ░░░░████    ▓▓░░░░░░▒▒▒▒▒▒░░░░▓▓
          ░░██▓▓  ▓▓░░░░░░░░░░  ░░░░▓▓
          ░░██    ▓▓░░    ░░  ░░  ▓▓
                    ▓▓        ░░▓▓
                      ▓▓▓▓▓▓▓▓▒▒
");
            Console.Title = "{ Sirhurt Support Utility By Iris }";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Iris's Support Utility, please select one of the issues below!");
            Console.WriteLine("Running network test...");
            Console.WriteLine("");
            if (!Online())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: You are unable to reach Sirhurt.net, is the site down?");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Retry:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Network test ran!\nPlease press the number corresponding with your issue!");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
1) Unable to load DLL 'SirhurtInjector.dll' The specified module could not be found.
2) .Net Error (Access Denied)
3) Freezing when injecting
4) Scripthub failed to load
5) Delete all Sirhurt Files 
5) Other (Logs all processes, connection status to sirhurt, Sirhurt files     SEND TO SUPPORT REP IF THEY ASK)
");
            Console.ForegroundColor = ConsoleColor.White;
            string Choice = Console.ReadLine();
            switch (Choice)
            {
                case "1":
                    UnableToLoad();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                default:
                    goto Retry;
                    break;
            }

            Console.ReadLine();
        }
    }
}
