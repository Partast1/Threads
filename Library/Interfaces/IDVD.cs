using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    interface IDVD : ILibraryItem
    {
        List<string> Actors { get; set; }
        int RuntimeInMinutes { get; set; }
    }
}
