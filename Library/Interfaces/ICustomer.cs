using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    interface ICustomer
    {
        string firstName { get; set; }
        string lastName { get; set; }
        string Email { get; set; }
        string BillingAddresse { get; set; }
        DateTime DateOfBirth { get; set; }
        int phoneNumber { get; set; }
        int dueAmount { get; set; }
    }
}
