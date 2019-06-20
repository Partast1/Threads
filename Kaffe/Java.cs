using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffe
{
    class Java
    {
        private double bean;
        public double Bean
        {
            get { return bean; }
            set { bean = value; }
        }
        public Java(double cbean)
        {
            this.bean = cbean;
        }
    }
}
