using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetoresCS
{
    internal class ClassificacaoString
    {
        public static void Main(string[] args)
        {
            string[] carros = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(carros);
            foreach (string i in carros)
            {
                Console.WriteLine(i);
            }
        }
    }
}
