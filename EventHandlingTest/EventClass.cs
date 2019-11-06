using System;
using System.Collections.Generic;
using System.Text;

namespace EventHandlingTest
{
    class EventClass
    {
        public event EventHandler ThresholdReached;
        protected virtual OnThresholdReached(EventArgs e)
        {
            EventHandler handler = ThresholdReached;
            handler?.Invoke(this, e);
        }
    }
}
