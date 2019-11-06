using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SausageWagon
{
    public interface IExpireable
    {
         int ExpirationTime { get; set; }
    }
}
