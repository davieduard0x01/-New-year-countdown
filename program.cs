using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            for (int i = 0; i <= 9; i++)
            {
                cont++;
                Console.WriteLine(cont + "\n");
                if (cont == 10)
                {
                    Console.WriteLine("Feliz Ano Novo!");
                  
                }



            }
            Console.ReadKey();
        }
    }
}
