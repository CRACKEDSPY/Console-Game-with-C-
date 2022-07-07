using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_With_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Prediction = 0;
            int NumberProduced = 0;
            int Counter = 0;

            Console.Write("Enter the Highest Value for the Guessing Game : ");
            int KullanıcıGelenDeger = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            NumberProduced = rnd.Next(1, KullanıcıGelenDeger);

            do
            {
                Counter++;
                Console.WriteLine("{0} Estimate the Number Produced", Counter);
                Prediction = int.Parse(Console.ReadLine());

            } while (Prediction != NumberProduced);

            Console.WriteLine("{0} You Tried Times You Guessed The Number.", Counter);

            Console.ReadLine();
        }
    }
}
