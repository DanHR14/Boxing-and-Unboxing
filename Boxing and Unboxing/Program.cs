using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_and_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //boxing
            int valor = 49867;
                        
            object boxing = valor;

            valor = 25;

            Console.WriteLine("BOXING");
            Console.WriteLine("-----------");
            Console.WriteLine("El valor de la variable valor es {0}", valor);
            Console.WriteLine("El valor de la variable boxing es {0}", boxing);
            Console.Read();

            //unboxing
            object unboxing = 1234;

            int ub = (int)unboxing;

            Console.WriteLine("UNBOXING");
            Console.WriteLine("----------");
            Console.WriteLine("El valor de la variable unboxing es {0}", unboxing);
            Console.WriteLine("El valor de la variable ub es {0}", ub);
            Console.Read();

        
        }
    }
}
