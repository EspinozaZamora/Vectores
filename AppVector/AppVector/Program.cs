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

            vectorInicializar();
            Vectores();
            Vectores1();

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

        public static void vectorInicializar()
        {
            int suma = 0;
            double Promedio;
            int[] x = new int[8];
            x[0] = 10;
            x[1] = 2;
            x[2] = 20;
            x[3] = 8;
            x[4] = 15;
            x[5] = 1;
            x[6] = -9;
            x[7] = 14;
            //imprimir el vector
            Console.WriteLine("\n Elementos del Vector \n======================\n");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Elemento indice {0} --> {1}", (i + 1), x[i]);
            }
            for (int i = 0; i < x.Length; i++)
            {
                suma = suma + x[i];
            }
            Promedio = suma / x.Length;
            Console.WriteLine("-------------------------");
            Console.WriteLine("La suma de todos los valores es: {0}", suma);
            Console.WriteLine("El Promedio de es es: {0}", (double)Promedio);





        }
        public static void Vectores()
        {
            int num;
            int may = 0;
            int[] x = new int[10];
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero");
                    num = int.Parse(Console.ReadLine());
                    x[i] = num;
                }
                while (num < 0 || num > 1001);
                if (may <= x[i])
                {
                    may = x[i];
                }
            }
             Console.WriteLine("El Promedio de es es: {0}", may);
        }
        public static void Vectores1()
        {
            int num;
            int men = 500000;
            int[] x = new int[10];
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero");
                    num = int.Parse(Console.ReadLine());
                    x[i] = num;
                }
                while (num < 0 || num > 1001);
                if (may >= x[i])
                {
                    may = x[i];
                }
            }
             Console.WriteLine("El Promedio de es es: {0}", may);
        }
       
        
    }
}
