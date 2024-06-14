using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetoresCS
{
    internal class ExemploClassificacaoLinq
    {
        public static void Main(string[] args)
        {
            int [] numeros = { 5, 1, 8, 9 };
            Console.WriteLine(numeros.Max()); //Retorna o menor valor
            Console.WriteLine(numeros.Min()); //Retorna o maior valor
            Console.WriteLine(numeros.Sum()); //Retorna a soma dos valores
        }
    }
}
