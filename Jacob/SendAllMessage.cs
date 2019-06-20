using System;
using System.Collections.Generic;
using System.Text;

namespace Jacob
{
    class SendAllMessage
    {
        public void sendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML)
        {
            BodyHTML bht = new BodyHTML();

            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = bht.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = bht.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }
    }
}
