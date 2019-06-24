using System;
using System.IO;
using System.Text;
using System.Linq;
using System.ServiceProcess;
using System.Collections.Generic;
using System.Threading;

namespace FileSurveillance
{
    public static class Program
    {
        public static void Main(string[] args)
        {
         
            //NewFile nf = new NewFile();
            //Thread createFile = new Thread(new ThreadStart(nf.CreateFile));
            SystemSurveillance ss = new SystemSurveillance();
            ss.SystemWatcher();
            //createFile.Start();
            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[]
            //{
            //    new NotWatching()
            //};

        } // end public static void Main(string[] args)



    }
}

