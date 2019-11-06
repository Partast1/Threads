using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class DVD : IBorrowAbleDVD
    {
        public DateTime borrowdate { get; set; }
        public DateTime dueDate { get; set; }
        public List<string> Actors { get; set; }
        public int RuntimeInMinutes { get; set; }
        public int LibraryId { get; set; }
        public DateTime AgeRestriction { get; set; }
        public string Titel { get; set; }
        public int AvailableAmount { get; set; }

        public DVD(List<string> actors, int runtime, int Libraryid, string titel, int AvailableAmount)
        {
            Actors = actors;
            RuntimeInMinutes = runtime;
            LibraryId = Libraryid;
            Titel = titel;
            this.AvailableAmount = AvailableAmount;
        }
        public void CheckIn(Customer customer)
        {
        
        }

        public void CheckOut()
        {
            throw new NotImplementedException();
        }

        public DateTime GetDueDate(DateTime borrow)
        {
            throw new NotImplementedException();
        }
    }
}
