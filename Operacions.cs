using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicisCS
{
    class Operacions
    {
        public static void MenuOperacions()
        {
            bool sortir = false;

            do
            {

                Console.WriteLine("||--------------------------------------||");
                Console.WriteLine("||\tMenu Operacions\t\t\t||");
                Console.WriteLine("||\tEscull una opcio:\t\t||");
                Console.WriteLine("||\t\t\t\t\t||");
                Console.WriteLine("||\t1.-Operacions1\t\t\t||");
                Console.WriteLine("||\t2.-Operacions2\t\t\t||");
                Console.WriteLine("||\t3.-Sortir\t\t\t||");
                Console.WriteLine("||\t\t\t\t\t||");
                Console.WriteLine("||--------------------------------------||");


                int menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {

                    case 1:
                        Operacions1();
                        break;

                    case 2:
                        Operacions2();
                        break;

                    case 3:
                        sortir = true;
                        break;

                }

            } while (!sortir);
        }

        private static void Operacions1()
        {

        }
        private static void Operacions2()
        {

        }
    }
}
