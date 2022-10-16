using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicisCS
{
    class Bucles
    {

        static void Main(string[] args)
        {
            Bucles3();
        }

        private static void Bucles1()
        {

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int suma = 0;
            if (num1>num2)
            {
                for (int i = num2; i <= num1; i++)
                {

                    suma = suma + i;

                    Console.WriteLine(suma);
                }
            }
            else
            {
                for (int i = num1; i <= num2; i++)
                {

                    suma = suma + i;

                    Console.WriteLine(suma);
                }
            }



        }

        private static void Bucles2()
        {

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int suma = 0;


            if (num1 > num2)
            {
                for (int i = num2; i <= num1; ++i)
                {
                    string stg_num = Convert.ToString(i);
                    int num_final = Convert.ToInt32(stg_num.Substring(stg_num.Length - 1));



                    if (i == num_final)
                    {
                        suma = suma + i;
                    }

                    Console.WriteLine(i + "|" + suma);
                }
            }
            else
            {
                for (int i = num1; i <= num2; ++i)
                {

                    string stg_num=Convert.ToString(i);
                    int num_final=Convert.ToInt32(stg_num.Substring(stg_num.Length-1));

                    if (i == num_final)
                    {
                        suma = suma + i;
                    }

                    Console.WriteLine(i + "|" + suma);

                }
            }


        }


        private static void Bucles3()
        {

            Console.Write("Eentra un numero");
            int rows = Convert.ToInt32(Console.ReadLine());

            string linia="";
            int cont = 1;


            for (int i = 1; i <= rows; i++)
            {
                linia = "";

                for (int j = 1; j <= i; j++)
                {
                    
                    linia+="|" + cont;


                    cont++;
                    
                }

                Console.WriteLine(linia);
            }

        }

    }
}