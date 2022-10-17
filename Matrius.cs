using System;

namespace ExercicisCS
{
    class Matrius
    {
        public static void MenuMatrius()
        {
            bool sortir = false;

            do
            {

                Console.WriteLine("||--------------------------------------||");
                Console.WriteLine("||\tMenu Matrius\t\t\t||");
                Console.WriteLine("||\tEscull una opcio:\t\t||");
                Console.WriteLine("||\t\t\t\t\t||");
                Console.WriteLine("||\t1.-Matrius1\t\t\t||");
                Console.WriteLine("||\t2.-Matrius2\t\t\t||");
                Console.WriteLine("||\t3.-Matrius3\t\t\t||");
                Console.WriteLine("||\t4.-Matrius4\t\t\t||");
                Console.WriteLine("||\t5.-Sortir\t\t\t||");
                Console.WriteLine("||\t\t\t\t\t||");
                Console.WriteLine("||--------------------------------------||");


                int menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {

                    case 1:
                        Matrius1();
                        break;

                    case 2:
                        Matrius2();
                        break;

                    case 3:
                        Matrius3();
                        break;

                    case 4:
                        Matrius4();
                        break;

                    case 5:
                        sortir = true;
                        break;

                }

            } while (!sortir);
        }

        public static void Matrius1()
        {
            int[] arrayaleatori = new int[5];

            for (int i = 0; i < (arrayaleatori.Length); i++)
            {

                arrayaleatori[i] = Convert.ToInt32(Console.ReadLine());

            }

            Random randNum = new Random();

            for (int i = 0; i < arrayaleatori.Length; i++)
            {
                arrayaleatori[i] = randNum.Next();
                Console.WriteLine(arrayaleatori[i]);
            }
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

            Array.Sort(numeros);

            int suma=0;
            int mitjana = 0;

            for (int i = 0; i < quantitat_num; i++)
            {

                numeros[i] = Convert.ToInt32(Console.ReadLine());

                suma +=numeros[i];

            }

            int media = 0;
            if((quantitat_num%2)==0)
            {

               int op1_media=numeros[quantitat_num/2];
               int op2_media = numeros[(quantitat_num/2)-1];

                media = (op1_media + op2_media) / 2;
            }
            else
            {
                media = quantitat_num / 2;


            }


            mitjana = suma / numeros.Length;

            int moda = 0;

            for (int i = 0; i < quantitat_num; i++)
            {
                int cops_rep = 0;
                moda = 0;

                for (int j = 0; j < quantitat_num; j++)
                {

                    if(numeros[j]==numeros[i])
                    {
                        cops_rep++;
                        moda = numeros[i];
                    }
                    else
                    {

                    }

                }

            }

            Console.WriteLine(mitjana + "|" + moda + "|" + media);


        }

        public static void Matrius4()
        {

            int[,] operador1 = new int[3, 3];

            Console.WriteLine("\n#####Array 1######\n");

            for (int i = 0; i < operador1.GetLength(0); i++)
            {
                Console.WriteLine("\nFilera " + i + "\n");

                for (int j = 0; j < operador1.GetLength(1); j++)
                {
                    operador1[i, j]= Convert.ToInt32(Console.ReadLine());
                }
                
            }

            Console.WriteLine("\n#####Array 2######\n");

            int[,] operador2 = new int[3, 3];

            for (int i = 0; i < operador2.GetLength(0); i++)
            {
                Console.WriteLine("\nFilera " + i + "\n");
                for (int j = 0; j < operador2.GetLength(1); j++)
                {
                    operador2[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            Console.WriteLine("\n##### Resultat ######\n");

            int[,] resultat = new int[3, 3];

            for (int i = 0; i < resultat.GetLength(0); i++)
            {
                Console.WriteLine("Fila" + i);
                for (int j = 0; j < operador2.GetLength(1); j++)
                {
                    
                    resultat[i, j] = operador1[i, j] + operador2[i, j];
                    Console.WriteLine(resultat[i, j]);
                }
               
            }

        }
    }
}
