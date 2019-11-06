using System;
using System.Collections.Generic;
using System.Text;

namespace ooptestapp
{
    class Car
    {
        // Attributes
        private string brand;
        private string color;
        private int numOfDoors;
        private Engine engine;

        // Properties
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Color
        {
            get { return brand; }
            set { brand = value; }
        }

        public int NumOfDoors
        {
            get { return numOfDoors; }
            set { numOfDoors = value; }
        }

        // Constructor
        public Car(string brand, string color, int doors, Engine eng)
        {
            brand = Brand;
            color = Color;
            doors = NumOfDoors;
            eng = engine;
        }
        // Methods
        public void StartCar()
        {

        }
        public void ShutOffCar()
        {

        }
        public void ChangeGear()
        {

        }


    }
}
