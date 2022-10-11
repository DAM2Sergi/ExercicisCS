using System;

namespace ExercicisCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrius2();
        }


        public static void Matrius2()
        {

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(Console.ReadLine());
            int costat;

            int[] nums = { num1, num2, num3, num4, num5 };
            int[] array_desplaçat = new int[nums.Length];


            do
            {

                Console.WriteLine("Introdueix num depenent de el que vulguis fer");
                Console.WriteLine("1.-Esquerra");
                Console.WriteLine("2.-Dreta");
                Console.WriteLine("3.-Sortir");
                costat = Convert.ToInt32(Console.ReadLine());

                if(costat == 1)
                {

                    for (int e=0;e<nums.Length;e++)
                    {

                        if(e == nums.Length-1)
                        {
                        
                            array_desplaçat[4]= nums[0];
                            Console.WriteLine(array_desplaçat[e]);
                            continue;
                            
                        }
 
                        array_desplaçat[e] = nums[e + 1];
                        Console.WriteLine(array_desplaçat[e]);

                    }

                    for (int e = 0; e < nums.Length; e++)
                    {
                        
                        nums[e] = array_desplaçat[e];

                    }

                }

                if (costat == 2)
                {

                    for (int e = 0; e < nums.Length; e++)
                    {

                        if (e == nums.Length - 5)
                        {

                            array_desplaçat[0] = nums[4];
                            Console.WriteLine(array_desplaçat[e]);
                            continue;

                        }

                        array_desplaçat[e] = nums[e - 1];
                        Console.WriteLine(array_desplaçat[e]);

                    }

                    for (int e = 0; e < nums.Length; e++)
                    {

                        nums[e] = array_desplaçat[e];

                    }

                }

            } while (costat != 3);
        }

        public static void Matrius3()
        {

            Console.WriteLine("Quants numeros vols introduir?");

            int quantitat_num = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[quantitat_num];

            for (int i = 0; i <= quantitat_num; i++)
            {

                numeros[i] = Convert.ToInt32(Console.ReadLine());

                suma +numeros[i];
            }

        }

    }
}
