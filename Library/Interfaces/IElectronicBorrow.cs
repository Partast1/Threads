using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    interface IElectronicBorrow : ILibraryItem
    {

        string Model { get; set; }
        string MacAdresse { get; set; }
        DateTime BorrowStartTime { get; set; }

    }
}
