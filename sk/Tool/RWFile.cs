using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace sk.Tool
{
    class RWFile
    {
        string _fileload;
        ArrayList _contentset;
        public RWFile(string filename)
        {
            _fileload = filename;
            _contentset = new ArrayList();
        }
        public ArrayList ReadfileAllCont()
        {
            if(string.IsNullOrEmpty(_fileload))
                return null;

            ArrayList tmp = new ArrayList();
            if (!File.Exists(_fileload))
                return null;
            StreamReader f = new StreamReader(_fileload,Encoding.Default);
            if (!f.EndOfStream)  return null;
            string linetxt;

            while((linetxt=f.ReadLine())!=null)
                tmp.Add(linetxt);
            f.Close();
            return tmp;
        }

        public void Write2file(ArrayList xx)
        {
            if(string.IsNullOrEmpty(_fileload))
                return;
            FileStream f = new FileStream(_fileload,FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.ReadWrite);
            for(int i=0;i<xx.Count;i++)
            { 
                byte[]arrybyt = Encoding.Default.GetBytes(xx[i].ToString()+"\n");
                f.Write(arrybyt,0,arrybyt.Count());
            }
            f.Flush();
            f.Close();

        }

        //public 
    }
}
