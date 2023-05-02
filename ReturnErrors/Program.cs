using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Msimango KSI
namespace ReturnErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DecoratePlanet("Mars"));
            Console.WriteLine("Is Pluto really a dwarf...?");
            Console.WriteLine(IsPlutoADwarf());
            Console.WriteLine("Then how many planets are there in the galaxy...?");
            Console.WriteLine(CountThePlanets());
        }

        static string DecoratePlanet(string planet)//return a string
        {
            return $"*..*..* Welcome to {planet} *..*..*";
        }

        static bool IsPlutoADwarf()//return boolean value
        {
            bool answer = true;
            return answer;
        }

        static int CountThePlanets()//return integer count
        {
            return 8;
        }
    }
}
