using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sk.TcpServer;
using sk.Client;
using sk.Tool;
using System.Collections;
using System.Threading;

namespace sk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.listView1.Columns.Add("列标题1", 120, HorizontalAlignment.Left);
            this.listView1.GridLines = true;
            this.listView1.FullRowSelect = true;

            //listViewmsg
            listViewmsg.Columns.Add("时间", 120, HorizontalAlignment.Right);
            listViewmsg.Columns.Add("内容", 1888, HorizontalAlignment.Left);
            this.listViewmsg.GridLines = true;
            this.listViewmsg.FullRowSelect = true;

            listViewclientmsg.Columns.Add("时间", 120, HorizontalAlignment.Right);
            listViewclientmsg.Columns.Add("内容", 2200, HorizontalAlignment.Left);
            this.listViewclientmsg.GridLines = true;
            this.listViewclientmsg.FullRowSelect = true;
            listViewclientmsg.Items.Add(new ListViewItem(new string[] { "12-12-1", "1111111111111111111111111111122222222222222222222333333333333333333334444444444444444444444555555555555555555555555555566666666666666666666667777777777777777777777777888888888888888888888888888aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbccccccccccccccccccccccccccccccccccccccccddddddddddddddddddddddddddddd" }));
            listViewmsg.Items.Add(new ListViewItem(new string[] { "12-12-1", "1111111111111111111111111111122222222222222222222333333333333333333334444444444444444444444555555555555555555555555555566666666666666666666667777777777777777777777777888888888888888888888888888aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbccccccccccccccccccccccccccccccccccccccccddddddddddddddddddddddddddddd" }));

            //初始化运行参数
            isrunclient = false;
        }

        private UseTcpServer iserver = new UseTcpServer();
        private bool isstartserver = false;
        private void Btn_startserver_Click(object sender, EventArgs e)
        {
            if (isstartserver)
            {
                iserver.StopServer();
                CoMBx_ServerIp.Enabled = true;
                CoMBx_ServerPort.Enabled = true;
                isstartserver = false;
                return;
            }

            string ip = CoMBx_ServerIp.Text;
            string porttxt = CoMBx_ServerPort.Text;
            if (string.IsNullOrEmpty(porttxt))
                return;

            isstartserver = true;
            int port = Convert.ToInt32(porttxt);

            iserver.SetParent(this);
            iserver.SetServerConfig();
            iserver.StartServer(port, ip);

            CoMBx_ServerIp.Enabled = false;
            CoMBx_ServerPort.Enabled = false;

        }

        string selectclient;
        private void listView1_Click(object sender, EventArgs e)
        {
            string txt = this.listView1.FocusedItem.SubItems[0].Text;
            selectclient = txt;
        }

        private void Btn_senttoclient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectclient))
            {
                return;
            }
            else
            {
                iserver.SendMsg2Client(selectclient, TXT_Sendmsg.Text);
                ServerAddMsgToList(TXT_Sendmsg.Text);
            }
        }

        //客户端列表的删除
        public void delectclient2list(string clientif)
        {
            if (listView1.InvokeRequired)
            {
                Action<string> asyncUIDelegate = delegate(string datastr)
                {
                    int index = -1;
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].SubItems[0].Text.Equals(clientif))
                        {
                            index = i;
                            this.listView1.Items.Remove(listView1.Items[index]);
                            break;
                        }
                    }
                };
                try
                {
                    listView1.Invoke(asyncUIDelegate, new object[] { clientif });
                }
                catch (/*System.*/Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                int index = -1;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text.Equals(clientif))
                    {
                        index = i;
                        this.listView1.Items.Remove(listView1.Items[index]);
                        break;
                    }
                }
            }
        }

        //客户端列表的添加
        public void addclient2list(string clientif)
        {
            if (listView1.InvokeRequired)
            {
                Action<string> asyncUIDelegate = delegate(string datastr)
                {
                    this.listView1.Items.Add(datastr);
                };
                try
                {
                    listView1.Invoke(asyncUIDelegate, new object[] { clientif });
                }
                catch (/*System.*/Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                this.listView1.Items.Add(clientif);
            }
        }

        //listViewmsg 
        //server 插入消息
        public void ServerAddMsgToList(string msg)
        {
            string nowtime = DateTime.Now.ToString("HH:mm ss");
            ListViewItem li = new ListViewItem();

            li.Text = nowtime;
            li.SubItems.Add(msg);
            if (listViewmsg.InvokeRequired)
            {
                Action<string, string> asyncUIDelegate = delegate(string tm, string data)
                {
                    listViewmsg.Items.Insert(0, li);
                };
                try
                {
                    listView1.Invoke(asyncUIDelegate, new object[] { nowtime, msg });
                }
                catch (/*System.*/Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                listViewmsg.Items.Insert(0, li);
            }
        }

        //listViewmsg 
        //使用textbox 插入消息
        public void ClientAddmsgToRichTextBox(string msg)
        {
            string nowtime = DateTime.Now.ToString("HH:mm ss fff");
            msg = "\r\n"+ nowtime + " ->>" + msg ;

            if (richTextBox_showclientmsg.InvokeRequired)
            {
                Action<string> asyncUIDelegate = delegate(string data)
                {
                    richTextBox_showclientmsg.AppendText(msg + System.Environment.NewLine);
                    richTextBox_showclientmsg.Focus();
                    richTextBox_showclientmsg.Select(richTextBox_showclientmsg.Text.Length, 0);
                    richTextBox_showclientmsg.ScrollToCaret();

                };
                try
                {
                    listView1.Invoke(asyncUIDelegate, new object[] {msg});
                
                }
                catch (/*System.*/Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                richTextBox_showclientmsg.AppendText(msg + System.Environment.NewLine);
            }
        }

        //client 插入消息
        public void ClientAddmsgTolist(string msg)
        {
            string nowtime = DateTime.Now.ToString("HH:mm ss");
            ListViewItem li = new ListViewItem();

            li.Text = nowtime;
            li.SubItems.Add(msg);
            if (listViewclientmsg.InvokeRequired)
            {
                Action<string, string> asyncUIDelegate = delegate(string tm, string data)
                {
                    listViewclientmsg.Items.Insert(0, li);
                };
                try
                {
                    listView1.Invoke(asyncUIDelegate, new object[] { nowtime, msg });
                }
                catch (/*System.*/Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                listViewclientmsg.Items.Insert(0, li);
            }
        }

        private void listViewmsg_DoubleClick(object sender, EventArgs e)
        {//双击显示内容
            string txt = this.listViewmsg.FocusedItem.SubItems[1].Text;
            TXT_showmsg.Text = txt;
        }

        private void listViewmsg_MouseClick(object sender, MouseEventArgs e)
        {//右击显示消息到发送框
            if (e.Button == MouseButtons.Right)
            {
                string txt = this.listViewmsg.FocusedItem.SubItems[1].Text;
                TXT_Sendmsg.Text = txt;
            }
        }


        ///////////////////////////////////////////////////////////////

        UseClient iclient = new UseClient();
        bool isrunclient = false;
        //客户端使用
        private void button3_Click(object sender, EventArgs e)
        {//connet
            if (string.IsNullOrEmpty(Client_port.Text)) return;

            if (isrunclient == false)
            {
                isrunclient = true;
                iclient.setparent(this);
                string ipport = Client_ip.Text;
                int port = Convert.ToInt32(Client_port.Text);
                iclient.Connect(ipport, port);
            }
            else if (isrunclient == true)
            {
                isrunclient = false;
                iclient.Disconn();
                setclientipportenable(true);
                setclientipport("");
            }
        }

        //设置client ip port 可用性
        //设置labl文本
        public void setclientipportenable(bool enable)
        {

            if (label_showclientipport.InvokeRequired)
            {
                Action<bool> asyncUIDelegate = delegate(bool yesorno)
                {
                    Client_ip.Enabled = yesorno;
                    Client_port.Enabled = yesorno;
                };
                label_showclientipport.Invoke(asyncUIDelegate, new object[] { enable });
            }
            else
            {
                Client_ip.Enabled = enable;
                Client_port.Enabled = enable;
            }
        }

        //设置labl文本
        public void setclientipport(string ippport)
        {

            if (label_showclientipport.InvokeRequired)
            {
                Action<string> asyncUIDelegate = delegate(string ipp)
                {
                    this.label_showclientipport.Text = ipp;
                };

                try
                {
                    label_showclientipport.Invoke(asyncUIDelegate, new object[] { ippport });
                }
                catch (/*System.*/Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                this.label_showclientipport.Text = ippport;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {//发送消息

            iclient.SendMsg(TxT_ClientSendMsg.Text.ToString());
            ClientAddmsgTolist("<<-"+TxT_ClientSendMsg.Text.ToString());
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_showtxt.SelectedTab.Text.ToString() == "savetxt")
                selectSaveTextBoxAddDate();
            if (tabControl_showtxt.SelectedTab.Text.ToString() == "Sendbyfile")
                SelectSendbyfilePage();
        }

        //选中使用文件进行发送页面
        private void SelectSendbyfilePage()
        {
            //设置选中的客户端
            label_showselectclient.Text = selectclient;
        }

        //选中存储文本框时候 添加文件数据
        private void selectSaveTextBoxAddDate()
        {
            string fload = "_savefile.txt";
            RWFile f = new RWFile(fload);

            ArrayList arrytxt = f.ReadfileAllCont();
            if (arrytxt == null) return;
            string[] arrString = (string[])arrytxt.ToArray(typeof(string));
            textBox_showsavetxt.Lines = arrString;
        }
        //关闭存储文本框的时候 保存数据到文件
        private void selectSaveTextBoxSaveDate()
        {
            string fload = "_savefile.txt";
            RWFile f = new RWFile(fload);
            ArrayList arrytxt = new ArrayList(textBox_showsavetxt.Lines);

            f.Write2file(arrytxt);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            selectSaveTextBoxSaveDate();
        }

        //选中发送文本框中的文字 触发此事件
        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            //richTextBox1.SelectionColor = Color.Red;
        }

        //发送文本框中的文字 然后发送
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectclient)) return;

            string xx = richTextBox1.SelectedText;
            if (string.IsNullOrEmpty(xx))
                return;
            string[] arrxx = xx.Split('\n');

            for (int i = 0; i < arrxx.Count(); i++)
            {
                if (string.IsNullOrEmpty(arrxx[i])) continue;
                if (string.IsNullOrEmpty(selectclient)) return;
                iserver.SendMsg2Client(selectclient, arrxx[i]);
                System.Threading.Thread.Sleep(10);
            }
            richTextBox1.SelectionColor = Color.Red;

        }

        private int Getlinebycursor()
        {
            int charline, line;
            charline = richTextBox1.GetFirstCharIndexOfCurrentLine() + 1;
            line = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
            return line;
        }
        //设置字体背景颜色
        private void setbkcolor(int start, int length, Color cl)
        {
            int oldcursor = richTextBox1.SelectionStart;
            richTextBox1.SelectionStart = start;
            richTextBox1.SelectionLength = length;
            richTextBox1.SelectionBackColor = cl;
            richTextBox1.SelectionStart = oldcursor;
            richTextBox1.SelectionLength = 0;
        }

        //设置字体颜色
        private void Setcolor(int start, int length, Color cl)
        {
            int oldcursor = richTextBox1.SelectionStart;
            richTextBox1.SelectionStart = start;
            richTextBox1.SelectionLength = length;
            richTextBox1.SelectionColor = cl;
            richTextBox1.SelectionStart = oldcursor;
            richTextBox1.SelectionLength = 0;
        }

        private int currline = -1;
        //单步发送
        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectclient)) return;
            int sendsum = Convert.ToInt32(tb_singalsendsum.Text);
            int charline = 0;
            int line = 0;
            string linarr = "";
            for (int i = 0; i < sendsum; i++)
            {
                charline = richTextBox1.GetFirstCharIndexOfCurrentLine() + 1;
                line = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);

                currline = line;
                linarr = richTextBox1.Lines[line];
                if (string.IsNullOrEmpty(selectclient)) return;
                iserver.SendMsg2Client(selectclient, linarr);

                richTextBox1.Focus();
                richTextBox1.SelectionStart = charline + linarr.Length;
                if (line == richTextBox1.Lines.Count() - 1) break;
            }
            textBox_fileshowmsg.Text = linarr;
            line++;
            label_currentsendline.Text = "当前发送行：" + line.ToString();
            //richTextBox1.ScrollToCaret();
            //richTextBox1.Select(charline + 1, linarr.Length);
            //richTextBox1.SelectionBackColor = Color.Red;
            //richTextBox1.SelectionStart= line;
            //richTextBox1.SelectionBackColor = Color.Red;

        }

        //设置progressbar 进度条
        public void SetProgressBar(int xindex)
        {
            if (this.InvokeRequired)
            {
                Action<int> Uidelegate = delegate(int index) { this.progressBar1.Value = index; };
                this.Invoke(Uidelegate, new object[] { xindex });
            }
            else this.progressBar1.Value = xindex;
        }
        //设置发送完成
        public void SetSendisok()
        {
            if (this.InvokeRequired)
            {
                Action<int> Uidelegate = delegate(int index) { textBox_fileshowmsg.Text = DateTime.Now.ToString() + "发送完毕！！！"; };
                this.Invoke(Uidelegate, new object[] { 1 });
            }
            else textBox_fileshowmsg.Text = DateTime.Now.ToString() + "发送完毕！！！";
        }

        public void threadfuncstart(object psendtxt)
        {
            string[] sendtxt = (string[])psendtxt;
            int sendcount = sendtxt.Count();
            for (int i = 0; i < sendcount; i++)
            {
                if (string.IsNullOrEmpty(sendtxt[i])) continue;
                iserver.SendMsg2Client(selectclient, sendtxt[i]);
                SetProgressBar(i);
                System.Threading.Thread.Sleep(10);
            }
            SetSendisok();
        }

        //全部发送
        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectclient)) return;

            string xx = richTextBox1.Text;
            string[] sendtxtarr = xx.Split('\n');
            int sendcount = sendtxtarr.Count();

            progressBar1.Maximum = sendcount - 1;
            progressBar1.Minimum = 0;

            Thread sendmsgthread = new Thread(new ParameterizedThreadStart(threadfuncstart));
            sendmsgthread.Start((object)sendtxtarr);

            // textBox_fileshowmsg.Text = DateTime.Now.ToString()+"发送完毕！！！";

        }

        //绘制行号
        private void ShowNumLines()
        {
            Point p = new Point(0, 0);// 仅修改此行，其余请参考原文
            int curIndex = this.richTextBox1.GetCharIndexFromPosition(p);
            int curLine = this.richTextBox1.GetLineFromCharIndex(curIndex);
            Point curPos = this.richTextBox1.GetPositionFromCharIndex(curIndex);

            p.Y += this.richTextBox1.Height;

            int curLastIndex = this.richTextBox1.GetCharIndexFromPosition(p);
            int curLastLine = this.richTextBox1.GetLineFromCharIndex(curLastIndex);

            Point curLastPos = this.richTextBox1.GetPositionFromCharIndex(curLastIndex);

            Graphics g = this.xhtml_lines.CreateGraphics();

            Font font = new Font(this.richTextBox1.Font, this.richTextBox1.Font.Style);

            SolidBrush brush = new SolidBrush(SystemColors.ControlDark);

            Rectangle rect = this.xhtml_lines.ClientRectangle;

            brush.Color = this.xhtml_lines.BackColor;

            g.FillRectangle(brush, 0, 0, this.xhtml_lines.ClientRectangle.Width, this.xhtml_lines.ClientRectangle.Height);
            brush.Color = SystemColors.ControlDark;

            //绘制行号

            int lineSpace = 0;

            if (curLine != curLastLine)
            {
                lineSpace = (curLastPos.Y - curPos.Y) / (curLastLine - curLine);
            }

            else
            {
                lineSpace = Convert.ToInt32(this.richTextBox1.Font.Size);
            }

            int brushX = this.xhtml_lines.ClientRectangle.Width - Convert.ToInt32(font.Size * 3);

            int brushY = curLastPos.Y + Convert.ToInt32(font.Size * 0.18f);//惊人的算法啊！！

            for (int i = curLastLine; i >= curLine; i--)
            {
                g.DrawString((i + 1).ToString(), font, brush, brushX, brushY);
                brushY -= lineSpace;
            }
            g.Dispose();
            font.Dispose();
            brush.Dispose();
        }

        private void xhtml_lines_Paint(object sender, PaintEventArgs e)
        {
            ShowNumLines();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            xhtml_lines.Invalidate();
        }

        private void richTextBox1_VScroll(object sender, EventArgs e)
        {
            xhtml_lines.Invalidate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //int start = richTextBox1.SelectionStart;
            //MessageBox.Show(start.ToString());
            //Setcolor(start, 8, Color.Red);

            string findstr = "abc";
            int richline = richTextBox1.Lines.Count();

            int strstart = 0;
            int findstrlent = findstr.Length;
            Color cl = Color.Red;
            richTextBox1.SelectionStart = 0;

            for (int i = 0; i < richline; i++)
            {
                string linetext = richTextBox1.Lines[i];

                int st = richTextBox1.SelectionStart;
                strstart = linetext.IndexOf(findstr);
                int sendstrstart = strstart;
                while (strstart != -1)
                {//find ok  setcolor
                    setbkcolor(st, richTextBox1.Lines[i].Length, Color.LightGray);
                    Setcolor(st + sendstrstart, findstrlent, cl);
                    linetext = linetext.Substring(strstart + findstrlent);
                    strstart = linetext.IndexOf(findstr);
                    sendstrstart += strstart + findstrlent;
                }
                richTextBox1.SelectionStart += richTextBox1.Lines[i].Length + 1;
            }
        }

        private void listViewclientmsg_MouseClick(object sender, MouseEventArgs e)
        {
            //右击显示消息到发送框
            if (e.Button == MouseButtons.Right)
            {
                string txt = this.listViewclientmsg.FocusedItem.SubItems[1].Text;
                textBoxshowclientmsg.Text = txt;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox_showclientmsg_Click(object sender, EventArgs e)
        {//选中一行
            return;
            int  charline=9;// = richTextBox_showclientmsg.GetFirstCharIndexOfCurrentLine() + 1;
            int line = richTextBox_showclientmsg.GetLineFromCharIndex(richTextBox1.SelectionStart);
            string linetext = richTextBox_showclientmsg.Lines[line];
            int charindex = 0;
            for (int i = 0; i < line; i++)
            {
                charindex += richTextBox_showclientmsg.Lines[i].Length + 1;
            }
           // setbkcolor(charindex, linetext.Length, Color.Red);
            int oldcursor = richTextBox_showclientmsg.SelectionStart;
            richTextBox_showclientmsg.SelectionStart = charindex;
            richTextBox_showclientmsg.SelectionLength = linetext.Length;
            richTextBox_showclientmsg.SelectionBackColor = Color.Red;
            richTextBox_showclientmsg.SelectionStart = oldcursor;
            richTextBox_showclientmsg.SelectionLength = 0;
        }

        private void richTextBox_showclientmsg_MouseDown(object sender, MouseEventArgs e)
        {
            //右击显示消息到发送框
            if (e.Button == MouseButtons.Right)
            {
                int charline = richTextBox_showclientmsg.GetFirstCharIndexOfCurrentLine() + 1;
                int line = richTextBox_showclientmsg.GetLineFromCharIndex(richTextBox_showclientmsg.SelectionStart);
                string linetext = richTextBox_showclientmsg.Lines[line];
                textBoxshowclientmsg.Text = linetext;
            }
        }



    }
}
