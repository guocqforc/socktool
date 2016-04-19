using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace sk.Client
{
    class UseClient:Client
    {
        Form1 _parent;
        public void setparent(Form1 xx)
        {
            _parent = xx;
        }

        public override void OnConnect(Socket clt)
        {
            _parent.setclientipport(clt.LocalEndPoint.ToString());
            _parent.setclientipportenable(false);
        }
       // public override void d
        public override void OnRecive(string msg)
        {
           //_parent.ClientAddmsgTolist("->>"+msg);
            _parent.ClientAddmsgToRichTextBox(msg);
        }

    }
}
