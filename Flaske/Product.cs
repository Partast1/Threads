using System;
using System.Collections.Generic;
using System.Text;

namespace Flaske
{
    class Product
    {
        private string productName;
        private int serialNumnber;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public int SerialNumnber
        {
            get { return serialNumnber; }
            set { serialNumnber = value; }
        }
        public Product(string cName, int CNumber)
        {
            this.productName = cName;
            this.SerialNumnber = CNumber;
        }

    }
}
