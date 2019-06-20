using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    public abstract class CreditCard
    {
        private string firstName;
        private string lastName;
        private string cardnumber;
        private DateTime expirationDate;
        private string accountnumber;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Cardnumber
        {
            get { return cardnumber; }
            set { cardnumber = value; }
        }
        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }
        public string Accountnumber
        {
            get { return accountnumber; }
            set { accountnumber = value; }
        }
        public CreditCard(string cfirstn, string clastn, string ccardn, DateTime cexpir, string caccount)
        {
            this.firstName = cfirstn;
            this.lastName = clastn;
            this.cardnumber = ccardn;
            this.expirationDate = cexpir;
            this.accountnumber = caccount;
        }
    }
}
