using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicisCS
{
    class Branques
    {
        static void Main(string[] args)
        {
            Branques1();
        }
        private static void Branques1()
        {

            int num_int;
            double num_double;
            Boolean sortir = false;

            do
            {
                if (int.TryParse(Console.ReadLine(), out num_int))
                {
                    if (num_int < 0)
                    {
                        Console.WriteLine("Enter Negatiu");
                        sortir = true;
                    }
                    else
                    {
                        Console.WriteLine("Enter Positiu");
                        sortir = true;
                    }
                }
                else if (double.TryParse(Console.ReadLine(), out num_double))
                {
                    Console.WriteLine("doble");
                    if (num_double < 0)
                    {
                        Console.WriteLine("Enter Negatiu");
                        sortir = true;
                    }
                    else
                    {
                        Console.WriteLine("Enter Positiu");
                        sortir = true;
                    }
                }
                else
                {
                    Console.WriteLine("Escriu un numero");
                }
            } while (!sortir);

        }

        private static void Branques2()
        {
            int costat1 = Convert.ToInt32(Console.ReadLine());
            int costat2 = Convert.ToInt32(Console.ReadLine());
            int costat3 = Convert.ToInt32(Console.ReadLine());

            if ((costat1==costat2) && (costat2==costat3))
            {
                Console.WriteLine("Equilàter");

            }else if ((costat1 == costat2) || (costat1 == costat3))
            {
                Console.WriteLine("Isòsceles");
            }
            else
            {

                Console.WriteLine("Escalè");

            }


        }

        private static void Branques3()
        {

            Boolean sortir = false;

            do
            {
                try
                {
                    int any = Convert.ToInt32(Console.ReadLine());

                    if (any % 4 == 0)
                    {
                        Console.WriteLine("Any bisiesto");
                        sortir = true;
                    }
                    else
                    {
                        Console.WriteLine("No es un any bisiesto");
                        sortir = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Escriu un Any");
                }
            } while (!sortir);


        }
    }
}
