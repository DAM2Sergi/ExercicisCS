using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicisCS
{
    class Menu
    {

        static void Main(string[] args)
        {

            bool sortir = false;

            do
            {

                Console.WriteLine("||--------------------------------------||");
                Console.WriteLine("||\tMenu de Gestió de la Lliga\t||");
                Console.WriteLine("||\tEscull una opcio:\t\t||");
                Console.WriteLine("||\t\t\t\t\t||");
                Console.WriteLine("||\t1.-Branques\t\t\t||");
                Console.WriteLine("||\t2.-Operacions\t\t\t||");
                Console.WriteLine("||\t3.-Bucles\t\t\t||");
                Console.WriteLine("||\t4.-Matrius\t\t\t||");
                Console.WriteLine("||\t5.-Cadenes\t\t\t||");
                Console.WriteLine("||\t6.-Classes, Funcions\t\t||");
                Console.WriteLine("||\t7.-Exercicis Finals\t\t||");
                Console.WriteLine("||\t8.-Sortir\t\t\t||");
                Console.WriteLine("||\t\t\t\t\t||");
                Console.WriteLine("||--------------------------------------||");


                int menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {

                    case 1:
                        Branques.MenuBranques();
                        break;

                    case 2:
                        break;

                    case 3:
                        Bucles.MenuBucles();
                        break;

                    case 4:
                        Matrius.MenuMatrius();
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    case 8:
                        sortir = true;
                        break;

                }

            } while (!sortir);

        }

    }
}
