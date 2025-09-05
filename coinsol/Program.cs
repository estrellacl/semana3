using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coinsol
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ejer1();
            Console.ReadKey();//relizando detenemiento de consola 
        }
        static void ejer1()

        {
            string nombre, carrera;

            Console.Write("INGRESE SU NOMBRE:");
            nombre = Console.ReadLine();

            Console.Write("ingrese su carrera:");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre},bienvenido al curso FA DE {carrera}");
        }
         
        static void ejer2()
        {
            Console.WriteLine("\"tella\"");
        }
    
    }

}
