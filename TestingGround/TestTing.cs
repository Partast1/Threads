using System;
using System.Collections.Generic;
using System.Text;

namespace TestingGround
{
    class TestTing
    {
        private int a;

        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public TestTing(int ca)
        {
            this.a = ca;
        }
    }
}
