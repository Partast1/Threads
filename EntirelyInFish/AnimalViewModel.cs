using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace EntirelyInFish
{



    public class AnimalViewModel : INotifyPropertyChanged
    {
        //public string CurrentAnimal { get; set; }
        private string currentAnimal;
        public string CurrentAnimal
        {
            get { return currentAnimal; }
            set
            {
                currentAnimal = value;
                NotifyPropertyChanged("CurrentAnimal");
            }
        }
        private string imageSource;

        public string ImageSource
        {
            get { return imageSource; }
            set { imageSource = value;
            }
        }
        
        //delegate til event håndtering
        public event PropertyChangedEventHandler PropertyChanged;
        //det er denne metode der kaldes, når der skal kastes en event
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<Animal> animals = new ObservableCollection<Animal>();

        internal ObservableCollection<Animal> Animals { get => animals; set => animals = value; }


        public AnimalViewModel()
        {
            animals.Add(new Animal("Butterflyfish", "20 cm", "n/a"));
            animals.Add(new Animal("Tiger Shark", "3.25 to 4.25 m", "385 to 635 kg"));
            animals.Add(new Animal("Great White Shark", "4.6 m to 6 m", "2.268 kg"));
        }

    }
}
