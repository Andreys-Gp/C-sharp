using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_impares.net2
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*int acum = 0;
            for ( int i=0,i<100,i++) 
            { 
                if (int i%2 !=0) {
                int conta = acum + 1;
                Console.Write("(0)", i, "numeros total impares",conta);
               
               } 
            }
           Console.Write("\n \n");
        }*/

            int i, impar = 0, par = 0;

            for (i = 0; i < 100; i++)
            { 
                if (i % 2 != 0)
                {
                    impar++;
                    Console.Write("(0)", i, impar);
                    
                }
            }
             Console.Write('\n');
        }
    }
}