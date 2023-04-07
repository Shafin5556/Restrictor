using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restrictor.UI
{
    public partial class WebBlock : UserControl
    {
        public string Hosts_Path = "C:\\Windows\\System32\\drivers\\etc\\hosts";
        public string Save_Path = "C:\\ProgramData\\Restrictor";
        public string Save_WebBlock = "C:\\ProgramData\\Restrictor\\WebBlock";
        public string Url1 = "C:\\ProgramData\\Restrictor\\WebBlock\\Url1";
        public string Url2 = "C:\\ProgramData\\Restrictor\\WebBlock\\Url2";
        public string Url3 = "C:\\ProgramData\\Restrictor\\WebBlock\\Url3";
        public string Url4 = "C:\\ProgramData\\Restrictor\\WebBlock\\Url4";
        public string Url5 = "C:\\ProgramData\\Restrictor\\WebBlock\\Url5";
        public string Url6 = "C:\\ProgramData\\Restrictor\\WebBlock\\Url6";
        public string Url7 = "C:\\ProgramData\\Restrictor\\WebBlock\\Url7";
        public string Url8 = "C:\\ProgramData\\Restrictor\\WebBlock\\Url8";
        public string Url9 = "C:\\ProgramData\\Restrictor\\WebBlock\\Url9";
        public string Url10 = "C:\\ProgramData\\Restrictor\\WebBlock\\Url10";
        public string Url11 = "C:\\ProgramData\\Restrictor\\WebBlock\\Url11";
        public string Url12 = "C:\\ProgramData\\Restrictor\\WebBlock\\Url12";
        public string Url13 = "C:\\ProgramData\\Restrictor\\WebBlock\\Url13";
        public string Url14 = "C:\\ProgramData\\Restrictor\\WebBlock\\Url14";
        public string Url15 = "C:\\ProgramData\\Restrictor\\WebBlock\\Url15";
        private static WebBlock _instance;
        public static WebBlock Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new WebBlock();
                return _instance;
            }
        }
        public WebBlock()
        {
            InitializeComponent();
        }

        private void WebBlock_Load(object sender, EventArgs e)
        {

        }

        private void normal()
        {
            if (!Directory.Exists(Save_Path))
            {
                Directory.CreateDirectory(Save_Path);
            }
            if (!Directory.Exists(Save_WebBlock))
            {
                Directory.CreateDirectory(Save_WebBlock);
            }
            if (File.Exists(Url1))
            {
                url_1.Text = File.ReadAllText(Url1);
            }
            if (File.Exists(Url2))
            {
                url_2.Text = File.ReadAllText(Url2);
            }
            if (File.Exists(Url3))
            {
                url_3.Text = File.ReadAllText(Url3);
            }
            if (File.Exists(Url4))
            {
                url_4.Text = File.ReadAllText(Url4);
            }
            if (File.Exists(Url5))
            {
                url_5.Text = File.ReadAllText(Url5);
            }
            if (File.Exists(Url6))
            {
                url_6.Text = File.ReadAllText(Url6);
            }
            if (File.Exists(Url7))
            {
                url_7.Text = File.ReadAllText(Url7);
            }
            if (File.Exists(Url8))
            {
                url_8.Text = File.ReadAllText(Url8);
            }
            if (File.Exists(Url9))
            {
                url_9.Text = File.ReadAllText(Url9);
            }
            if (File.Exists(Url10))
            {
                url_10.Text = File.ReadAllText(Url10);
            }
            if (File.Exists(Url11))
            {
                url_11.Text = File.ReadAllText(Url11);
            }
            if (File.Exists(Url12))
            {
                url_12.Text = File.ReadAllText(Url12);
            }
            if (File.Exists(Url13))
            {
                url_13.Text = File.ReadAllText(Url13);
            }
            if (File.Exists(Url14))
            {
                url_14.Text = File.ReadAllText(Url14);
            }
            if (File.Exists(Url15))
            {
                url_15.Text = File.ReadAllText(Url15);
            }
        }


        private void check()
        {
            if (url_1.Text.Contains("www") || url_1.Text.Contains("com"))
            {
                guna2ToggleSwitch1.Checked = true;
            }
            if (url_2.Text.Contains("www") || url_2.Text.Contains("com"))
            {
                guna2ToggleSwitch2.Checked = true;
            }
            if (url_3.Text.Contains("www") || url_3.Text.Contains("com"))
            {
                guna2ToggleSwitch3.Checked = true;
            }
            if (url_4.Text.Contains("www") || url_4.Text.Contains("com"))
            {
                guna2ToggleSwitch4.Checked = true;
            }
            if (url_5.Text.Contains("www") || url_5.Text.Contains("com"))
            {
                guna2ToggleSwitch5.Checked = true;
            }
            if (url_6.Text.Contains("www") || url_6.Text.Contains("com"))
            {
                guna2ToggleSwitch6.Checked = true;
            }
            if (url_7.Text.Contains("www") || url_7.Text.Contains("com"))
            {
                guna2ToggleSwitch7.Checked = true;
            }
            if (url_8.Text.Contains("www") || url_8.Text.Contains("com"))
            {
                guna2ToggleSwitch8.Checked = true;
            }
            if (url_9.Text.Contains("www") || url_9.Text.Contains("com"))
            {
                guna2ToggleSwitch9.Checked = true;
            }
            if (url_10.Text.Contains("www") || url_10.Text.Contains("com"))
            {
                guna2ToggleSwitch10.Checked = true;
            }
            if (url_11.Text.Contains("www") || url_11.Text.Contains("com"))
            {
                guna2ToggleSwitch11.Checked = true;
            }
            if (url_12.Text.Contains("www") || url_12.Text.Contains("com"))
            {
                guna2ToggleSwitch12.Checked = true;
            }
            if (url_13.Text.Contains("www") || url_13.Text.Contains("com"))
            {
                guna2ToggleSwitch13.Checked = true;
            }
            if (url_14.Text.Contains("www") || url_14.Text.Contains("com"))
            {
                guna2ToggleSwitch14.Checked = true;
            }
            if (url_15.Text.Contains("www") || url_15.Text.Contains("com"))
            {
                guna2ToggleSwitch15.Checked = true;
            }
        }
        private void url_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            File.WriteAllText(Path.Combine(Hosts_Path), Environment.NewLine + "127.0.0.1 " + url_1.Text
              + Environment.NewLine + "127.0.0.1 " + url_2.Text
              + Environment.NewLine + "127.0.0.1 " + url_3.Text
              + Environment.NewLine + "127.0.0.1 " + url_4.Text
              + Environment.NewLine + "127.0.0.1 " + url_5.Text
              + Environment.NewLine + "127.0.0.1 " + url_6.Text
              + Environment.NewLine + "127.0.0.1 " + url_7.Text
              + Environment.NewLine + "127.0.0.1 " + url_8.Text
              + Environment.NewLine + "127.0.0.1 " + url_9.Text
              + Environment.NewLine + "127.0.0.1 " + url_10.Text
              + Environment.NewLine + "127.0.0.1 " + url_11.Text
              + Environment.NewLine + "127.0.0.1 " + url_12.Text
              + Environment.NewLine + "127.0.0.1 " + url_13.Text
              + Environment.NewLine + "127.0.0.1 " + url_14.Text
              + Environment.NewLine + "127.0.0.1 " + url_15.Text);
            if (!guna2ToggleSwitch1.Checked)
            {
                url_1.Clear();
                File.WriteAllText(Path.Combine(Hosts_Path), Environment.NewLine + "127.0.0.1 " + url_1.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_2.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_3.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_4.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_5.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_6.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_7.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_8.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_9.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_10.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_11.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_12.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_13.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_14.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_15.Text);
            }
            if (!guna2ToggleSwitch2.Checked)
            {
                url_2.Clear();
                File.WriteAllText(Path.Combine(Hosts_Path), Environment.NewLine + "127.0.0.1 " + url_1.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_2.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_3.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_4.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_5.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_6.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_7.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_8.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_9.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_10.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_11.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_12.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_13.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_14.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_15.Text);
            }
            if (!guna2ToggleSwitch3.Checked)
            {
                url_3.Clear();
                File.WriteAllText(Path.Combine(Hosts_Path), Environment.NewLine + "127.0.0.1 " + url_1.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_2.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_3.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_4.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_5.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_6.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_7.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_8.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_9.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_10.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_11.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_12.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_13.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_14.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_15.Text);
            }
            if (!guna2ToggleSwitch4.Checked)
            {
                url_4.Clear();
                File.WriteAllText(Path.Combine(Hosts_Path), Environment.NewLine + "127.0.0.1 " + url_1.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_2.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_3.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_4.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_5.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_6.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_7.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_8.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_9.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_10.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_11.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_12.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_13.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_14.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_15.Text);
            }
            if (!guna2ToggleSwitch5.Checked)
            {
                url_5.Clear();
                File.WriteAllText(Path.Combine(Hosts_Path), Environment.NewLine + "127.0.0.1 " + url_1.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_2.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_3.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_4.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_5.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_6.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_7.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_8.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_9.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_10.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_11.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_12.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_13.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_14.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_15.Text);
            }
            if (!guna2ToggleSwitch6.Checked)
            {
                url_6.Clear();
                File.WriteAllText(Path.Combine(Hosts_Path), Environment.NewLine + "127.0.0.1 " + url_1.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_2.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_3.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_4.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_5.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_6.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_7.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_8.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_9.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_10.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_11.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_12.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_13.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_14.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_15.Text);
            }
            if (!guna2ToggleSwitch7.Checked)
            {
                url_7.Clear();
                File.WriteAllText(Path.Combine(Hosts_Path), Environment.NewLine + "127.0.0.1 " + url_1.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_2.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_3.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_4.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_5.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_6.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_7.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_8.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_9.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_10.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_11.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_12.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_13.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_14.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_15.Text);
            }
            if (!guna2ToggleSwitch8.Checked)
            {
                url_8.Clear();
                File.WriteAllText(Path.Combine(Hosts_Path), Environment.NewLine + "127.0.0.1 " + url_1.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_2.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_3.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_4.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_5.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_6.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_7.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_8.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_9.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_10.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_11.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_12.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_13.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_14.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_15.Text);
            }
            if (!guna2ToggleSwitch9.Checked)
            {
                url_9.Clear();
                File.WriteAllText(Path.Combine(Hosts_Path), Environment.NewLine + "127.0.0.1 " + url_1.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_2.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_3.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_4.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_5.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_6.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_7.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_8.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_9.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_10.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_11.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_12.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_13.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_14.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_15.Text);
            }
            if (!guna2ToggleSwitch10.Checked)
            {
                url_10.Clear();
                File.WriteAllText(Path.Combine(Hosts_Path), Environment.NewLine + "127.0.0.1 " + url_1.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_2.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_3.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_4.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_5.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_6.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_7.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_8.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_9.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_10.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_11.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_12.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_13.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_14.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_15.Text);
            }
            if (!guna2ToggleSwitch11.Checked)
            {
                url_11.Clear();
                File.WriteAllText(Path.Combine(Hosts_Path), Environment.NewLine + "127.0.0.1 " + url_1.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_2.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_3.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_4.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_5.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_6.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_7.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_8.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_9.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_10.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_11.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_12.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_13.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_14.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_15.Text);
            }
            if (!guna2ToggleSwitch12.Checked)
            {
                url_12.Clear();
                File.WriteAllText(Path.Combine(Hosts_Path), Environment.NewLine + "127.0.0.1 " + url_1.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_2.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_3.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_4.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_5.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_6.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_7.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_8.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_9.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_10.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_11.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_12.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_13.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_14.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_15.Text);
            }
            if (!guna2ToggleSwitch13.Checked)
            {
                url_13.Clear();
                File.WriteAllText(Path.Combine(Hosts_Path), Environment.NewLine + "127.0.0.1 " + url_1.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_2.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_3.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_4.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_5.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_6.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_7.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_8.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_9.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_10.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_11.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_12.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_13.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_14.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_15.Text);
            }
            if (!guna2ToggleSwitch14.Checked)
            {

                url_14.Clear();
                File.WriteAllText(Path.Combine(Hosts_Path), Environment.NewLine + "127.0.0.1 " + url_1.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_2.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_3.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_4.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_5.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_6.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_7.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_8.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_9.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_10.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_11.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_12.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_13.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_14.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_15.Text);
            }
            if (!guna2ToggleSwitch15.Checked)
            {

                url_15.Clear();
                File.WriteAllText(Path.Combine(Hosts_Path), Environment.NewLine + "127.0.0.1 " + url_1.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_2.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_3.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_4.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_5.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_6.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_7.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_8.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_9.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_10.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_11.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_12.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_13.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_14.Text
                                          + Environment.NewLine + "127.0.0.1 " + url_15.Text);
            }
        }

        private void url_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void url_3_TextChanged(object sender, EventArgs e)
        {

        }

        private void url_4_TextChanged(object sender, EventArgs e)
        {

        }

        private void url_5_TextChanged(object sender, EventArgs e)
        {

        }

        private void url_6_TextChanged(object sender, EventArgs e)
        {

        }

        private void url_7_TextChanged(object sender, EventArgs e)
        {

        }

        private void url_8_TextChanged(object sender, EventArgs e)
        {

        }

        private void url_9_TextChanged(object sender, EventArgs e)
        {

        }

        private void url_10_TextChanged(object sender, EventArgs e)
        {

        }

        private void url_11_TextChanged(object sender, EventArgs e)
        {

        }

        private void url_12_TextChanged(object sender, EventArgs e)
        {

        }

        private void url_13_TextChanged(object sender, EventArgs e)
        {

        }

        private void url_14_TextChanged(object sender, EventArgs e)
        {

        }

        private void url_15_TextChanged(object sender, EventArgs e)
        {

        }


        private async void timer1_Tick(object sender, EventArgs e)
        {
            File.WriteAllText(Path.Combine(Hosts_Path), Environment.NewLine + "127.0.0.1 " + url_1.Text
                          + Environment.NewLine + "127.0.0.1 " + url_2.Text
                          + Environment.NewLine + "127.0.0.1 " + url_3.Text
                          + Environment.NewLine + "127.0.0.1 " + url_4.Text
                          + Environment.NewLine + "127.0.0.1 " + url_5.Text
                          + Environment.NewLine + "127.0.0.1 " + url_6.Text
                          + Environment.NewLine + "127.0.0.1 " + url_7.Text
                          + Environment.NewLine + "127.0.0.1 " + url_8.Text
                          + Environment.NewLine + "127.0.0.1 " + url_9.Text
                          + Environment.NewLine + "127.0.0.1 " + url_10.Text
                          + Environment.NewLine + "127.0.0.1 " + url_11.Text
                          + Environment.NewLine + "127.0.0.1 " + url_12.Text
                          + Environment.NewLine + "127.0.0.1 " + url_13.Text
                          + Environment.NewLine + "127.0.0.1 " + url_14.Text
                          + Environment.NewLine + "127.0.0.1 " + url_15.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private async void timer2_Tick(object sender, EventArgs e)
        {
            File.WriteAllText(Path.Combine(Url1), url_1.Text);
            File.WriteAllText(Path.Combine(Url2), url_2.Text);
            File.WriteAllText(Path.Combine(Url3), url_3.Text);
            File.WriteAllText(Path.Combine(Url4), url_4.Text);
            File.WriteAllText(Path.Combine(Url5), url_5.Text);
            File.WriteAllText(Path.Combine(Url6), url_6.Text);
            File.WriteAllText(Path.Combine(Url7), url_7.Text);
            File.WriteAllText(Path.Combine(Url8), url_8.Text);
            File.WriteAllText(Path.Combine(Url9), url_9.Text);
            File.WriteAllText(Path.Combine(Url10), url_10.Text);
            File.WriteAllText(Path.Combine(Url11), url_11.Text);
            File.WriteAllText(Path.Combine(Url12), url_12.Text);
            File.WriteAllText(Path.Combine(Url13), url_13.Text);
            File.WriteAllText(Path.Combine(Url14), url_14.Text);
            File.WriteAllText(Path.Combine(Url15), url_15.Text);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void url_1_Click(object sender, EventArgs e)
        {

        }

        private void url_1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string line = null;
            string line_to_delete = "3";

            using (StreamReader reader = new StreamReader("C:\\Windows\\System32\\drivers\\etc\\hosts"))
            {
                using (StreamWriter writer = new StreamWriter("C:\\Windows\\System32\\drivers\\etc\\hosts"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (String.Compare(line, line_to_delete) == 0)
                            continue;

                        writer.WriteLine(line);
                    }
                }
            }
        }
    }
}
