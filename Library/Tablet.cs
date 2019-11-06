using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Tablet : IElectronicBorrow
    {
        public int libraryId { get ; set ; }
        public int LibraryId { get ; set ; }
        public string Model { get ; set ; }
        public string MacAdresse { get ; set ; }
        public DateTime BorrowStartTime { get ; set ; }
        public DateTime AgeRestriction { get ; set ; }
        public string Titel { get ; set ; }
        public int AvailableAmount { get ; set ; }

        public Tablet(int libraryId, string model, string mac, string title, int availableAmount)
        {
            LibraryId = libraryId;
            Model = model;
            MacAdresse = mac;
            Titel = title;
            AvailableAmount = availableAmount;
        }
    }
}
