using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetoresCS
{
    internal class ClassificacaoInt
    {
        public static void Main(string[] args)
        {
            int [] numeros = { 1, 5, 2, 9 };
            Array.Sort(numeros);
            foreach (int i in numeros) 
            { 
                Console.WriteLine(i);
            }
        }
    }
}
