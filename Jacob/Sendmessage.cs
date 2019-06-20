using System;
using System.Collections.Generic;
using System.Text;

namespace Jacob
{
    class Sendmessage
    {
        public void sendMessage(MessageCarrier type, Message m, bool isHTML)
        {
            BodyHTML bht = new BodyHTML();
            //herinde sendes der en email ud til modtageren
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
