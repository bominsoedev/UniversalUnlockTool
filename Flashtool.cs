using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using UniversalUnlockTool.Properties;

namespace UniversalUnlockTool
{
    public static class FlashTool
    {
        public static void ProcessKill()
        {
            string[] array = new string[]
            {
                "flash_tool",
                "process"
            };
            foreach (string text in array)
            {
                Process[] processes = Process.GetProcesses();
                foreach (Process process in processes)
                {
                    bool flag = process.ProcessName.ToLower().Contains(text.ToLower());
                    if (flag)
                    {
                        try
                        {
                            process.Kill();
                        }
                        catch
                        {
                        }
                        process.WaitForExit();
                    }
                }
            }
        }

        public static void Command(string cmd)
        {
            FlashTool.c__DisplayClass2_0 c__DisplayClass2_ = new FlashTool.c__DisplayClass2_0();
            Form1.main.ProgressBar1.Invoke(new MethodInvoker(delegate ()
            {
                Form1.main.ProgressBar1.Value = 0;
            }));
            string logs = Resources.logs;
            //c__DisplayClass2_.stringlist = logs.Split(new char[]
            //{
            //    '\r',
            //    '\n'
            //}, StringSplitOptions.RemoveEmptyEntries);
            string errorlogs = Resources.errorlogs;
            string logs2 = Resources.logs1;
            //c__DisplayClass2_.stringerror = errorlogs.Split(new char[]
            //{
            //    '\r',
            //    '\n'
            //}, StringSplitOptions.RemoveEmptyEntries);
            //c__DisplayClass2_.logs1 = logs2.Split(new char[]
            //{
            //    '\r',
            //    '\n'
            //}, StringSplitOptions.RemoveEmptyEntries);
            ProcessStartInfo startInfo = new ProcessStartInfo(FlashTool.FlashtoolFilepath, cmd)
            {
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            using (Process process = Process.Start(startInfo))
            {
                Console.WriteLine(cmd);
                process.BeginOutputReadLine();
                try
                {
                    process.OutputDataReceived += c__DisplayClass2_.Commandb__1;
                }
                catch (Exception ex)
                {
                    RichLog.RichLogs(ex.Message, Color.Red, true, true);
                }
                process.WaitForExit();
            }
        }

        private static string FlashtoolFilepath = "Data\\sp\\flash_tool.exe";

        private sealed class c__DisplayClass2_0
        {
            internal void Commandb__1(object sender, DataReceivedEventArgs e)
            {
                if (e.Data != null)
                {
                    string data = e.Data;

                    try
                    {
                        if (data.Contains("Search usb, timeout set as 120000 ms"))
                        {
                            RichLog.RichLogs("Searching Mtk Preloader Port...", Color.Black, false, false);
                        }
                        if (data.Contains("USB port is obtained"))
                        {
                            Form1.main.Progresschange(0);
                            Form1.main.addlog("OK\r\n");
                            Form1.main.Progresschange(100);
                            Form1.main.addlog("Connecting: MediaTek PreLoader USB\r\n");
                        }
                        if (data.Contains("BROM connected"))
                        {
                            Form1.main.addlog(" BROM connected!");
                        }
                        if (data.Contains("Downloading & Connecting to DA..."))
                        {
                            Form1.main.addlog("\r\n Connecting to DA ... \"");
                        }
                        if (data.Contains("100% of DA has been sent."))
                        {
                            Form1.main.Progresschange(0);
                            Form1.main.addlog("OK\r\n");
                            Form1.main.Progresschange(100);
                            Form1.main.addlog("Download Agent Connect ... \"");
                        }
                        // RichLog.RichLogs(data, Color.Black, true, true);
                        if (e.Data.Contains("] WRITE TO PARTITION ["))
                        {
                            string msg = data.Remove(0, data.IndexOf("PARTITION"));
                            string text = e.Data.Replace(msg + "[", "").Replace("]", "");
                            Form1.main.addlog(" Writting ");
                            RichLog.RichLogs(msg.ToLower() + " ... ", Color.Black, false, false);
                        }
                        if (e.Data.Contains("% of image data has been sent"))
                        {
                            //string text2 = e.Data.Substring(0, e.Data.IndexOf("% of image data has been sent"));
                            //string text3 = text2.Replace("%", "");
                            int val = Convert.ToInt32(data.Substring(0, data.IndexOf("%")));
                            Form1.main.Progresschange(val);
                        }
                        if (e.Data.Contains("Stage: "))
                        {
                            RichLog.RichLogs("Done.", Color.Black, true, true);
                        }
                        if (e.Data.Contains("All command exec done!"))
                        {
                            RichLog.RichLogs("Done.", Color.Black, true, true);
                        }
                        bool flag11 = data.StartsWith("ERROR") | data.StartsWith("Uncaught");
                        if (flag11)
                        {
                            Form1.main.addlog("Fail");
                            string logText = data.Substring(data.IndexOf('('));
                            Form1.main.addlog(logText);
                        }
                        if (e.Data.Contains("of image data has been sent"))
                        {
                            FlashTool.c__DisplayClass2_0 __locals3 = new FlashTool.c__DisplayClass2_0();
                            string text = e.Data.Replace(" of image data has been sent", "").Replace("of", "").Replace("(", "").Replace(")", "");
                            Form1.main.lbl_status.Text = "Programming Flash : " + text;
                            return;
                        }
                        return;
                    }
                    catch
                    {

                    }
                }
            }

            public string[] stringlist;

            public string[] stringerror;

            public string[] logs1;
        }
    }
}