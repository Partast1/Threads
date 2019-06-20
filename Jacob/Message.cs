using System;
using System.Collections.Generic;
using System.Text;

namespace Jacob
{
    public enum MessageCarrier { Smtp, VMessage }
    class Message
    {
        private string to;
        private string from;
        private string body;
        private string subject;
        private string cc;


        public string To
        {
            get { return to; }
            set { to = value; }
        }
        public string From
        {
            get { return from; }
            set { from = value; }
        }
        public string Body
        {
            get { return body; }
            set { body = value; }
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public string Cc
        {
            get { return cc; }
            set { cc = value; }
        }


        public Message(string to, string from, string body, string subject, string cc)
        {
            this.to = to;
            this.from = from;
            this.body = body;
            this.subject = subject;
            this.cc = cc;
        }
    }
}
