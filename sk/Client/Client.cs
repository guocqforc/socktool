using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace sk.Client
{
    class Client
    {
        private Socket _sock;
        private const int buffsize=8192+11024+1024;
        private byte[] buff = new byte[buffsize];
        bool isrun;
        bool isconn =false;
        private ManualResetEvent _threadevent = new ManualResetEvent(false);

        public void Connect(int port)
        {
            isrun = true;
            Connect(null, port);
        }

        public void Connect(string ip, int port)
        {
            isrun = true;
            if (string.IsNullOrEmpty(ip))
            {
                ip = "127.0.0.1";
            }
            IPEndPoint ipport = new IPEndPoint(IPAddress.Parse(ip), port);
            _sock = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            _sock.BeginConnect(ipport,_connect,_sock);
        }
        public bool Isconn()
        {
            return isconn;
        }
        void _connect(IAsyncResult rst)
        {
            Socket sock = (Socket)rst.AsyncState;
            try
            {
                sock.EndConnect(rst);
                _sock = sock;
                OnConnect(sock);
                isconn = true;
                _sock.BeginReceive(buff, 0, buffsize, 0, _receive, _sock);
            }
            catch (Exception)
            {
                isconn = false;
            }
            
        }


        void _receive(IAsyncResult rst)
        {
            _threadevent.Reset();
            if (!isrun) return;
            _threadevent.Set();
            Socket clt = (Socket)rst.AsyncState;
            int reccount = clt.EndReceive(rst);
            string recmsg = Encoding.Default.GetString(buff);
            if (reccount == 0)
            {
                OnDisconn();
                return;
            }
            else
            {
                OnRecive(recmsg);
                clt.BeginReceive(buff, 0, buffsize, 0, _receive, _sock);
            } 
        }

       

        public void Disconn()
        {
            //if (!isrun) return;
            _threadevent.Reset();
            isrun = false;
            _threadevent.Set();
            
            //_sock.Close();
            _sock.Disconnect(false);
        }

       
        public void SendMsg(string msg)
        {
            _sock.Send(Encoding.Default.GetBytes(msg));
        }

        public virtual void OnDisconn()
        {

        }

        public virtual void OnRecive(string msg)
        {

        }

        public virtual void OnConnect(Socket clt)
        {

        }
    }
}
