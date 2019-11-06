using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    interface ILibraryItem
    {
        int LibraryId { get; set; }
        DateTime AgeRestriction { get; set; }
        string Titel { get; set; }
        int AvailableAmount { get; set; }
    }
}
