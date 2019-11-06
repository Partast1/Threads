using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    interface IBorrowAble
    {

        DateTime borrowdate { get; set; }
        DateTime dueDate { get; set; }

        void CheckIn(Customer customer);
        void CheckOut();
        DateTime GetDueDate(DateTime borrow);
    } 
}
