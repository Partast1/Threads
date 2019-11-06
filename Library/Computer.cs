using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Computer : IElectronicBorrow
    {
        public int LibraryId { get; set; }
        public string Model { get; set; }
        public string MacAdresse { get; set; }
        public DateTime BorrowStartTime { get; set; }
        public DateTime AgeRestriction { get; set; }
        public string Titel { get; set; }
        public int AvailableAmount { get; set; }

        public Computer(int libraryId, string model, string mac, string title, int availableAmount)
        {
            LibraryId = libraryId;
            Model = model;
            MacAdresse = mac;
            Titel = title;
            AvailableAmount = availableAmount;
        }
    }
}

