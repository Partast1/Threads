using System;
using System.Collections.Generic;
using System.Text;

namespace Arkimedes
{
    public class Philosopher
    {

    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }


    public Philosopher(string cname )
        {
            
            this.name = cname;
      
        }
    }
}
