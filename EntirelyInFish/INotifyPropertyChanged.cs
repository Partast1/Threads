using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EntirelyInFish
{
    interface TNotifyPropertyChanged
    { 
        //delegate til event håndtering
        event PropertyChangedEventHandler PropertyChanged;
        //det er denne metode der kaldes, når der skal kastes en event
      
    }
   

}
