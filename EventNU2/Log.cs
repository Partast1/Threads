using System;
using System.Collections.Generic;
using System.Text;

namespace EventNU2
{
    class Log
    {
        private DateTime timeNow;
        private string message;


        public DateTime TimeNow
        {
            get { return timeNow; }
            set { timeNow = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        //public Log( string message)
        //{
           
        //    Message = message;
        //}
    }
}
