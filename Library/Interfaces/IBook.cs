using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    interface IBook : ILibraryItem
    {
        string author { get; set; }
        int pages { get; set; }
    }
}
