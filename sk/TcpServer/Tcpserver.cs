using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace sk.TcpServer
{

    class Tcpserver
    {
        class socketinfo
        {
            const int buffMax = 8192;
            public Socket _sock;
            public int _buffsize;
            public byte[] _buff = new byte[buffMax];
        };

        private Socket _lister;
        private Dictionary<string, socketinfo> _socketset;
        private bool isrun;
        private ManualResetEvent _threadevent = new ManualResetEvent(false);

        private void _startserver(string ip, int port)
        {
            isrun = true;
            _lister = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint newipport = new IPEndPoint(IPAddress.Parse(ip), port);

            _lister.Bind(newipport);
            _lister.Listen(5);

            _threadevent.Reset();
            if (!isrun)
            {
                _threadevent.Set();
                return;

            }

            _lister.BeginAccept(new AsyncCallback(_acceptcallback), _lister);

        }

        void _stopserver()
        {
            //遍历 clientset 把客户端都关闭 todo 清理dict 中的客户端
            _threadevent.Reset();
            isrun = false;
            if (_lister != null)
                _lister.Close();
            _threadevent.Set();
            //_lister.Close();
        }

        // Checks if the socket is connected
        public bool IsSocketConnected(Socket s)
        {
            return !((s.Poll(1000, SelectMode.SelectRead) && (s.Available == 0)) || !s.Connected);
        }

        public void _acceptcallback(IAsyncResult rst)
        {

            Socket lister = (Socket)rst.AsyncState;

            _threadevent.Reset();
            if (!isrun)
            {
                _threadevent.Set();
                return;
            }

            if (lister != null)
            {


                Socket client = lister.EndAccept(rst);
                socketinfo ct = new socketinfo();
                ct._sock = client;
                client.BeginReceive(ct._buff, 0, 8192, 0, _recvclientmsg, ct);
                _socketset.Add(client.RemoteEndPoint.ToString(), ct);
                _threadevent.Reset();
                if (!isrun)
                {
                    lister.Close();
                    return;
                }
                _threadevent.Set();
                lister.BeginAccept(_acceptcallback, lister);

                //调用外部接口函数
                ClientConnected(ct._sock.RemoteEndPoint.ToString());
            }
        }

        public void _recvclientmsg(IAsyncResult rst)
        {
            socketinfo ct = (socketinfo)rst.AsyncState;

            if (!IsSocketConnected(ct._sock))
            {
                ClientDisConn(ct._sock.RemoteEndPoint.ToString());
                _socketset.Remove(ct._sock.RemoteEndPoint.ToString());
                ct._sock.Close();
                return;
            }

            int rcwcount = ct._sock.EndReceive(rst);
            if (rcwcount == 0)
            {//客户断开
                ClientDisConn(ct._sock.RemoteEndPoint.ToString());
                _socketset.Remove(ct._sock.RemoteEndPoint.ToString());
                ct._sock.Close();
            }
            else
            {//调用 返回调用外部接口
                ct._buffsize = 8192;
                string msg = Encoding.Default.GetString(ct._buff, 0, ct._buffsize);
                string ipport = ct._sock.RemoteEndPoint.ToString();
                RecvclientMsg(ipport, msg);

                // if (isstop) return;
                ct._sock.BeginReceive(ct._buff, 0, ct._buffsize, 0, _recvclientmsg, ct);
            }
        }

        public void SetServerConfig()
        {
            _socketset = new Dictionary<string, socketinfo>();
        }

        public void StartServer(int port, string ip = null)
        {
            if (string.IsNullOrEmpty(ip))
                _startserver("127.0.0.1", port);
            else
                _startserver(ip, port);
        }

        public void StopServer()
        {
            _stopserver();
        }

        public void SendMsg2Client(string ipport, string msg)
        {
            if (_socketset.ContainsKey(ipport))
            {//包含
                _socketset[ipport]._sock.Send(Encoding.Default.GetBytes(msg));
            }
        }

        //有客户端断开回调用这个函数
        public virtual void ClientDisConn(string ipport)
        {

        }

        //接受到客户端数据的时候 会调用这个函数
        public virtual void RecvclientMsg(string ipport, string msg)
        {

        }

        //有客户端连接上来回调用这个函数
        public virtual void ClientConnected(string ipport)
        {

        }


    }
}
