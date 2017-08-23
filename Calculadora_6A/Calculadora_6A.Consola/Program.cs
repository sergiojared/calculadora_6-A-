using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora_6A.Libreria;

namespace Calculadora_6A.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos misMetodos = new Metodos();
            Console.WriteLine(misMetodos.Saludo());
            Console.WriteLine(misMetodos.Sumar(10, 58));
            Console.WriteLine(misMetodos.Restar(50, 24));
            Console.WriteLine(misMetodos.Multiplicar(6, 5));
            Console.WriteLine(misMetodos.Dividir(8, 3));
            Console.ReadKey();
        }
    }
}
