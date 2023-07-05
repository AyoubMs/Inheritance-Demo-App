using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Phone> phones = new List<Phone>();

            phones.Add(new CellPhone());
            phones.Add(new Smartphone());

            foreach (var phone in phones)
            {
                if (phone is CellPhone cell)
                {
                    cell.Carrier = "";
                }

                if (phone is Smartphone smartphone)
                {
                    smartphone.ConnectToInternet();
                }
            }

            Console.ReadLine();
        }
    }

    public class Hotspot
    {

    }

    public class WalkieTalkie
    {

    }
}
