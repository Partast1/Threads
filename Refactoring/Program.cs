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
    class Program
    {

            static void Main()
            {
                IPAddress[] array = Dns.GetHostAddresses("en.wikipedia.org");
                foreach (IPAddress ip in array)
                {
                    Console.WriteLine(ip.ToString());
                }


                LocalPing();
                Console.WriteLine("start");
                string t = HostName.HostnameConverter("8.8.8.8");
                Console.WriteLine(t);
                Console.WriteLine("slut");
                string adr = DomainName.DomainNameConverter(t);
                Console.WriteLine("Weee " + adr);



                string a = TraceRoute.TracingRoute("8.8.8.8");
                Console.WriteLine("route*** " + a);

                DisplayDhcpServerAddresses();

                Console.ReadKey();
                //WIN-M69SG2Q0732.test.local
                //ZBC-RG01203MKC
                string hostName = "ZBC-RG01203MKC";
                IPHostEntry hostInfo = Dns.GetHostByName(hostName);
                // Get the IP address list that resolves to the host names contained in the 
                // Alias property.
                IPAddress[] address = hostInfo.AddressList;
                // Get the alias names of the addresses in the IP address list.
                String[] alias = hostInfo.Aliases;

                Console.WriteLine("Host name : " + hostInfo.HostName);
                Console.WriteLine("\nAliases : ");
                for (int index = 0; index < alias.Length; index++)
                {
                    Console.WriteLine(alias[index]);
                }
                Console.WriteLine("\nIP address list : ");
                for (int index = 0; index < address.Length; index++)
                {
                    Console.WriteLine(address[index]);
                }
                Console.ReadKey();

            }

            static void LocalPing()
            {
                // Ping's the local machine.
                Ping pingSender = new Ping();
                IPAddress address = IPAddress.Loopback;
                PingReply reply = pingSender.Send(address);

                if (reply.Status == IPStatus.Success)
                {
                    Console.WriteLine("Address: {0}", reply.Address.ToString());
                    Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                    Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                    Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                    Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
                }
                else
                {
                    Console.WriteLine(reply.Status);
                }
            }


          

            

            

            static void DisplayDhcpServerAddresses()
            {
                Console.WriteLine("DHCP Servers");
                NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface adapter in adapters)
                {
                    IPInterfaceProperties adapteradapterProperties = adapter.GetIPProperties();
                    IPAddressCollection addresses = adapteradapterProperties.DhcpServerAddresses;
                    if (addresses.Count > 0)
                    {
                        Console.WriteLine(adapter.Description);
                        foreach (IPAddress address in addresses)
                        {
                            Console.WriteLine("  Dhcp Address ............................ : {0}", address.ToString());
                        }
                        Console.WriteLine();
                    }
                }
            }
        
    }
}
