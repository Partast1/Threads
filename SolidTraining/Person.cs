using System;
using System.Collections.Generic;
using System.Text;

namespace SolidTraining
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int birthYear;

        public int BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }
        public Person()
        {

        }
        public Person(string nam, int birth)
        {
            name = nam;
            BirthYear = birth;
        }
    }
}
