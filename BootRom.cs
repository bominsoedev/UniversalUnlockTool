using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using UniversalUnlockTool.Properties;

namespace UniversalUnlockTool
{
    public static class BootRom
    {
        public static void Command(string cmd, BackgroundWorker worker, DoWorkEventArgs ee)
        {
            BootRom.c__DisplayClass1_0 c__DisplayClass1_ = new BootRom.c__DisplayClass1_0();

            c__DisplayClass1_.worker = worker;
            string auth = Resources.Auth;
            c__DisplayClass1_.stringlist = auth.Split(new char[]
           {
                '\r',
                '\n'
           }, StringSplitOptions.RemoveEmptyEntries);

            c__DisplayClass1_.result = true;
            RichLog.RichLogs("Connecting to BootROM... ", Color.Black, false, true);
            RichLog.RichLogs(" Power off the phone, disconnect and reconnect the battery(if possible) and connect USB cable... ", Color.BlueViolet, false, true);
            RichLog.RichLogs("Hold the VOL UP to force MediaTek BootROM.", Color.Black, false, true);
            RichLog.RichLogs("Scanning BootROM or Preloader port...", Color.Black, false, false);
            ProcessStartInfo startInfo = new ProcessStartInfo(BootRom.Python, cmd)
            {
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                Verb = "runas",
                WorkingDirectory = "Data\\lib",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            using (Process process = Process.Start(startInfo))
            {
                Console.WriteLine(cmd);
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                if (c__DisplayClass1_.worker.CancellationPending)
                {
                    RichLog.RichLogs(" User Process Stop ", Color.Red, true, true);
                    process.Dispose();
                    ee.Cancel = true;
                }
                else
                {
                    try
                    {
                        process.OutputDataReceived += c__DisplayClass1_.Commandb__0;
                        process.ErrorDataReceived += c__DisplayClass1_.Commandb__1;
                    }
                    catch (Exception)
                    {
                        c__DisplayClass1_.result = false;
                        c__DisplayClass1_.worker.CancelAsync();
                    }
                    process.WaitForExit();
                    if (c__DisplayClass1_.result)
                    {
                        RichLog.RichLogs("Disable Authorized ", Color.Green, true, true);
                        process.Dispose();
                        ee.Cancel = true;
                    }
                }
            }
        }
        public static void Cmd(string cmd)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "Data\\lib\\process.exe",
                Arguments = cmd
            };
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = true;
            ProcessStartInfo startInfo = processStartInfo;
            Process process = new Process
            {
                StartInfo = startInfo
            };
            DataReceivedEventHandler value = new DataReceivedEventHandler(BootRom.Value);
            process.OutputDataReceived += value;
            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();
        }

        private static void Value(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine(e.Data);
            if (e.Data != null)
            {
                RichLog.RichLogs(e.Data ?? "", Color.Red, true, true);
                Console.WriteLine(e.Data);
            }
        }

        public static void install(string cmd)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(BootRom.Python, cmd)
            {
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                Verb = "runas",
                WorkingDirectory = "Data\\lib\\",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            using (Process process = Process.Start(startInfo))
            {
                Console.WriteLine(cmd);
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                try
                {
                    process.OutputDataReceived += BootRom.c.ccc.installb__4_0;
                    process.ErrorDataReceived += BootRom.c.ccc.installb__4_1;
                }
                catch
                {
                }
                process.WaitForExit();
            }
        }

        public static string Python = "Data\\lib\\process.exe";

        private sealed class c__DisplayClass1_0
        {
            internal void Commandb__0(object sender, DataReceivedEventArgs e)
            {
                string data = e.Data;
                //if (e.Data != null)
                //{
                //    foreach (string value in this.stringlist)
                //    {
                //        if (e.Data.Contains(value))
                //        {
                //            string msg = e.Data.Remove(0, e.Data.IndexOf(""));
                //            //RichLog.RichLogs(msg, Color.Green, true, true);
                          
                //        }
                //    }
                //}
                try
                {
                    if (data.Contains("Found port "))
                    {
                        RichLog.RichLogs("Found!", Color.Black, true, true);
                    }
                    if (data.Contains("Device hw code: "))
                    {
                        string msg = data.Remove(0, data.IndexOf(": "));
                        RichLog.RichLogs("Device hw code : ", Color.Black, false, false);
                        RichLog.RichLogs(msg, Color.Black, true, true);
                    }
                    if (data.Contains("Device hw sub code: "))
                    {
                        string msg = data.Remove(0, data.IndexOf(": "));
                        RichLog.RichLogs("Device hw sub code: ", Color.Black, false, false);
                        RichLog.RichLogs(msg, Color.Black, true, true);
                    }
                    if (data.Contains("Device hw version: "))
                    {
                        string msg = data.Remove(0, data.IndexOf(": "));
                        RichLog.RichLogs("Device hw version: ", Color.Black, false, false);
                        RichLog.RichLogs(msg, Color.Black, true, true);
                    }
                    if (data.Contains("Device sw version: "))
                    {
                        string msg = data.Remove(0, data.IndexOf(": "));
                        RichLog.RichLogs("Device sw version: ", Color.Black, false, false);
                        RichLog.RichLogs(msg, Color.Black, true, true);
                    }
                    if (data.Contains("Device secure boot: "))
                    {
                        string msg = data.Remove(0, data.IndexOf(": "));
                        RichLog.RichLogs("Device secure boot: ", Color.Black, false, false);
                        RichLog.RichLogs(msg, Color.Black, true, true);
                    }
                    if (data.Contains("Device serial link authorization: "))
                    {
                        string msg = data.Remove(0, data.IndexOf(": "));
                        RichLog.RichLogs("Device serial link authorization: ", Color.Black, false, false);
                        RichLog.RichLogs(msg, Color.Black, true, true);
                    }
                    if (data.Contains("Device download agent authorization: "))
                    {
                        string msg = data.Remove(0, data.IndexOf(": "));
                        RichLog.RichLogs("Device download agent authorization: ", Color.Black, false, false);
                        RichLog.RichLogs(msg, Color.Black, true, true);
                    }
                    if (data.Contains("Disabling watchdog timer"))
                    {
                        RichLog.RichLogs("Disabling watchdog timer", Color.Black, true, true);
                    }
                    if (data.Contains("Disabling protection"))
                    {
                        RichLog.RichLogs("Disabling protection", Color.Black, true, true);
                    }
                }
                catch
                {
                }
            }

            internal void Commandb__1(object sender, DataReceivedEventArgs e)
            {
                if (e.Data != null)
                {
                    this.result = false;
                    this.worker.CancelAsync();
                }
            }

            public string[] stringlist;

            public bool result;

            public BackgroundWorker worker;
        }

        [Serializable]
        private sealed class c
        {
            internal void installb__4_0(object sender, DataReceivedEventArgs e)
            {
                if (e.Data != null)
                {
                    RichLog.RichLogs(e.Data ?? "", Color.Black, true, true);
                }
            }

            internal void installb__4_1(object sender, DataReceivedEventArgs e)
            {
                if (e.Data != null)
                {
                    RichLog.RichLogs(e.Data ?? "", Color.Red, true, true);
                }
            }

            public static readonly BootRom.c ccc = new BootRom.c();
            public static DataReceivedEventHandler __4_0;
            public static DataReceivedEventHandler __4_1;
        }
    }
}