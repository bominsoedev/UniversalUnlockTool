using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace UniversalUnlockTool
{
    public static class mtkxml
    {
        public static string CPU;
        public static string CPUType;

        public class mtk
        {
            public string PartitionName
            {
                get;
                set;
            }

            public string StartAddress
            {
                get;
                set;
            }

            public string EndAddress
            {
                get;
                set;
            }

            public string Index { get; set; }
            public string Filename { get; set; }
            public string Download { get; set; }

            public mtk(string partitionname, string startaddress, string endaddress, string index, string filename, string download)
            {
                this.PartitionName = partitionname;
                this.StartAddress = startaddress;
                this.EndAddress = endaddress;
                this.Index = index;
                this.Filename = filename;
                this.Download = download;
            }
        }

        public class firmware
        {
            public string Index { get; set; }
            public string Filepath { get; set; }

            public firmware(string index, string filepath)
            {
                this.Index = index;
                this.Filepath = filepath;
            }
        }

        public static List<mtkxml.mtk> ScatterTable(string scatteryfile)
        {
            List<mtkxml.mtk> list = new List<mtkxml.mtk>();
            string text = File.ReadAllText(scatteryfile);
            string[] array = text.Split(new char[]
            {
                '-'
            });
            foreach (string text2 in array)
            {
                if (text2.Contains("partition_name"))
                {
                    string partitionname = "";
                    string filename = "";
                    string startaddress = "";
                    string endaddress = "";
                    string download = "";
                    string index = "";
                    using (StringReader stringReader = new StringReader(text2))
                    {
                        while (stringReader.Peek() != -1)
                        {
                            string text3 = stringReader.ReadLine();
                            if (text3.Contains("partition_name"))
                            {
                                partitionname = text3.Substring(text3.IndexOf(":") + 2);
                            }
                            if (text3.Contains("linear_start_addr"))
                            {
                                startaddress = text3.Substring(text3.IndexOf(":") + 2);
                            }
                            if (text3.Contains("partition_size"))
                            {
                                endaddress = text3.Substring(text3.IndexOf(":") + 2);
                            }
                            if (text3.Contains("file_name"))
                            {
                                filename = text3.Substring(text3.IndexOf(":") + 2);
                            }
                            if (text3.Contains("is_download"))
                            {
                                download = text3.Substring(text3.IndexOf(":") + 2);
                            }
                            if (text3.Contains("partition_index"))
                            {
                                index = text3.Substring(text3.IndexOf(":") + 2).Replace("SYS", "");
                            }
                        }
                    }
                    list.Add(new mtkxml.mtk(partitionname, startaddress, endaddress, index, filename, download));
                }
            }
            return list;
        }

        public static bool isSupport(string scatter)
        {
            bool result;
            try
            {
                bool flag = false;
                mtkxml.CPU = "";
                mtkxml.CPUType = "";
                string s = File.ReadAllText(scatter);
                using (StringReader stringReader = new StringReader(s))
                {
                    while (stringReader.Peek() != -1)
                    {
                        string text = stringReader.ReadLine();
                        if (text.Contains("platform:"))
                        {
                            mtkxml.CPU = text.Substring(text.IndexOf(":") + 2);
                            flag = true;
                        }
                        else if (text.Contains("storage: EMMC"))
                        {
                            mtkxml.CPUType = "EMMC";
                        }
                        else if (text.Contains("storage: NAND"))
                        {
                            mtkxml.CPUType = "NAND";
                        }
                        else if (text.Contains("storage: UFS"))
                        {
                            mtkxml.CPUType = "UFS";
                        }
                    }
                }
                result = flag;
            }
            catch
            {
                throw new Exception("Scatter cant support !");
            }
            return result;
        }

        private static string GetIndex(string scatter, string partition)
        {
            string text = File.ReadAllText(scatter);
            string result = "";
            string[] array = text.Split(new char[]
            {
                '-'
            });
            foreach (string text2 in array)
            {
                if (text2.Contains(partition))
                {
                    using (StringReader stringReader = new StringReader(text2))
                    {
                        while (stringReader.Peek() != -1)
                        {
                            string text3 = stringReader.ReadLine();
                            if (text3.Contains("partition_index"))
                            {
                                result = text3.Substring(text3.IndexOf(":") + 2).Replace("SYS", "");
                            }
                        }
                    }
                }
            }
            return result;
        }

        private static string[] GetAddress(string scatter, string partition)
        {
            string text = File.ReadAllText(scatter);
            string[] array = new string[2];
            string[] array2 = text.Split(new char[]
            {
                '-'
            });
            foreach (string text2 in array2)
            {
                if (text2.Contains(partition))
                {
                    using (StringReader stringReader = new StringReader(text2))
                    {
                        while (stringReader.Peek() != -1)
                        {
                            string text3 = stringReader.ReadLine();
                            if (text3.Contains("linear_start_addr"))
                            {
                                array[0] = text3.Substring(text3.IndexOf(":") + 2);
                            }
                            else if (text3.Contains("partition_size"))
                            {
                                array[1] = text3.Substring(text3.IndexOf(":") + 2);
                            }
                        }
                    }
                }
            }
            return array;
        }

        public static string SafeFormat(string scatter, string DA, string auth, string preloader, string writefile, string port)
        {
            string result;
            if (mtkxml.isSupport(scatter))
            {
                string value = "";
                List<mtkxml.mtk> list = mtkxml.ScatterTable(scatter);
                foreach (mtkxml.mtk mtk in list)
                {
                    if (mtk.PartitionName.ToLower() == "para")
                    {
                        string startAddress = mtk.StartAddress;
                        string endAddress = mtk.EndAddress;
                        value = mtk.Index;
                        break;
                    }
                }
                XmlDocument xmlDocument = new XmlDocument();
                XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement xmlElement = xmlDocument.CreateElement("flashtool-config");
                xmlElement.SetAttribute("version", "2.0");
                XmlNode xmlNode = xmlDocument.CreateElement("general");
                XmlElement xmlElement2 = xmlDocument.CreateElement("chip-name");
                xmlElement2.InnerText = mtkxml.CPU;
                XmlElement xmlElement3 = xmlDocument.CreateElement("storage-type");
                xmlElement3.InnerText = mtkxml.CPUType;
                XmlElement xmlElement4 = xmlDocument.CreateElement("download-agent");
                xmlElement4.InnerText = DA;
                XmlElement xmlElement5 = xmlDocument.CreateElement("scatter");
                xmlElement5.InnerText = scatter;
                XmlElement xmlElement6 = xmlDocument.CreateElement("authentication");
                xmlElement6.InnerText = auth;
                XmlElement xmlElement7 = xmlDocument.CreateElement("certification");
                xmlElement7.InnerText = "";
                XmlNode xmlNode2 = xmlDocument.CreateElement("rom-list");
                XmlElement xmlElement8 = xmlDocument.CreateElement("rom");
                xmlElement8.SetAttribute("index", value);
                xmlElement8.SetAttribute("enable", "true");
                xmlElement8.InnerText = writefile;
                XmlElement xmlElement9 = xmlDocument.CreateElement("connection");
                xmlElement9.SetAttribute("type", port);
                xmlElement9.SetAttribute("high-speed", "true");
                xmlElement9.SetAttribute("power", "AutoDetect");
                xmlElement9.SetAttribute("da_log_level", "Info");
                xmlElement9.SetAttribute("da_log_channel", "UART");
                xmlElement9.SetAttribute("timeout-count", "120000");
                xmlElement9.SetAttribute("com-port", "");
                XmlNode xmlNode3 = xmlDocument.CreateElement("checksum-level");
                xmlNode3.InnerText = "none";
                XmlElement xmlElement10 = xmlDocument.CreateElement("log-info");
                xmlElement10.SetAttribute("log_on", "true");
                xmlElement10.SetAttribute("log_path", "C:\\ProgramData\\SP_FT_Logs");
                xmlElement10.SetAttribute("clean_hours", "21");
                xmlNode2.AppendChild(xmlElement8);
                xmlDocument.AppendChild(newChild);
                xmlDocument.AppendChild(xmlElement);
                xmlNode.AppendChild(xmlElement2);
                xmlNode.AppendChild(xmlElement3);
                xmlNode.AppendChild(xmlElement4);
                xmlNode.AppendChild(xmlElement5);
                xmlNode.AppendChild(xmlElement6);
                xmlNode.AppendChild(xmlElement7);
                xmlNode.AppendChild(xmlNode2);
                xmlNode.AppendChild(xmlElement9);
                xmlNode.AppendChild(xmlNode3);
                xmlNode.AppendChild(xmlElement10);
                XmlNode xmlNode4 = xmlDocument.CreateElement("commands");
                XmlElement xmlElement11 = xmlDocument.CreateElement("download-only");
                XmlElement newChild2 = xmlDocument.CreateElement("da-download-all");
                xmlElement.AppendChild(xmlNode);
                xmlElement.AppendChild(xmlNode4);
                xmlNode4.AppendChild(xmlElement11);
                xmlElement11.AppendChild(newChild2);
                string text = Path.Combine(Path.GetTempPath(), "config.xml");
                xmlDocument.Save(text);
                result = text;
            }
            else
            {
                result = null;
            }
            return result;
        }

        public static string DownloadFirmware(string scatter, string DA, string auth, string port, List<mtkxml.firmware> downloadlist)
        {
            string result;
            if (mtkxml.isSupport(scatter))
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement xmlElement = xmlDocument.CreateElement("flashtool-config");
                xmlElement.SetAttribute("version", "2.0");
                XmlNode xmlNode = xmlDocument.CreateElement("general");
                XmlElement xmlElement2 = xmlDocument.CreateElement("chip-name");
                xmlElement2.InnerText = mtkxml.CPU;
                XmlElement xmlElement3 = xmlDocument.CreateElement("storage-type");
                xmlElement3.InnerText = mtkxml.CPUType;
                XmlElement xmlElement4 = xmlDocument.CreateElement("download-agent");
                xmlElement4.InnerText = DA;
                XmlElement xmlElement5 = xmlDocument.CreateElement("scatter");
                xmlElement5.InnerText = scatter;
                XmlElement xmlElement6 = xmlDocument.CreateElement("authentication");
                xmlElement6.InnerText = auth;
                XmlElement xmlElement7 = xmlDocument.CreateElement("certification");
                xmlElement7.InnerText = "";
                XmlNode xmlNode2 = xmlDocument.CreateElement("rom-list");
                foreach (mtkxml.firmware firmware in downloadlist)
                {
                    XmlElement xmlElement8 = xmlDocument.CreateElement("rom");
                    xmlElement8.SetAttribute("index", firmware.Index);
                    xmlElement8.SetAttribute("enable", "true");
                    xmlElement8.InnerText = firmware.Filepath;
                    xmlNode2.AppendChild(xmlElement8);
                }
                XmlElement xmlElement9 = xmlDocument.CreateElement("connection");
                xmlElement9.SetAttribute("type", port);
                xmlElement9.SetAttribute("high-speed", "true");
                xmlElement9.SetAttribute("power", "AutoDetect");
                xmlElement9.SetAttribute("da_log_level", "Info");
                xmlElement9.SetAttribute("da_log_channel", "UART");
                xmlElement9.SetAttribute("timeout-count", "120000");
                xmlElement9.SetAttribute("com-port", "");
                XmlNode xmlNode3 = xmlDocument.CreateElement("checksum-level");
                xmlNode3.InnerText = "none";
                XmlElement xmlElement10 = xmlDocument.CreateElement("log-info");
                xmlElement10.SetAttribute("log_on", "true");
                xmlElement10.SetAttribute("log_path", "C:\\ProgramData\\SP_FT_Logs");
                xmlElement10.SetAttribute("clean_hours", "24");
                xmlDocument.AppendChild(newChild);
                xmlDocument.AppendChild(xmlElement);
                xmlNode.AppendChild(xmlElement2);
                xmlNode.AppendChild(xmlElement3);
                xmlNode.AppendChild(xmlElement4);
                xmlNode.AppendChild(xmlElement5);
                xmlNode.AppendChild(xmlElement6);
                xmlNode.AppendChild(xmlElement7);
                xmlNode.AppendChild(xmlNode2);
                xmlNode.AppendChild(xmlElement9);
                xmlNode.AppendChild(xmlNode3);
                xmlNode.AppendChild(xmlElement10);
                XmlNode xmlNode4 = xmlDocument.CreateElement("commands");
                XmlElement xmlElement11 = xmlDocument.CreateElement("download-only");
                XmlElement newChild2 = xmlDocument.CreateElement("da-download-all");
                xmlElement.AppendChild(xmlNode);
                xmlElement.AppendChild(xmlNode4);
                xmlNode4.AppendChild(xmlElement11);
                xmlElement11.AppendChild(newChild2);
                string text = Path.Combine(Path.GetTempPath(), "config.xml");
                xmlDocument.Save(text);
                result = text;
            }
            else
            {
                result = null;
            }
            return result;
        }

        public static string Format_DownloadFirmware(string scatter, string DA, string auth, string port, List<mtkxml.firmware> downloadlist)
        {
            string result;
            if (mtkxml.isSupport(scatter))
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement xmlElement = xmlDocument.CreateElement("flashtool-config");
                xmlElement.SetAttribute("version", "2.0");
                XmlNode xmlNode = xmlDocument.CreateElement("general");
                XmlElement xmlElement2 = xmlDocument.CreateElement("chip-name");
                xmlElement2.InnerText = mtkxml.CPU;
                XmlElement xmlElement3 = xmlDocument.CreateElement("storage-type");
                xmlElement3.InnerText = mtkxml.CPUType;
                XmlElement xmlElement4 = xmlDocument.CreateElement("download-agent");
                xmlElement4.InnerText = DA;
                XmlElement xmlElement5 = xmlDocument.CreateElement("scatter");
                xmlElement5.InnerText = scatter;
                XmlElement xmlElement6 = xmlDocument.CreateElement("authentication");
                xmlElement6.InnerText = auth;
                XmlElement xmlElement7 = xmlDocument.CreateElement("certification");
                xmlElement7.InnerText = "";
                XmlNode xmlNode2 = xmlDocument.CreateElement("rom-list");
                foreach (mtkxml.firmware firmware in downloadlist)
                {
                    XmlElement xmlElement8 = xmlDocument.CreateElement("rom");
                    xmlElement8.SetAttribute("index", firmware.Index);
                    xmlElement8.SetAttribute("enable", "true");
                    xmlElement8.InnerText = firmware.Filepath;
                    xmlNode2.AppendChild(xmlElement8);
                }
                XmlElement xmlElement9 = xmlDocument.CreateElement("connection");
                xmlElement9.SetAttribute("type", port);
                xmlElement9.SetAttribute("high-speed", "true");
                xmlElement9.SetAttribute("power", "AutoDetect");
                xmlElement9.SetAttribute("da_log_level", "Info");
                xmlElement9.SetAttribute("da_log_channel", "UART");
                xmlElement9.SetAttribute("timeout-count", "120000");
                xmlElement9.SetAttribute("com-port", "");
                XmlNode xmlNode3 = xmlDocument.CreateElement("checksum-level");
                xmlNode3.InnerText = "none";
                XmlElement xmlElement10 = xmlDocument.CreateElement("log-info");
                xmlElement10.SetAttribute("log_on", "true");
                xmlElement10.SetAttribute("log_path", "C:\\ProgramData\\SP_FT_Logs");
                xmlElement10.SetAttribute("clean_hours", "24");
                xmlDocument.AppendChild(newChild);
                xmlDocument.AppendChild(xmlElement);
                xmlNode.AppendChild(xmlElement2);
                xmlNode.AppendChild(xmlElement3);
                xmlNode.AppendChild(xmlElement4);
                xmlNode.AppendChild(xmlElement5);
                xmlNode.AppendChild(xmlElement6);
                xmlNode.AppendChild(xmlElement7);
                xmlNode.AppendChild(xmlNode2);
                xmlNode.AppendChild(xmlElement9);
                xmlNode.AppendChild(xmlNode3);
                xmlNode.AppendChild(xmlElement10);
                XmlNode xmlNode4 = xmlDocument.CreateElement("commands");
                XmlElement xmlElement11 = xmlDocument.CreateElement("format-download");
                XmlNode xmlNode5 = xmlDocument.CreateElement("combo-format");
                XmlElement xmlElement12 = xmlDocument.CreateElement("format");
                xmlElement12.SetAttribute("validation", "false");
                xmlElement12.SetAttribute("physical", "true");
                xmlElement12.SetAttribute("erase-flag", "NormalErase");
                xmlElement12.SetAttribute("auto-format", "true");
                xmlElement12.SetAttribute("auto-format-flag", "FormatAll");
                xmlNode5.AppendChild(xmlElement12);
                XmlElement newChild2 = xmlDocument.CreateElement("da-download-all");
                xmlElement.AppendChild(xmlNode);
                xmlElement.AppendChild(xmlNode4);
                xmlNode4.AppendChild(xmlElement11);
                xmlElement11.AppendChild(xmlNode5);
                xmlElement11.AppendChild(newChild2);
                string text = Path.Combine(Path.GetTempPath(), "config.xml");
                xmlDocument.Save(text);
                result = text;
            }
            else
            {
                result = null;
            }
            return result;
        }

        public static string FormatData(string scatter, string DA, string auth, string preloader, string partition, string port)
        {
            string text = "";
            string result;
            if (mtkxml.isSupport(scatter))
            {
                string innerText = "";
                string innerText2 = "";
                List<mtkxml.mtk> list = mtkxml.ScatterTable(scatter);
                foreach (mtkxml.mtk mtk in list)
                {
                    if (mtk.PartitionName.ToLower() == partition)
                    {
                        innerText = mtk.StartAddress;
                        innerText2 = mtk.EndAddress;
                        string index = mtk.Index;
                        break;
                    }
                }
                XmlDocument xmlDocument = new XmlDocument();
                XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement xmlElement = xmlDocument.CreateElement("flashtool-config");
                xmlElement.SetAttribute("version", "2.0");
                XmlNode xmlNode = xmlDocument.CreateElement("general");
                XmlElement xmlElement2 = xmlDocument.CreateElement("chip-name");
                xmlElement2.InnerText = mtkxml.CPU;
                XmlElement xmlElement3 = xmlDocument.CreateElement("storage-type");
                xmlElement3.InnerText = mtkxml.CPUType;
                XmlElement xmlElement4 = xmlDocument.CreateElement("download-agent");
                xmlElement4.InnerText = DA;
                XmlElement xmlElement5 = xmlDocument.CreateElement("scatter");
                xmlElement5.InnerText = scatter;
                XmlElement xmlElement6 = xmlDocument.CreateElement("authentication");
                xmlElement6.InnerText = auth;
                XmlElement xmlElement7 = xmlDocument.CreateElement("certification");
                xmlElement7.InnerText = "";
                XmlNode xmlNode2 = xmlDocument.CreateElement("rom-list");
                XmlElement xmlElement8 = xmlDocument.CreateElement("rom");
                if (!string.IsNullOrEmpty(preloader))
                {
                    xmlElement8.SetAttribute("index", "0");
                    xmlElement8.SetAttribute("enable", "true");
                    xmlElement8.InnerText = preloader;
                }
                else
                {
                    xmlElement8.SetAttribute("index", "0");
                    xmlElement8.SetAttribute("enable", "false");
                }
                XmlElement xmlElement9 = xmlDocument.CreateElement("connection");
                xmlElement9.SetAttribute("type", port);
                xmlElement9.SetAttribute("high-speed", "true");
                xmlElement9.SetAttribute("power", "AutoDetect");
                xmlElement9.SetAttribute("da_log_level", "Info");
                xmlElement9.SetAttribute("da_log_channel", "UART");
                xmlElement9.SetAttribute("timeout-count", "120000");
                xmlElement9.SetAttribute("com-port", "");
                XmlNode xmlNode3 = xmlDocument.CreateElement("checksum-level");
                xmlNode3.InnerText = "none";
                XmlElement xmlElement10 = xmlDocument.CreateElement("log-info");
                xmlElement10.SetAttribute("log_on", "true");
                xmlElement10.SetAttribute("log_path", "C:\\ProgramData\\SP_FT_Logs");
                xmlElement10.SetAttribute("clean_hours", "24");
                xmlNode2.AppendChild(xmlElement8);
                xmlDocument.AppendChild(newChild);
                xmlDocument.AppendChild(xmlElement);
                xmlNode.AppendChild(xmlElement2);
                xmlNode.AppendChild(xmlElement3);
                xmlNode.AppendChild(xmlElement4);
                xmlNode.AppendChild(xmlElement5);
                xmlNode.AppendChild(xmlElement6);
                xmlNode.AppendChild(xmlElement7);
                xmlNode.AppendChild(xmlNode2);
                xmlNode.AppendChild(xmlElement9);
                xmlNode.AppendChild(xmlNode3);
                xmlNode.AppendChild(xmlElement10);
                XmlNode xmlNode4 = xmlDocument.CreateElement("commands");
                XmlElement xmlElement11 = xmlDocument.CreateElement("format");
                xmlElement11.SetAttribute("validation", "false");
                xmlElement11.SetAttribute("physical", "false");
                xmlElement11.SetAttribute("erase-flag", "NormalErase");
                xmlElement11.SetAttribute("auto-format", "false");
                XmlNode xmlNode5 = xmlDocument.CreateElement("begin-addr");
                xmlNode5.InnerText = innerText;
                XmlNode xmlNode6 = xmlDocument.CreateElement("length");
                xmlNode6.InnerText = innerText2;
                XmlNode xmlNode7 = xmlDocument.CreateElement("part-id");
                xmlNode7.InnerText = "8";
                xmlElement.AppendChild(xmlNode);
                xmlElement.AppendChild(xmlNode4);
                xmlNode4.AppendChild(xmlElement11);
                xmlElement11.AppendChild(xmlNode5);
                xmlElement11.AppendChild(xmlNode6);
                xmlElement11.AppendChild(xmlNode7);
                text = Path.Combine(Path.GetTempPath(), "config.xml");
                xmlDocument.Save(text);
                result = text;
            }
            else
            {
                result = text;
            }
            return result;
        }
    }
}