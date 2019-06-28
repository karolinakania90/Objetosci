using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj promień");

            double promien = Convert.ToDouble( Console.ReadLine());

            Console.WriteLine("Podany promień:" + promien);

            double objetosc = (4 * Math.PI * Math.Pow(promien, 3)) / 3;

            Console.WriteLine("Objętość kuli wynosi: " + objetosc);

            Console.Read();
        }
    }
}
