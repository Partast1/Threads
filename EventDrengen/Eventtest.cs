using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventDrengen
{
    class Eventtest
    {
        public Eventtest()
        {
            Thread thr;
            {
                thr = new Thread(OnDebug);
                thr.Start();
            }
        }

        public event EventHandler Debug;

        private void OnDebug()
        {
            while (true)
            {
                Debug?.Invoke(this, new Producteventargs("ting"));

            }
        }
        
    }
}
