namespace CrackHardware
{
    partial class Form_Crack
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Crack));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_CPUID = new System.Windows.Forms.TextBox();
            this.tbx_BOISID = new System.Windows.Forms.TextBox();
            this.tbx_DISK = new System.Windows.Forms.TextBox();
            this.tbx_MAC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Crack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Refresh = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_RegDate = new System.Windows.Forms.Label();
            this.tbx_ToDate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbx_ProjectId = new System.Windows.Forms.TextBox();
            this.btn_Validate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pic_QRCode = new System.Windows.Forms.PictureBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.uC_CodeInput1 = new UC_CodeInput();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_QRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "处理器序列号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "BIOS序列号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "硬盘序列号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "网卡MAC地址：";
            // 
            // tbx_CPUID
            // 
            this.tbx_CPUID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_CPUID.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_CPUID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_CPUID.Location = new System.Drawing.Point(131, 117);
            this.tbx_CPUID.Multiline = true;
            this.tbx_CPUID.Name = "tbx_CPUID";
            this.tbx_CPUID.ReadOnly = true;
            this.tbx_CPUID.Size = new System.Drawing.Size(344, 48);
            this.tbx_CPUID.TabIndex = 1;
            // 
            // tbx_BOISID
            // 
            this.tbx_BOISID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_BOISID.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_BOISID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_BOISID.Location = new System.Drawing.Point(131, 172);
            this.tbx_BOISID.Multiline = true;
            this.tbx_BOISID.Name = "tbx_BOISID";
            this.tbx_BOISID.ReadOnly = true;
            this.tbx_BOISID.Size = new System.Drawing.Size(344, 48);
            this.tbx_BOISID.TabIndex = 2;
            // 
            // tbx_DISK
            // 
            this.tbx_DISK.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_DISK.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_DISK.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_DISK.Location = new System.Drawing.Point(131, 226);
            this.tbx_DISK.Multiline = true;
            this.tbx_DISK.Name = "tbx_DISK";
            this.tbx_DISK.ReadOnly = true;
            this.tbx_DISK.Size = new System.Drawing.Size(344, 48);
            this.tbx_DISK.TabIndex = 3;
            // 
            // tbx_MAC
            // 
            this.tbx_MAC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_MAC.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_MAC.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_MAC.Location = new System.Drawing.Point(131, 279);
            this.tbx_MAC.Multiline = true;
            this.tbx_MAC.Name = "tbx_MAC";
            this.tbx_MAC.ReadOnly = true;
            this.tbx_MAC.Size = new System.Drawing.Size(344, 86);
            this.tbx_MAC.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "请输入注册码：";
            // 
            // btn_Crack
            // 
            this.btn_Crack.Location = new System.Drawing.Point(63, 494);
            this.btn_Crack.Name = "btn_Crack";
            this.btn_Crack.Size = new System.Drawing.Size(106, 37);
            this.btn_Crack.TabIndex = 6;
            this.btn_Crack.Text = "注册";
            this.btn_Crack.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(626, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "（请使用劳吉克微信小程序扫码二维码获取）";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 551);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(945, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(694, 17);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = " ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Underline);
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(153, 17);
            this.toolStripStatusLabel2.Text = "http://www.logichealth.cn";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.AutoSize = true;
            this.btn_Refresh.Location = new System.Drawing.Point(728, 397);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(41, 12);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.TabStop = true;
            this.btn_Refresh.Text = "[刷新]";
            this.btn_Refresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_Refresh_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(362, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "注册日期：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(363, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "授权有效期：";
            // 
            // tbx_RegDate
            // 
            this.tbx_RegDate.AutoSize = true;
            this.tbx_RegDate.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_RegDate.ForeColor = System.Drawing.Color.Teal;
            this.tbx_RegDate.Location = new System.Drawing.Point(455, 499);
            this.tbx_RegDate.Name = "tbx_RegDate";
            this.tbx_RegDate.Size = new System.Drawing.Size(37, 15);
            this.tbx_RegDate.TabIndex = 16;
            this.tbx_RegDate.Text = "未知";
            // 
            // tbx_ToDate
            // 
            this.tbx_ToDate.AutoSize = true;
            this.tbx_ToDate.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_ToDate.ForeColor = System.Drawing.Color.Teal;
            this.tbx_ToDate.Location = new System.Drawing.Point(455, 522);
            this.tbx_ToDate.Name = "tbx_ToDate";
            this.tbx_ToDate.Size = new System.Drawing.Size(37, 15);
            this.tbx_ToDate.TabIndex = 17;
            this.tbx_ToDate.Text = "未知";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "唯一业务编号：";
            // 
            // tbx_ProjectId
            // 
            this.tbx_ProjectId.BackColor = System.Drawing.SystemColors.Window;
            this.tbx_ProjectId.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_ProjectId.Location = new System.Drawing.Point(131, 35);
            this.tbx_ProjectId.Name = "tbx_ProjectId";
            this.tbx_ProjectId.Size = new System.Drawing.Size(344, 24);
            this.tbx_ProjectId.TabIndex = 0;
            // 
            // btn_Validate
            // 
            this.btn_Validate.Location = new System.Drawing.Point(804, 494);
            this.btn_Validate.Name = "btn_Validate";
            this.btn_Validate.Size = new System.Drawing.Size(75, 23);
            this.btn_Validate.TabIndex = 7;
            this.btn_Validate.Text = "校验";
            this.btn_Validate.UseVisualStyleBackColor = true;
            this.btn_Validate.Click += new System.EventHandler(this.btn_Validate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pic_QRCode);
            this.panel1.Location = new System.Drawing.Point(574, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 326);
            this.panel1.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(159, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(269, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "（微信小程序中查看唯一医院编码，并填写此处）";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 15000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip1.ToolTipTitle = "注意";
            // 
            // pic_QRCode
            // 
            this.pic_QRCode.BackColor = System.Drawing.Color.White;
            this.pic_QRCode.Location = new System.Drawing.Point(10, 8);
            this.pic_QRCode.Name = "pic_QRCode";
            this.pic_QRCode.Size = new System.Drawing.Size(305, 305);
            this.pic_QRCode.TabIndex = 8;
            this.pic_QRCode.TabStop = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = global::CrackHardware.Properties.Resources.UnversionedIcon;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabel1.Text = "Build: v0.1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel1.ImageIndex = 0;
            this.linkLabel1.ImageList = this.imageList1;
            this.linkLabel1.Location = new System.Drawing.Point(129, 410);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 23);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "授权提示";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "messageboxalert.ico");
            // 
            // uC_CodeInput1
            // 
            this.uC_CodeInput1.Location = new System.Drawing.Point(60, 445);
            this.uC_CodeInput1.Name = "uC_CodeInput1";
            this.uC_CodeInput1.Size = new System.Drawing.Size(844, 34);
            this.uC_CodeInput1.TabIndex = 5;
            // 
            // Form_Crack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 573);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Validate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbx_ToDate);
            this.Controls.Add(this.tbx_RegDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uC_CodeInput1);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Crack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_MAC);
            this.Controls.Add(this.tbx_DISK);
            this.Controls.Add(this.tbx_BOISID);
            this.Controls.Add(this.tbx_ProjectId);
            this.Controls.Add(this.tbx_CPUID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form_Crack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "劳吉克CSSD授权申请工具 v0.1";
            this.Load += new System.EventHandler(this.Form_Crack_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_QRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_CPUID;
        private System.Windows.Forms.TextBox tbx_BOISID;
        private System.Windows.Forms.TextBox tbx_DISK;
        private System.Windows.Forms.TextBox tbx_MAC;
        private System.Windows.Forms.PictureBox pic_QRCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Crack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.LinkLabel btn_Refresh;
        private UC_CodeInput uC_CodeInput1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label tbx_RegDate;
        private System.Windows.Forms.Label tbx_ToDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbx_ProjectId;
        private System.Windows.Forms.Button btn_Validate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

