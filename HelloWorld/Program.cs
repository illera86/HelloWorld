using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            // TODO code application logic here
            Console.WriteLine("Hola món");
            Console.WriteLine("versió 0.2 del projecte prjava00");
            try
            {
  
               
                String hostname = Dns.GetHostName();
                IPAddress[] ipAddr = Dns.GetHostAddresses(hostname);
                Console.WriteLine("hostname=" + hostname);
                Console.WriteLine("Adreça IP: " + ipAddr); 
                Console.WriteLine("Nom de l'usuari: user.name");
                Console.WriteLine("Carpeta Personal: user.home");
                Console.WriteLine("Sistema operatiu: os.name");
                Console.WriteLine("Versió OS:os.version");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
