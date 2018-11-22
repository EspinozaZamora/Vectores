using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Control de Versiones ");
            Console.WriteLine("Control de Versiones1 ");
            Console.WriteLine("Control de Versiones2 ");
            Console.WriteLine("Control de Versiones3 ");
            Console.WriteLine("Control de Versiones4 ");
            Console.WriteLine("Control de Versiones5 ");
            Console.WriteLine("Probando Control de Versiones ");
            Console.WriteLine("3 elevado a la 4 es igual a : {0}", Potencia(3, 4));
            try
            {
                Console.WriteLine("-5 elevado a la 2 es igual a : {0}", Potencia(-5, 2));
            } catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }
            Console.WriteLine("2 elevado a la 5 es igual a : {0}", Potencia(2, 5));
            Calificacion(10);

            Console.ReadKey();
        }

        public static double Potencia(double x, double y)
        {
            if(x <= 0)
            {
                throw new Exception(" X debe ser Positivo..");
            }
            if (y <= 0 )
            {
                throw new Exception(" Y debe ser Positivo..");
            }

            double p = 1;
            for (int i = 1; i <= y; i++)
            {
                p = p * x;
                
            }
            return p;
        }
        public static float Calificacion(float c)
        {
            int x = 2;
            if (c > 0 && c < 5)
                Console.WriteLine("\nsuspenso");
            else
                 if (c > 4 && c < 6.6)
                Console.WriteLine("\naprovado");
            else
                 if (c > 6.4 && c < 8.6)
                Console.WriteLine("\nNotable");
            else
                 if (c > 8.4 && c < 10)
                Console.WriteLine("\nsobresaliente");
            else
                 if (c == 10)
                Console.WriteLine("\nMatricula de Honor");
            return (x);
        }
    }
}
