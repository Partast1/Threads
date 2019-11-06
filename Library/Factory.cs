using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    static class Factory
    {
        static IBorrowAbleBook CreateBorrowBook()
        {
            return new Book();
        }
        static IBorrowAbleBook CreateBorrowChildBook()
        {
            return new ChildrensBook();
        }
        static IBorrowAbleDVD CreateBorrowDVD()
        {
            return new DVD();
        }
    }
}
