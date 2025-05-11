using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Script.Net;

namespace Game.Script
{
    internal class MainClass
    {
        public static void Main(string[] arg)
        {
            if (!DbManager.Connect("sectsystem", "127.0.0.1", 3306, "root", "root"))
                return;
            NetManager.StartLoop(8888);
        }
    }
}
