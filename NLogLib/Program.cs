using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NLog;

namespace NLogLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            int i = 0;
            while (i<10000)
            {
                Thread.Sleep(1000);
                logger.Info($"日志测试:{i};");
                i++;
            }
        }
    }
}
