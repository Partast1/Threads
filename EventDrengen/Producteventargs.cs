using System;
using System.Collections.Generic;
using System.Text;

namespace EventDrengen
{
    class Producteventargs : EventArgs
    {
        private string myString;

        public string MyString
        {
            get { return myString; }
            set { myString = value; }
        }

        public Producteventargs(string myString)
        {
            MyString = myString;
        }

        public override string ToString()
        {
            return MyString;
        }
    }
}
