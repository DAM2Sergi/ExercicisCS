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

            int[] nums = { num1, num2, num3, num4, num5 };

            for (int i=0; i<=nums.Length;i++)
            {

                Console.WriteLine(nums[i]);

                nums[i + 1] = nums[i];

            }



        }

        public static void Matrius3()
        {

            Console.WriteLine("Quants numeros vols introduir?");

            int quantitat_num = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[quantitat_num];

            for (int i = 0; i <= quantitat_num; i++)
            {

                numeros[i] = Convert.ToInt32(Console.ReadLine());

            }

        }

    }
}
