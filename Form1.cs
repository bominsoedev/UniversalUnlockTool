using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Util.Store;
using Microsoft.VisualBasic;
using MTKUnlock;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalUnlockTool
{
    public partial class Form1 : Form
    {
        public static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        public static string ApplicationName = "UniversalUnlockTool";
        public static string SpreadsheetId = "11VNDryFNQtyoBqGBK8jON9Eov4XFPWhNyyB8h1REGrY";
        public static string sheet = "Sheet1";
        public SheetsService services;
        internal static Form1 main;
        private Stopwatch _watch = new Stopwatch();
        private bool Frp = false;
        private bool Account = false;
        private bool Formatdata = false;
        private bool Writefirmware = false;

        public Form1()
        {
            InitializeComponent();
            Form1.main = this;
            CHECK_BYPASSAUTH.Checked = true;
            CHECK_BROM.Checked = true;
            CHECK_DOWNLOAD.Checked = true;
        }

        private delegate void updatedelegate(int LogText);

        public void Progresschange(int val)
        {
            if (base.InvokeRequired)
            {
                Form1.updatedelegate method = new Form1.updatedelegate(this.Progresschange);
                base.Invoke(method, new object[]
                {
            val
                });
                return;
            }
            if (val != 100)
            {
                this.ProgressBar1.Value = val;
                return;
            }
            this.ProgressBar1.Value = 100;
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgressBar1.Style = Guna.UI.WinForms.ProgressBarStyle.Marquee;
            if (!this.BGW_LOAD.IsBusy)
            {
                this.BGW_LOAD.RunWorkerAsync();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FlashTool.ProcessKill();
            this.richTextBox1.BackColor = this.BackColor;
            this.richTextBox1.ForeColor = this.ForeColor;
            string text = Path.Combine(Application.StartupPath, "Data\\sp\\DA_6765_6785_6768_6873_6885_6853.bin");
            this.TXT_DA.Text = text;
            boot.Da = text;
        }

        private delegate void callback(string LogText);

        public void addlog(string LogText)
        {
            if (base.InvokeRequired)
            {
                Form1.callback method = new Form1.callback(this.updatelog);
                base.Invoke(method, new object[]
                {
                    LogText
                });
                return;
            }
            this.updatelog(LogText);
        }

        public void updatelog(string LogText)
        {
            try
            {
                this.richTextBox1.AppendText(LogText);
                this.richTextBox1.ScrollToCaret();
                this.richTextBox1.Refresh();
                this.Refresh();
            }
            catch (Exception ex)
            {
            }
        }

        private void BGW_LOAD_DoWork(object sender, DoWorkEventArgs e)
        {
            base.BeginInvoke(new MethodInvoker(delegate ()
            {
                lbl_status.Text = "Synchronize Data.";
            }));
            ProgressBar1.Style = Guna.UI.WinForms.ProgressBarStyle.Marquee;
            UserCredential credential;
            using (var stream =
               new FileStream("Data//credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "UniversalUnlockTool";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            base.BeginInvoke(new MethodInvoker(delegate ()
            {
                COM_MODEL.Items.Clear();
            }));
            bool flag = this.COM_BRAND.SelectedIndex == 0;
            if (flag)
            {
                var range = $"{sheet}!A:A";
                SpreadsheetsResource.ValuesResource.GetRequest request =
                        service.Spreadsheets.Values.Get(SpreadsheetId, range);
                request = service.Spreadsheets.Values.Get(SpreadsheetId, range);
                var response = request.Execute();
                var values = response.Values;
                bool flag2 = values != null && values.Count > 0;
                if (flag2)
                {
                    foreach (var row in values)
                    {
                        Console.WriteLine("{0}", row[0]);
                        base.BeginInvoke(new MethodInvoker(delegate ()
                        {
                            lbl_status.Text = "Initializing Data ...";
                        }));
                        COM_MODEL.Items.Add(row[0].ToString());
                        base.BeginInvoke(new MethodInvoker(delegate ()
                        {
                            lbl_status.Text = "Synchronized Data Successfully.";
                        }));
                        Interaction.Beep();
                    }
                }
                else
                {
                    Console.WriteLine("No data found.");
                    base.BeginInvoke(new MethodInvoker(delegate ()
                    {
                        lbl_status.Text = "Synchronized Data Successfully : No data found.";
                    }));
                    Interaction.Beep();
                }
            }
            bool flag1 = this.COM_BRAND.SelectedIndex == 1;
            if (flag1)
            {
                var range = $"{sheet}!B:B";
                SpreadsheetsResource.ValuesResource.GetRequest request =
                        service.Spreadsheets.Values.Get(SpreadsheetId, range);
                request = service.Spreadsheets.Values.Get(SpreadsheetId, range);
                var response = request.Execute();
                var values = response.Values;
                bool flag3 = values != null && values.Count > 0;
                if (flag3)
                {
                    foreach (var row in values)
                    {
                        Console.WriteLine("{0}", row[0]);
                        base.BeginInvoke(new MethodInvoker(delegate ()
                        {
                            lbl_status.Text = "Initializing Data ...";
                        }));
                        COM_MODEL.Items.Add(row[0].ToString());
                        base.BeginInvoke(new MethodInvoker(delegate ()
                        {
                            lbl_status.Text = "Synchronized Data Successfully.";
                        }));
                        Interaction.Beep();
                    }
                }
                else
                {
                    Console.WriteLine("No data found.");
                    base.BeginInvoke(new MethodInvoker(delegate ()
                    {
                        lbl_status.Text = "Synchronized Data Successfully : No data found.";
                    }));
                    Interaction.Beep();
                }
            }
        }

        private void BGW_LOAD_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            base.BeginInvoke(new MethodInvoker(delegate ()
            {
                ProgressBar1.Style = Guna.UI.WinForms.ProgressBarStyle.Marquee;
            }));
        }

        private void BGW_LOAD_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressBar1.Style = Guna.UI.WinForms.ProgressBarStyle.Blocks;
        }

        private void CHECK_FORMAT_CheckedChanged(object sender, EventArgs e)
        {
            if (CHECK_FORMAT.Checked == true)
            {
                CHECK_FORMATSAFE.Checked = false;
                CHECK_FRP.Checked = false;
            }
        }

        private void CHECK_FRP_CheckedChanged(object sender, EventArgs e)
        {
            if (CHECK_FRP.Checked == true)
            {
                CHECK_FORMATSAFE.Checked = false;
                CHECK_FORMAT.Checked = false;
            }
        }

        private void CHECK_FORMATSAFE_CheckedChanged(object sender, EventArgs e)
        {
            if (CHECK_FORMATSAFE.Checked == true)
            {
                CHECK_FRP.Checked = false;
                CHECK_FORMAT.Checked = false;
            }
        }

        private void CHECK_UART_CheckedChanged(object sender, EventArgs e)
        {
            if (CHECK_UART.Checked == true)
            {
                CHECK_BROM.Checked = false;
                SPEED = "BromUART";
            }
        }

        private void CHECK_BROM_CheckedChanged(object sender, EventArgs e)
        {
            if (CHECK_BROM.Checked == true)
            {
                CHECK_UART.Checked = false;
                SPEED = "BromUSB";
            }
        }

        private void tabPane1_SelectedPageIndexChanged(object sender, EventArgs e)
        {
            if (tabPane1.SelectedPageIndex == 0)
            {
                GroupBoxUSB.Visible = true;
            }
            else if (tabPane1.SelectedPageIndex == 1)
            {
                GroupBoxUSB.Visible = true;
            }
            else if (tabPane1.SelectedPageIndex == 2)
            {
                GroupBoxUSB.Visible = false;
            }
        }

        public bool AuthDisable = false;

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choice Scatter File !";
            openFileDialog.Filter = "Scatter file  |*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.AuthDisable = false;
                if (boot.CheckAuth(openFileDialog.FileName))
                {
                    this.AuthDisable = true;
                }
                else
                {
                    this.AuthDisable = false;
                }
                string path = openFileDialog.FileName.Replace("\\" + openFileDialog.SafeFileName, "");
                List<mtkxml.mtk> list = mtkxml.ScatterTable(openFileDialog.FileName);
                if (list.Count > 0)
                {
                    this.TXT_SCATTER.Text = openFileDialog.FileName;
                    this.dataGridView1.Rows.Clear();
                    foreach (mtkxml.mtk mtk in list)
                    {
                        if (mtk.Download.ToLower() == "true")
                        {
                            string text = Path.Combine(path, mtk.Filename);
                            if (File.Exists(text))
                            {
                                this.dataGridView1.Rows.Add(new object[]
                                {
                            true,
                            mtk.PartitionName.ToUpper(),
                            mtk.Filename,
                            mtk.StartAddress.ToUpper(),
                            mtk.EndAddress.ToUpper(),
                            mtk.Index,
                                    text,
                                });
                            }
                            else
                            {
                                this.dataGridView1.Rows.Add(new object[]
                                {
                            true,
                            mtk.PartitionName.ToUpper(),
                            mtk.Filename,
                            mtk.StartAddress.ToUpper(),
                            mtk.EndAddress.ToUpper(),
                            mtk.Index,
                            text,
                                });
                            }
                        }
                    }
                    foreach (object obj in (this.dataGridView1.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        for (int i = 0; i < dataGridViewRow.Cells.Count; i++)
                        {
                            dataGridViewRow.Cells[i].Style.ForeColor = this.ForeColor;
                            dataGridViewRow.Cells[i].Style.BackColor = this.BackColor;
                        }
                    }
                    this.dataGridView1.BackgroundColor = this.BackColor;
                    this.dataGridView1.ForeColor = this.ForeColor;
                    foreach (object obj in ((IEnumerable)this.dataGridView1.Rows))
                    {
                        DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                        for (int i = 0; i < dataGridViewRow.Cells.Count; i++)
                        {
                            dataGridViewRow.Cells[i].Style.ForeColor = this.ForeColor;
                            dataGridViewRow.Cells[i].Style.BackColor = this.BackColor;
                        }
                    }
                    foreach (object obj2 in ((IEnumerable)this.dataGridView1.Rows))
                    {
                        DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
                        if (dataGridViewRow2.Cells[2].Value.ToString() == string.Empty)
                        {
                            dataGridViewRow2.Cells[2].Style.ForeColor = this.ForeColor;
                            dataGridViewRow2.Cells[2].Style.BackColor = this.BackColor;
                        }
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Scatter Not Support", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.richTextBox1.Invoke(new MethodInvoker(delegate ()
            {
                this.richTextBox1.SelectionStart = this.richTextBox1.Text.Length;
            }));
            this.richTextBox1.Invoke(new MethodInvoker(delegate ()
            {
                this.richTextBox1.ScrollToCaret();
            }));
        }

        private void CHECK_PART_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CHECK_PART.CheckState == CheckState.Checked)
            {
                foreach (object obj in ((IEnumerable)this.dataGridView1.Rows))
                {
                    DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                    for (int i = 0; i < dataGridViewRow.Cells.Count; i++)
                    {
                        if (dataGridViewRow.Cells[2].Value.ToString() != string.Empty)
                        {
                            dataGridViewRow.Cells[0].Value = true;
                        }
                        if (dataGridViewRow.Cells[2].Value.ToString() == string.Empty)
                        {
                            dataGridViewRow.Cells[0].Value = false;
                        }
                    }
                }
                return;
            }
            foreach (object obj2 in ((IEnumerable)this.dataGridView1.Rows))
            {
                DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
                for (int j = 0; j < dataGridViewRow2.Cells.Count; j++)
                {
                    dataGridViewRow2.Cells[0].Value = false;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 6)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Title = string.Format("Choice {0}  file !", this.dataGridView1.CurrentRow.Cells[1].Value);
                    openFileDialog.Filter = string.Format("{0}  |*.*|Other|*.*", this.dataGridView1.CurrentRow.Cells[1].Value);
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        this.dataGridView1.CurrentRow.Cells[2].Value = openFileDialog.SafeFileName;
                        this.dataGridView1.CurrentRow.Cells[5].Value = openFileDialog.FileName;
                        this.dataGridView1.CurrentRow.Cells[0].Value = true;
                        this.dataGridView1.EndEdit();
                    }
                }
                if (e.ColumnIndex == 0 && this.dataGridView1.CurrentRow.Cells[2].Value.ToString() == string.Empty)
                {
                    MessageBox.Show("Data File Not Found ! Please Add  correct data ", "info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.dataGridView1.CurrentRow.Cells[0].Value = false;
                    this.dataGridView1.EndEdit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString());
            }
        }

        private string SPEED;
        public static List<mtkxml.firmware> Firmware = new List<mtkxml.firmware>();
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Form1.Firmware.Clear();
            foreach (object obj in ((IEnumerable)this.dataGridView1.Rows))
            {
                DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                if (Convert.ToBoolean(dataGridViewRow.Cells[0].Value))
                {
                    Form1.Firmware.Add(new mtkxml.firmware(dataGridViewRow.Cells[5].Value.ToString(), dataGridViewRow.Cells[6].Value.ToString()));
                }
            }
            if (Form1.Firmware.Count <= 0)
            {
            }
            else if (string.IsNullOrEmpty(this.TXT_DA.Text))
            {
            }
            if(CHECK_DOWNLOAD.Checked == true)
            {
            this.FirmwareXML = mtkxml.DownloadFirmware(this.TXT_SCATTER.Text, this.TXT_DA.Text, this.TXT_AUTH.Text, this.SPEED, Form1.Firmware);
            this.BGW_WRITE.RunWorkerAsync();
            }
            else if(CHECK_ERASEDOWNLOAD.Checked == true)
            {
                this.FirmwareXML = mtkxml.Format_DownloadFirmware(this.TXT_SCATTER.Text, this.TXT_DA.Text, this.TXT_AUTH.Text, this.SPEED, Form1.Firmware);
                this.BGW_WRITE.RunWorkerAsync();
            }
        }

        private string FirmwareXML
        {
            get;
            set;
        }

        private void BGW_WRITE_DoWork(object sender, DoWorkEventArgs e)
        {
            if(CHECK_BYPASSAUTH.Checked == true)
            {
                this._watch.Reset();
                this._watch.Start();
                if (this.AuthDisable)
                {
                    BootRom.Command("main.py", this.BGW_WRITE, e);
                }
                try
                {
                    if (this.BGW_WRITE.CancellationPending)
                    {
                        try
                        {
                            string fileName = Path.Combine(Path.GetTempPath(), "config.xml");
                            FileInfo fileInfo = new FileInfo(fileName);
                            fileInfo.Delete();
                        }
                        catch
                        {
                        }
                        e.Cancel = true;
                        return;
                    }
                    FlashTool.Command(string.Format("-b -i \"{0}", this.FirmwareXML));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    string fileName2 = Path.Combine(Path.GetTempPath(), "config.xml");
                    FileInfo fileInfo2 = new FileInfo(fileName2);
                    fileInfo2.Delete();
                }
                catch
                {
                }
                RichLog.RichLogs("Operation Complete : ", Color.Black, false, false);
                this._watch.Stop();
                TimeSpan elapsed = this._watch.Elapsed;
                string str = string.Format("{0:00m}: {1:00s}", elapsed.Minutes, elapsed.Seconds);
                RichLog.RichLogs("" + str, Color.Black, false, true);
                Interaction.Beep();
            }
            else if(CHECK_BYPASSAUTH.Checked == false)
            {
                this._watch.Reset();
                this._watch.Start();
                if (this.AuthDisable)
                {
                   // BootRom.Command("main.py", this.BGW_WRITE, e);
                }
                try
                {
                    if (this.BGW_WRITE.CancellationPending)
                    {
                        try
                        {
                            string fileName = Path.Combine(Path.GetTempPath(), "config.xml");
                            FileInfo fileInfo = new FileInfo(fileName);
                            fileInfo.Delete();
                        }
                        catch
                        {
                        }
                        e.Cancel = true;
                        return;
                    }
                    FlashTool.Command(string.Format("-b -i \"{0}", this.FirmwareXML));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    string fileName2 = Path.Combine(Path.GetTempPath(), "config.xml");
                    FileInfo fileInfo2 = new FileInfo(fileName2);
                    fileInfo2.Delete();
                }
                catch
                {
                }
                RichLog.RichLogs(" Operation Complete", Color.Blue, true, true);
                this._watch.Stop();
                TimeSpan elapsed = this._watch.Elapsed;
                string str = string.Format("{0:00m}: {1:00s}", elapsed.Minutes, elapsed.Seconds);
                RichLog.RichLogs("\t" + str, Color.Black, false, false);
            }
        }

        private void BTN_UNLOCK_Click(object sender, EventArgs e)
        {

        }
    }
}