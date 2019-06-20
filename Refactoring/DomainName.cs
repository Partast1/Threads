using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    public static class DomainName
    {
        public static string DomainNameConverter(string Hostname)
        {
            string ip = "";
            try
            {
                IPHostEntry ipHostEntry = Dns.Resolve(Hostname);
                if (ipHostEntry.AddressList.Length > 0)
                {
                    //ip = ipHostEntry.AddressList[0].Address.ToString();
                    ip = ipHostEntry.AddressList[0].ToString();
                }
                else
                {
                    ip = "No information found.";
                }
            }
            catch (SocketException)
            {
                ip = "Unable to perform lookup - a socket error occured.";
                return ip;
            }
            catch (SecurityException)
            {
                ip = "Unable to perform lookup - permission denied.";
                return ip;
            }
            catch (Exception)
            {
                ip = "An unspecified error occured.";
                return ip;
            }

            return ip;
        }
    }
}
