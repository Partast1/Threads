using System;
using System.Collections.Generic;
using System.Text;

namespace SolidTraining
{
    public class EBook : Book, IDownloadBook
    {
        public string DownloadPath { get ; set; }
    }
}
