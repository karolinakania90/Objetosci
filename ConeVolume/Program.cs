using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConeVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wysokość stożka: ");
            double wysokosc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podana wysokość: " + wysokosc);

            Console.WriteLine("Podaj promień: ");
            double promien = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podany promien: " + promien);

            double objetosc = (Math.PI * Math.Pow(promien, 2) * wysokosc) / 3;

            Console.WriteLine("Objętość stożka wynosi(w zaokrągleniu): " + Math.Round(objetosc, 3));

            Console.ReadLine();
        }
    }
}
