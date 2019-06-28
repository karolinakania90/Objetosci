using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numery = new int[3];

            string[] imiona = new string[3] { "Karolina", "Mateusz", "Adam" };

            for(int i=0; i<imiona.Length; ++i)
            {
                Console.WriteLine(imiona[i]);
            }

            Array.Sort(imiona);

            Console.WriteLine("Posortowane imiona: ");

            for (int i = 0; i < imiona.Length; ++i)
            {
                Console.WriteLine(imiona[i]);
            }
            //Console.WriteLine("Witajcie " + imiona[0] + " i " + imiona[1]);

            // int wiek = 28;
            int wiek = 25;

            numery[0] = 20;
            numery[1] = wiek;

            Console.WriteLine("Element pierwszy: " + numery[0]);

            Console.WriteLine("element drugi: " + numery[1]);

            Console.WriteLine("Podaj trzeci element tablicy");

            numery[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("element trzeci: " + numery[2]);

            Console.Read();
        }
    }
}
