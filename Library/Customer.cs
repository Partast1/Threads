using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Customer : ICustomer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }
        public string BillingAddresse { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int phoneNumber { get; set; }
        public int dueAmount { get; set; }
    }
}
