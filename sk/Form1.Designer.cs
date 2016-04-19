namespace sk
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl_showtxt = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CoMBx_ServerPort = new System.Windows.Forms.ComboBox();
            this.CoMBx_ServerIp = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_senttoclient = new System.Windows.Forms.Button();
            this.TXT_showmsg = new System.Windows.Forms.TextBox();
            this.listViewmsg = new System.Windows.Forms.ListView();
            this.TXT_Sendmsg = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Btn_startserver = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label_showclientipport = new System.Windows.Forms.Label();
            this.textBoxshowclientmsg = new System.Windows.Forms.TextBox();
            this.listViewclientmsg = new System.Windows.Forms.ListView();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.TxT_ClientSendMsg = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Client_port = new System.Windows.Forms.ComboBox();
            this.Client_ip = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox_showsavetxt = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button8 = new System.Windows.Forms.Button();
            this.label_currentsendline = new System.Windows.Forms.Label();
            this.tb_singalsendsum = new System.Windows.Forms.TextBox();
            this.xhtml_lines = new System.Windows.Forms.Panel();
            this.textBox_fileshowmsg = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label_showselectclient = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.richTextBox_showclientmsg = new System.Windows.Forms.RichTextBox();
            this.tabControl_showtxt.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_showtxt
            // 
            this.tabControl_showtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_showtxt.Controls.Add(this.tabPage1);
            this.tabControl_showtxt.Controls.Add(this.tabPage2);
            this.tabControl_showtxt.Controls.Add(this.tabPage3);
            this.tabControl_showtxt.Controls.Add(this.tabPage4);
            this.tabControl_showtxt.Location = new System.Drawing.Point(-3, -2);
            this.tabControl_showtxt.Name = "tabControl_showtxt";
            this.tabControl_showtxt.SelectedIndex = 0;
            this.tabControl_showtxt.Size = new System.Drawing.Size(569, 556);
            this.tabControl_showtxt.TabIndex = 0;
            this.tabControl_showtxt.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CoMBx_ServerPort);
            this.tabPage1.Controls.Add(this.CoMBx_ServerIp);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Btn_senttoclient);
            this.tabPage1.Controls.Add(this.TXT_showmsg);
            this.tabPage1.Controls.Add(this.listViewmsg);
            this.tabPage1.Controls.Add(this.TXT_Sendmsg);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.Btn_startserver);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(561, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CoMBx_ServerPort
            // 
            this.CoMBx_ServerPort.FormattingEnabled = true;
            this.CoMBx_ServerPort.Location = new System.Drawing.Point(128, 11);
            this.CoMBx_ServerPort.Name = "CoMBx_ServerPort";
            this.CoMBx_ServerPort.Size = new System.Drawing.Size(59, 20);
            this.CoMBx_ServerPort.TabIndex = 9;
            this.CoMBx_ServerPort.Text = "25557";
            // 
            // CoMBx_ServerIp
            // 
            this.CoMBx_ServerIp.FormattingEnabled = true;
            this.CoMBx_ServerIp.Location = new System.Drawing.Point(11, 11);
            this.CoMBx_ServerIp.Name = "CoMBx_ServerIp";
            this.CoMBx_ServerIp.Size = new System.Drawing.Size(98, 20);
            this.CoMBx_ServerIp.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(463, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "copy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(514, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "clr";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Btn_senttoclient
            // 
            this.Btn_senttoclient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_senttoclient.Location = new System.Drawing.Point(344, 40);
            this.Btn_senttoclient.Name = "Btn_senttoclient";
            this.Btn_senttoclient.Size = new System.Drawing.Size(66, 60);
            this.Btn_senttoclient.TabIndex = 5;
            this.Btn_senttoclient.Text = "发送";
            this.Btn_senttoclient.UseVisualStyleBackColor = true;
            this.Btn_senttoclient.Click += new System.EventHandler(this.Btn_senttoclient_Click);
            // 
            // TXT_showmsg
            // 
            this.TXT_showmsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_showmsg.Location = new System.Drawing.Point(7, 178);
            this.TXT_showmsg.Multiline = true;
            this.TXT_showmsg.Name = "TXT_showmsg";
            this.TXT_showmsg.ReadOnly = true;
            this.TXT_showmsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_showmsg.Size = new System.Drawing.Size(404, 74);
            this.TXT_showmsg.TabIndex = 4;
            // 
            // listViewmsg
            // 
            this.listViewmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewmsg.Location = new System.Drawing.Point(6, 261);
            this.listViewmsg.Name = "listViewmsg";
            this.listViewmsg.Size = new System.Drawing.Size(547, 272);
            this.listViewmsg.TabIndex = 3;
            this.listViewmsg.UseCompatibleStateImageBehavior = false;
            this.listViewmsg.View = System.Windows.Forms.View.Details;
            this.listViewmsg.DoubleClick += new System.EventHandler(this.listViewmsg_DoubleClick);
            this.listViewmsg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewmsg_MouseClick);
            // 
            // TXT_Sendmsg
            // 
            this.TXT_Sendmsg.AcceptsReturn = true;
            this.TXT_Sendmsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Sendmsg.Location = new System.Drawing.Point(6, 40);
            this.TXT_Sendmsg.Multiline = true;
            this.TXT_Sendmsg.Name = "TXT_Sendmsg";
            this.TXT_Sendmsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_Sendmsg.Size = new System.Drawing.Size(321, 132);
            this.TXT_Sendmsg.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(419, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(138, 181);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // Btn_startserver
            // 
            this.Btn_startserver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_startserver.Location = new System.Drawing.Point(344, 6);
            this.Btn_startserver.Name = "Btn_startserver";
            this.Btn_startserver.Size = new System.Drawing.Size(66, 28);
            this.Btn_startserver.TabIndex = 0;
            this.Btn_startserver.Text = "开始";
            this.Btn_startserver.UseVisualStyleBackColor = true;
            this.Btn_startserver.Click += new System.EventHandler(this.Btn_startserver_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox_showclientmsg);
            this.tabPage2.Controls.Add(this.label_showclientipport);
            this.tabPage2.Controls.Add(this.textBoxshowclientmsg);
            this.tabPage2.Controls.Add(this.listViewclientmsg);
            this.tabPage2.Controls.Add(this.comboBox4);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.TxT_ClientSendMsg);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.Client_port);
            this.tabPage2.Controls.Add(this.Client_ip);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(561, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label_showclientipport
            // 
            this.label_showclientipport.AutoSize = true;
            this.label_showclientipport.Location = new System.Drawing.Point(412, 36);
            this.label_showclientipport.Name = "label_showclientipport";
            this.label_showclientipport.Size = new System.Drawing.Size(41, 12);
            this.label_showclientipport.TabIndex = 9;
            this.label_showclientipport.Text = "label1";
            // 
            // textBoxshowclientmsg
            // 
            this.textBoxshowclientmsg.Location = new System.Drawing.Point(8, 193);
            this.textBoxshowclientmsg.Multiline = true;
            this.textBoxshowclientmsg.Name = "textBoxshowclientmsg";
            this.textBoxshowclientmsg.ReadOnly = true;
            this.textBoxshowclientmsg.Size = new System.Drawing.Size(541, 126);
            this.textBoxshowclientmsg.TabIndex = 8;
            // 
            // listViewclientmsg
            // 
            this.listViewclientmsg.Location = new System.Drawing.Point(6, 331);
            this.listViewclientmsg.Name = "listViewclientmsg";
            this.listViewclientmsg.Size = new System.Drawing.Size(547, 29);
            this.listViewclientmsg.TabIndex = 7;
            this.listViewclientmsg.UseCompatibleStateImageBehavior = false;
            this.listViewclientmsg.View = System.Windows.Forms.View.Details;
            this.listViewclientmsg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewclientmsg_MouseClick);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(478, 101);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(72, 20);
            this.comboBox4.TabIndex = 6;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(478, 65);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(72, 20);
            this.comboBox3.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(478, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "发送";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TxT_ClientSendMsg
            // 
            this.TxT_ClientSendMsg.Location = new System.Drawing.Point(6, 65);
            this.TxT_ClientSendMsg.Multiline = true;
            this.TxT_ClientSendMsg.Name = "TxT_ClientSendMsg";
            this.TxT_ClientSendMsg.Size = new System.Drawing.Size(457, 112);
            this.TxT_ClientSendMsg.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(316, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "连接";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Client_port
            // 
            this.Client_port.FormattingEnabled = true;
            this.Client_port.Location = new System.Drawing.Point(165, 19);
            this.Client_port.Name = "Client_port";
            this.Client_port.Size = new System.Drawing.Size(121, 20);
            this.Client_port.TabIndex = 1;
            this.Client_port.Text = "25557";
            // 
            // Client_ip
            // 
            this.Client_ip.FormattingEnabled = true;
            this.Client_ip.Location = new System.Drawing.Point(25, 19);
            this.Client_ip.Name = "Client_ip";
            this.Client_ip.Size = new System.Drawing.Size(121, 20);
            this.Client_ip.TabIndex = 0;
            this.Client_ip.Text = "127.0.0.1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox_showsavetxt);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(561, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "savetxt";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox_showsavetxt
            // 
            this.textBox_showsavetxt.Location = new System.Drawing.Point(0, 3);
            this.textBox_showsavetxt.Multiline = true;
            this.textBox_showsavetxt.Name = "textBox_showsavetxt";
            this.textBox_showsavetxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_showsavetxt.Size = new System.Drawing.Size(553, 521);
            this.textBox_showsavetxt.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.progressBar1);
            this.tabPage4.Controls.Add(this.button8);
            this.tabPage4.Controls.Add(this.label_currentsendline);
            this.tabPage4.Controls.Add(this.tb_singalsendsum);
            this.tabPage4.Controls.Add(this.xhtml_lines);
            this.tabPage4.Controls.Add(this.textBox_fileshowmsg);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.label_showselectclient);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.richTextBox1);
            this.tabPage4.Controls.Add(this.radioButton2);
            this.tabPage4.Controls.Add(this.radioButton1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(561, 530);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Sendbyfile";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(453, 360);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 15);
            this.progressBar1.TabIndex = 14;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DimGray;
            this.button8.Location = new System.Drawing.Point(405, 455);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 13;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label_currentsendline
            // 
            this.label_currentsendline.AutoSize = true;
            this.label_currentsendline.Location = new System.Drawing.Point(331, 371);
            this.label_currentsendline.Name = "label_currentsendline";
            this.label_currentsendline.Size = new System.Drawing.Size(41, 12);
            this.label_currentsendline.TabIndex = 12;
            this.label_currentsendline.Text = "label1";
            // 
            // tb_singalsendsum
            // 
            this.tb_singalsendsum.Location = new System.Drawing.Point(331, 405);
            this.tb_singalsendsum.Name = "tb_singalsendsum";
            this.tb_singalsendsum.Size = new System.Drawing.Size(100, 21);
            this.tb_singalsendsum.TabIndex = 11;
            this.tb_singalsendsum.Text = "1";
            // 
            // xhtml_lines
            // 
            this.xhtml_lines.Location = new System.Drawing.Point(3, 2);
            this.xhtml_lines.Name = "xhtml_lines";
            this.xhtml_lines.Size = new System.Drawing.Size(34, 193);
            this.xhtml_lines.TabIndex = 10;
            this.xhtml_lines.Paint += new System.Windows.Forms.PaintEventHandler(this.xhtml_lines_Paint);
            // 
            // textBox_fileshowmsg
            // 
            this.textBox_fileshowmsg.Location = new System.Drawing.Point(7, 219);
            this.textBox_fileshowmsg.Multiline = true;
            this.textBox_fileshowmsg.Name = "textBox_fileshowmsg";
            this.textBox_fileshowmsg.ReadOnly = true;
            this.textBox_fileshowmsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_fileshowmsg.Size = new System.Drawing.Size(415, 134);
            this.textBox_fileshowmsg.TabIndex = 9;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(461, 330);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "全部发送";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(461, 403);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "单步发送";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label_showselectclient
            // 
            this.label_showselectclient.AutoSize = true;
            this.label_showselectclient.Location = new System.Drawing.Point(440, 223);
            this.label_showselectclient.Name = "label_showselectclient";
            this.label_showselectclient.Size = new System.Drawing.Size(41, 12);
            this.label_showselectclient.TabIndex = 6;
            this.label_showselectclient.Text = "label1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(461, 284);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 27);
            this.button5.TabIndex = 5;
            this.button5.Text = "选择发送";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(36, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox1.Size = new System.Drawing.Size(525, 213);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "abc abc\ndasfa vdasfdsa dsafdasfadsf\nabc abc dafbdaf\nafdasfads abc affas abc";
            this.richTextBox1.WordWrap = false;
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.VScroll += new System.EventHandler(this.richTextBox1_VScroll);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(494, 250);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 16);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "客户端";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(433, 250);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "服务端";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // richTextBox_showclientmsg
            // 
            this.richTextBox_showclientmsg.Location = new System.Drawing.Point(12, 367);
            this.richTextBox_showclientmsg.Name = "richTextBox_showclientmsg";
            this.richTextBox_showclientmsg.ReadOnly = true;
            this.richTextBox_showclientmsg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox_showclientmsg.Size = new System.Drawing.Size(538, 157);
            this.richTextBox_showclientmsg.TabIndex = 10;
            this.richTextBox_showclientmsg.Text = "";
            this.richTextBox_showclientmsg.WordWrap = false;
            this.richTextBox_showclientmsg.Click += new System.EventHandler(this.richTextBox_showclientmsg_Click);
            this.richTextBox_showclientmsg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox_showclientmsg_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 556);
            this.Controls.Add(this.tabControl_showtxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl_showtxt.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_showtxt;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btn_startserver;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Btn_senttoclient;
        private System.Windows.Forms.TextBox TXT_showmsg;
        private System.Windows.Forms.ListView listViewmsg;
        private System.Windows.Forms.TextBox TXT_Sendmsg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox Client_port;
        private System.Windows.Forms.ComboBox Client_ip;
        private System.Windows.Forms.TextBox textBoxshowclientmsg;
        private System.Windows.Forms.ListView listViewclientmsg;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox TxT_ClientSendMsg;
        private System.Windows.Forms.Label label_showclientipport;
        private System.Windows.Forms.ComboBox CoMBx_ServerPort;
        private System.Windows.Forms.ComboBox CoMBx_ServerIp;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox_showsavetxt;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label_showselectclient;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox_fileshowmsg;
        private System.Windows.Forms.Panel xhtml_lines;
        private System.Windows.Forms.TextBox tb_singalsendsum;
        private System.Windows.Forms.Label label_currentsendline;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox richTextBox_showclientmsg;
    }
}

