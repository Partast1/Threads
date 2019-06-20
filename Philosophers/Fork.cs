using System;
using System.Collections.Generic;
using System.Text;

namespace Philosophers
{

    public class Fork
    {
        #region private fields
        //Private fields
        private object fork1;
        private object fork2;
        private object fork3;
        private object fork4;
        private object fork5;
        #endregion

        //public fields
        public object Fork1
        {
            get { return fork1; }
            set { fork1 = value; }
        }
        public object Fork2
        {
            get { return fork2; }
            set { fork2 = value; }
        }
        public object Fork3
        {
            get { return fork3; }
            set { fork3 = value; }
        }
        public object Fork4
        {
            get { return fork4; }
            set { fork4 = value; }
        }
        public object Fork5
        {
            get { return fork5; }
            set { fork5 = value; }
        }

        public Fork()
        {

        }
        public Fork(object fork1c, object fork2c, object fork3c, object fork4c, object fork5c)
        {

            this.fork1 = fork1c;
            this.fork2 = fork2c;
            this.fork3 = fork3c;
            this.fork4 = fork4c;
            this.fork5 = fork5c;
        }
    }
}
