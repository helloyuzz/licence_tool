using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;

namespace CrackHardware
{
    public partial class Form_Crack : Form
    {
        CrackHardware crackHardware = null;
        public Form_Crack()
        {
            InitializeComponent();
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            tbx_ProjectId.Focus();
            //uC_CodeInput1.SetFocus();
        }
        private void Form_Crack_Load(object sender, EventArgs e)
        {
            uC_CodeInput1.Clear();
            loadConfig();
            toolTip1.SetToolTip(linkLabel1, "当服务器/硬件发生以下变化时，需重新获取授权码，包括：\r\n1.授权到期\r\n2.更换主板\r\n3.更换CPU\r\n4.更换硬盘\r\n5.更换/禁用/启用新网卡");
        }

        private void loadConfig()
        {
            crackHardware = new CrackHardware();
            tbx_BOISID.Clear();
            tbx_CPUID.Clear();
            tbx_DISK.Clear();
            tbx_MAC.Clear();
            pic_QRCode.Image = null;

            using (ManagementClass mc = new ManagementClass("Win32_Processor"))
            {
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    CPU cpu = new CPU();
                    cpu.Id= mo.Properties["ProcessorId"].Value.ToString();
                    cpu.Name = mo.Properties["Name"].Value.ToString();
                    cpu.Manufacturer= mo.Properties["Manufacturer"].Value.ToString().Replace("Genuine", "");

                    crackHardware.AllCPU.Add(cpu);

                    //Console.WriteLine(", wmi: {0}", tbx_CPUID.Text);
                    //foreach (PropertyData property in mo.Properties)
                    //{
                    //    try
                    //    {
                    //        Console.WriteLine("{0}={1}", property.Name, mo.Properties[property.Name].Value.ToString());
                    //    }
                    //    catch { continue; }
                    //}
                }
            }

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_BIOS"))
            {
                ManagementObjectCollection moc = searcher.Get();
                foreach (ManagementObject mo in moc)
                {
                    crackHardware.BOIS = mo.Properties["SerialNumber"].Value.ToString();
                }
            }
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_PhysicalMedia"))
            {
                ManagementObjectCollection moc = searcher.Get();
                foreach (ManagementObject mo in moc)
                {
                    crackHardware.AllDisk.Add(mo.Properties["SerialNumber"].Value.ToString());
                }
            }

            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NetworkAdapter");
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            {
                ManagementObjectCollection queryCollection = searcher.Get();
                foreach (ManagementObject m in queryCollection)
                {
                    object netCard = m["NetConnectionStatus"];
                    if (netCard == null) {
                        continue;
                    }
                    if (netCard.ToString().Equals("2") || true)
                    {
                        string maxaddress = m["MACAddress"].ToString();
                        crackHardware.AllNetCard.Add(maxaddress);
                    }
                }
            } 

            int showIndex = 1;
            this.Text = "劳吉克CSSD授权申请工具 v0.1 - " + crackHardware.FirstCPUName;
            tbx_BOISID.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(crackHardware.BOIS));
            foreach (CPU item in crackHardware.AllCPU) {
                if (string.IsNullOrEmpty(tbx_CPUID.Text) == false) {
                    tbx_CPUID.Text += "\r\n";
                }
                tbx_CPUID.Text = showIndex + "." + Convert.ToBase64String(Encoding.UTF8.GetBytes( item.Manufacturer + "_" +　item.Id));
                showIndex++;
            }

            showIndex = 1;
            foreach (string item in crackHardware.AllDisk) {
                if (string.IsNullOrEmpty(tbx_DISK.Text) == false) {
                    tbx_DISK.Text += "\r\n";
                }
                tbx_DISK.Text += showIndex + "." + Convert.ToBase64String(Encoding.UTF8.GetBytes(item));
                showIndex++;
            }
            showIndex = 1;
            foreach (string item in crackHardware.AllNetCard) {
                if (string.IsNullOrEmpty(tbx_MAC.Text) == false) {
                    tbx_MAC.Text += "\r\n";
                }
                tbx_MAC.Text += showIndex + "." + Convert.ToBase64String(Encoding.UTF8.GetBytes(item));
                showIndex++;
            }

            buildQRCode();
        }

        private void btn_Refresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadConfig();
        }

        private void buildQRCode()
        {
            QRCodeEncoder qRCodeEncoder = new QRCodeEncoder();
            String encoding = "aa";
            if (encoding == "Byte")
            {
                qRCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            }
            //else if (encoding == "AlphaNumeric")
            //{
            //    qRCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;
            //}
            //else if (encoding == "Numeric")
            //{
            //    qRCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC;
            //}

            int scale = 5;
            qRCodeEncoder.QRCodeScale = scale;

            int version = 0;
            qRCodeEncoder.QRCodeVersion = version;


            qRCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            qRCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;

            Image image;
            String data = "aa";
            string text = JsonConvert.SerializeObject(crackHardware).Replace("\"","");
            string b64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
            //image = qRCodeEncoder.Encode(data,Encoding.UTF8);            
            image = qRCodeEncoder.Encode(b64, Encoding.UTF8);
            pic_QRCode.Image = image;
            //pic_QRCode.Width = pic_QRCode.Height = 168;
        }

        private void btn_Validate_Click(object sender, EventArgs e)
        {
            tbx_RegDate.Text = "yyyy-MM-dd 00:01";
            tbx_ToDate.Text = "yyyy-MM-dd 23:59";
        }
    }
}
