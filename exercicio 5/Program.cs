using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i+=2)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("Esses são os numeros pares entre 1 e 100");
            
            Console.ReadKey();
        }
    }
}
