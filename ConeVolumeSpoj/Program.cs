using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConeVolumeSpoj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dwie liczby całkowite," 
                + " kolejno R oraz L z zakresu od -10^6 do 10^6, oddzielone spacją");

            string liczby = Console.ReadLine();

            string[] argumenty = liczby.Split(' ');


            double R = Convert.ToDouble(argumenty[0]);

            double L = Convert.ToDouble(argumenty[1]);

            Console.Read();
        }
    }
}
