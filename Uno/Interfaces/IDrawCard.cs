using System;
using System.Collections.Generic;
using System.Text;

namespace Uno.Interfaces
{
    interface IDrawCard
    {
        int DrawAmount { get; set; }
        void DrawCards();
    }
}
