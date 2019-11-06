using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public interface IDVD : ILibraryItem
    {

        /// <summary>
        /// List cannot have get set...
        /// </summary>
        List<string> Actors { get; set; }
        int RuntimeInMinutes { get; set; }
    }
}
