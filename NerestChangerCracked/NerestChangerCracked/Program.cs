using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

class Program
{

    private const string SourceFilePath = "C:\\NerestCrackByW3dCloud\\lowcodesinhuini.dll";
    private const string DestinationFilePath = "C:\\NerestCrackByW3dCloud\\Fernet.dll";
    private const string ChangerEXEPath = "C:\\NerestCrackByW3dCloud\\daaaa.exe";
    private const string CrackURL = "https://github.com/W3dCIoud/NerestChangerCrack/raw/main/NerestFiles/lowcodesinhuini.dll";
    private const string NegrestChangerURL = "https://github.com/W3dCIoud/NerestChangerCrack/raw/main/NerestFiles/daaaa.exe";

    static async Task Main()
    {

        string path = @"C:\NerestCrackByW3dCloud";
        Directory.CreateDirectory(path);
        File.Delete(ChangerEXEPath);
        File.Delete(SourceFilePath);
        File.Delete(DestinationFilePath);
        File.Delete("C:\\ProgramData\\NerestChanger\\User.dat");

        Console.Title = "R.I.P NerestChanger | Cracked by W3dCloud | @W3dCloudRiver";


        Console.WriteLine("\t\t\t\t\t\t[+] R.I.P NerestChanger");
        Console.WriteLine("\t\t\t\t[+] Cracked by W3dCloud. Nice anti-crack system, LowCode :D");
        Console.WriteLine("[AD] Best obfuscation & HWID System for BlueStacks - @tears_and_fears!");
        Console.WriteLine("[+] Downloading files");
        await DownloadFileAsync(NegrestChangerURL, @"C:\NerestCrackByW3dCloud\daaaa.exe");
        await Task.Delay(7500);
        await DownloadFileAsync(CrackURL, @"C:\NerestCrackByW3dCloud\lowcodesinhuini.dll");
        await Task.Delay(5000);
        try
        {
            // Переименовываем файл
            if (File.Exists(SourceFilePath))
            { 
                Process.Start(ChangerEXEPath);
                Console.WriteLine("[+] Starting NerestChanger...");
                Console.WriteLine("[+] Bypassing the fucking Fernet.dll check...");
                File.Move(SourceFilePath, DestinationFilePath);
                await Task.Delay(7500);
                Console.WriteLine("[+] Cracked!");
                await Task.Delay(5000);
            }
            else
            {
                Console.WriteLine("[=] Failed.");
                await Task.Delay(2000);
                Environment.Exit(0);
                File.Delete(ChangerEXEPath);
                File.Delete(SourceFilePath);
                File.Delete(DestinationFilePath);
                File.Delete("C:\\ProgramData\\NerestChanger\\User.dat");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("[=] Failed.");
            await Task.Delay(2000);
            Environment.Exit(0);
            File.Delete(ChangerEXEPath);
            File.Delete(SourceFilePath);
            File.Delete(DestinationFilePath);
            File.Delete("C:\\ProgramData\\NerestChanger\\User.dat");
        }
    }

    private static async Task DownloadFileAsync(string url, string fileName)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                byte[] fileBytes = await client.GetByteArrayAsync(url);
                await File.WriteAllBytesAsync(fileName, fileBytes);
            }
            catch (HttpRequestException httpEx)
            {
                Console.WriteLine($"[=] Error HTTP: {httpEx.Message}");
                await Task.Delay(2000);
                Environment.Exit(0);
                File.Delete(ChangerEXEPath);
                File.Delete(SourceFilePath);
                File.Delete(DestinationFilePath);
                File.Delete("C:\\ProgramData\\NerestChanger\\User.dat");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[=] Error: {ex.Message}");
                await Task.Delay(2000);
                Environment.Exit(0);
                File.Delete(ChangerEXEPath);
                File.Delete(SourceFilePath);
                File.Delete(DestinationFilePath);
                File.Delete("C:\\ProgramData\\NerestChanger\\User.dat");
            }
        }
    }
}


