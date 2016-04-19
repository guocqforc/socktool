using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sk.TcpServer;

namespace sk.TcpServer
{
    class UseTcpServer: Tcpserver
    {
        private Form1 _parent;
        public void SetParent(Form1 xx)
        {
            _parent = xx;
        }

         //有客户端断开回调用这个函数
        public override  void ClientDisConn(string ipport)
        {
            _parent.delectclient2list(ipport);
        }

        //接受到客户端数据的时候 会调用这个函数
        public override void RecvclientMsg(string ipport, string msg)
        {
            _parent.ServerAddMsgToList(ipport+" :" + msg);
        }

        //有客户端连接上来回调用这个函数
        public override void ClientConnected(string ipport)
        {
            _parent.addclient2list(ipport);
        }

    };
}
