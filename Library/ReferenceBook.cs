using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class ReferenceBook : IBook
    {
        public string author { get; set; }
        public int pages { get; set; }
        public int LibraryId { get; set; }
        public DateTime AgeRestriction { get; set; }
        public string Titel { get; set; }
        public int AvailableAmount { get; set; }
        public ReferenceBook(string author, int pages, int LibraryId, string Titel, int AvailableAmount)
        {
            this.author = author;
            this.pages = pages;
            this.LibraryId = LibraryId;
            this.Titel = Titel;
            this.AvailableAmount = AvailableAmount;

        }
    }
}
