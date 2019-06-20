using System;
using System.Collections.Generic;
using System.Text;

namespace Flaske
{
    public class SerialNumber
    {

        public  int CreateSNumber()
        {
            //List for temporary serialnumber
            List<int> tempSeriallist = new List<int>();

            Random rnd = new Random();
            //Randomly generates 8 numbers between 1-9
            for (int i = 0; i < 8; i++)
            {

                tempSeriallist.Add((rnd.Next(1, 9)));
                    
            }
            //List is sent to method and returned as int
            int serialNumber = SerialNumberGenerator(tempSeriallist);
            //Serialnumber returned
            return serialNumber;

        }
        public static int SerialNumberGenerator(List<int> numbers)
        {
            string  tempnumber = "";
            //numbers from list is joined into string
            tempnumber = string.Join("", numbers.ToArray());
            //String is converted to int
            int serialNumber = Convert.ToInt32(tempnumber);
            return serialNumber;
        }
    }
}
