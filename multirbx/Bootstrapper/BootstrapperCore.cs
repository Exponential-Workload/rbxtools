// https://gist.github.com/YieldingExploiter/3a940751f6e2aeb0085b90929255459f/
// Bootstrapper Core
// Lets you write C# Bootstrappers with ease
// Licensed under MIT - Copyright (c) 2022 YieldingCoder.
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;

namespace Bootstrapper
{
  public class BootstrapperCore
  {
    public static string GenerateRandomAlphanumericString(int length = 10)
    {
      const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

      var random = new Random();
      var randomString = new string(Enumerable.Repeat(chars, length)
                                              .Select(s => s[random.Next(s.Length)]).ToArray());
      return randomString;
    }
    static WebClient client = new WebClient();
    static string TMP = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);//Path.GetTempPath(); // The location to download the files to
    public static void Run(string URL, string FileName, string ID)
    {
      string zipPath = TMP + $"\\{ID}.bin";
      string extractPath = GetLocationFromID(ID);
      if (Directory.Exists(extractPath)) Directory.Delete(extractPath, true);
      Directory.CreateDirectory(extractPath);
      Console.WriteLine("Downloading...");
      client.DownloadFile(URL, zipPath);
      Console.WriteLine("Extracting...");
      ZipFile.ExtractToDirectory(zipPath, extractPath);
      Console.WriteLine("Cleaning up Zip");
      File.Delete(zipPath);
      Console.WriteLine("Done!");
      var proc = new Process();
      proc.StartInfo.FileName = "cmd.exe";
      proc.StartInfo.UseShellExecute = false;
      proc.StartInfo.CreateNoWindow = true;
      proc.StartInfo.RedirectStandardOutput = true;
      proc.StartInfo.RedirectStandardInput = true;
      proc.StartInfo.Arguments = "/q /c start " + FileName + "";
      proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
      proc.StartInfo.WorkingDirectory = extractPath;
      proc.Start();
      proc.WaitForExit();
    }
    public static void RunExe(string URL, string ID)
    {
      string exePath = TMP + $"\\{ID}.exe";
      string extractPath = GetLocationFromID(ID);
      if (Directory.Exists(extractPath)) Directory.Delete(extractPath, true);
      Directory.CreateDirectory(extractPath);
      Console.WriteLine("Downloading...");
      client.DownloadFile(URL, exePath);
      Console.WriteLine("Done!");
      var proc = new Process();
      proc.StartInfo.FileName = "cmd.exe";
      proc.StartInfo.UseShellExecute = false;
      proc.StartInfo.CreateNoWindow = true;
      proc.StartInfo.RedirectStandardOutput = true;
      proc.StartInfo.RedirectStandardInput = true;
      proc.StartInfo.Arguments = "/q /c start " + exePath + "";
      proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
      proc.StartInfo.WorkingDirectory = extractPath;
      proc.Start();
      proc.WaitForExit();
    }

    public static string GetLocationFromID(string ID)
    {
      return TMP + $"\\{ID}\\";
    }
  }
}