using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Storage
    {
        public void CreateBook()
        {

            IBorrowAbleBook TheLordOfTheRings1 = new Book("J.R.R. Tolkien", 378, 000001, "Lord Of The Rings: the two towers", 2);
            IBorrowAbleBook HarryPotter1 = new Book("J.K.Rowling", 500, 000002, "Harry Potter og de vises sten", 10);
            
        }
        public void CreateChildrenBook()
        {

            IBorrowAbleBook CatInTheHat = new Book("Dr Seuss", 37, 000003, "Cat In The Hat", 3);
            IBorrowAbleBook GoodNightMoon = new Book("Margaret Wise Brown", 52, 000004, "Good Night Moon", 10);

        }
        public void CreateComputer()
        {
            IElectronicBorrow com1 = new Computer(00100,"L540", "Lenovo", "79:e1:5f:ae:6d:1a", 1);
            IElectronicBorrow com2 = new Computer(00101, "T560", "Lenovo", "39:d7:94:bc:8b:6d", 1);
            IElectronicBorrow com3 = new Computer(00102, "T560", "Elitebook 840", "da:33:f1:07:38:d9", 1);


        }
        public void CreateTablet()
        {
            IElectronicBorrow tab1 = new Tablet(00103, "S 6", "Samsung", "20:7f:2b:bf:5c:b0", 1);
            IElectronicBorrow tab2 = new Tablet(00104, "Ipad Pro", "Apple", "c2:34:41:d7:39:ba", 1);
            IElectronicBorrow tab3 = new Tablet(00105, "Ipad Pro", "Apple", "00:3d:ad:d7:69:d0", 1);
        }
        public void CreateReferenceBook()
        {

            IBook Archaeology = new ReferenceBook("Dr Seuss", 37, 000200, "Archaeology", 3);
            IBook GoodNightMoon = new ReferenceBook("Margaret Wise Brown", 52, 000201, "Good Night Moon", 10);

        }

        public void CreateDVD()
        {
            List<string> SSR = new List<string>();
            SSR.Add("Tim Robbins");
            SSR.Add("Morgan Freeman");
            IBorrowAbleDVD ShankShawRedemption = new DVD( SSR, 120, 000500, "The ShankShaw Redemption", 3);
        }
    }
}
