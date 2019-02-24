using BilgeAdam.Common.Models;
using System;

namespace BilgeAdam.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Human hmn1 = new Human();
            hmn1.birthDate = new DateTime(1990, 3, 4);
            hmn1.name = "Remzi";

            var hmn2 = new Human
            {
                name = "Can",
                birthDate = new DateTime(2000, 1, 3),
                isMarried = false
            };

            var d = new Animal();
            d.name = "Aloş";
            d.type = "dog";

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
