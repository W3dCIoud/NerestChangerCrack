using System;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Threading;

namespace NerestChanger
{
    class Program
    {
        private const string ChangerLink = "https://github.com/W3dCIoud/NerestChangerCrack/raw/main/NerestFiles/daaaa.exe";
        private const string PatcherLink = "https://github.com/W3dCIoud/NerestChangerCrack/raw/main/NerestFiles/lowcodesinhuini.dll";

        public static void Main()
        {
            Console.Title = "t.me/x86hook | NerestChanger crack (RECODE)";
            DownloadFiles();
        }

        public static void Logs(string message)
        {
            Console.WriteLine("[t.me/x86hook] " + message);
        }

        public static void DownloadFiles()
        {
            if (!Directory.Exists("C:\\NerestFiles"))
            {
                Directory.CreateDirectory("C:\\NerestFiles");
                string directory = "C:\\NerestFiles";
                WebClient webClient = new WebClient();
                Logs("Downloading the crack files...");
                webClient.DownloadFile(ChangerLink, directory + "\\daaaa.exe");
                webClient.DownloadFile(PatcherLink, directory + "\\lowcodesinhuini.dll");
                Logs("Files downloaded, continuing...");
                DeletingShit();
            }
            else
            {
                Logs("Changer files detected, download canceled.");
                DeletingShit();
            }
        }

        public static void DeletingShit()
        {
            if (File.Exists("C:\\ProgramData\\NerestChanger\\User.dat"))
            {
                File.Delete("C:\\ProgramData\\NerestChanger\\User.dat");
		Crack();
            }
            else
            {
                Logs("User configuration is not founded.");
		Crack();
            }
        }

        public static void Crack()
        {
            Process.Start("C:\\NerestFiles\\daaaa.exe");
            Process[] pname = Process.GetProcessesByName("daaaa");
            if (pname.Length == 0)
            {
                Logs("NerestChanger process is not started, exiting..");
                Thread.Sleep(3500);
                Environment.Exit(0x1337);
            }
            else
            {
                Logs("Waiting to fully load NerestChanger...");
                Thread.Sleep(5500);
                Logs("Cracking...");
                File.Move("C:\\NerestFiles\\lowcodesinhuini.dll", "C:\\NerestFiles\\Fernet.dll");
                Logs("Cracked!");
                Thread.Sleep(3500);
                File.Move("C:\\NerestFiles\\Fernet.dll", "C:\\NerestFiles\\lowcodesinhuini.dll");
                Environment.Exit(0x1337);
            }
        }
    }
}
