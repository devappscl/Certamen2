using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certamen2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;


            //variable opcion
            int op = 0;

            Console.WriteLine("BIENVENIDX | SELECCIONE UNA OPCIÓN: ");
            Console.WriteLine("1. Resolución Problema 1");
            Console.WriteLine("2. Resolución Problema 2");
            Console.WriteLine("3. Resolución Problema 3");
            Console.WriteLine("");
            Console.WriteLine("Ingrese la opción:");
           
            

            try
            {
                op = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Debe ingresar solo numeros.");
                Console.Clear();
            }

            //Selector
            switch (op)
            {
                case 1:
                    Console.Clear();
                    Problema1();
                    break;
                case 2:
                    Console.Clear();
                    Problema2();
                    break;
                case 3:
                    Console.Clear();
                    Problema3();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Ingrese una opción válida");
                    Main(args);
                    break;
            }


            //Problema 1
            void Problema1()
            {


                // Tamaño del arreglo = 5
                int[] n = new int[5];

                //Auxiliar a, Consultar números
                int a = 0;


                //LLenar el arreglo
                while (a < n.Length)
                {

                    try
                    {
                        Console.WriteLine("Ingrese número {0}: ", a + 1);
                        n[a] = int.Parse(Console.ReadLine());
                        a++;
                        Console.Clear();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Debe ingresar solo numeros.");
                        Console.Clear();
                    }


                }

                // Imprimir el arreglo
                for (int i = 0; i < n.Length; i++)
                {
                    Console.Write("n{0} = {1} | ", i + 1, n[i]);

                }

                Console.WriteLine();

                //Ordenar el Arreglo de Menor a Mayor
                Array.Sort(n);



                bool flag = true;

                while (flag)
                {
                    try
                    {
                        // Consultar un número al usuario y mostrar los mayores a ese número
                        Console.WriteLine("Ingrese un número Mayor o Igual a {0} o Menor o Igual a {1}: ", n[0], n[4]);
                        op = int.Parse(Console.ReadLine());
                        if (op >= n[0] && op <= n[4])
                        {

                            flag = false;
                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Debe ingresar solo numeros.");
                        flag = true;
                    }

                }


                Console.WriteLine("Los valores mayores al valor ingresado por usted son: ");

                for (int i = 0; i < n.Length; i++)
                {
                    if (op < n[i])
                    {
                        Console.Write("| {0} |", n[i]);
                    }

                }

                Console.ReadKey();
                Console.Clear();
                Main(args);


            }


            //Problema 2
            void Problema2()
            {
                int[,] matriz = new int[30, 30];

                int a = matriz.GetLength(0) / 2;


                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (i == a  || i == a - 1)
                        {
                            matriz[i, j] = 1;
                        }
                        else if(j == a || j == a - 1)
                        {
                            matriz[i, j] = 1;
                        }
                        else
                        {
                            matriz[i, j] = 0;
                        }

                    }
                }

                imprimir(matriz);
                Console.ReadKey();
                Console.Clear();
                Main(args);
            }

            //Problema 3
            void Problema3()
            {

                // Tamaño del arreglo = 5
                int[] n = new int[10];
                Random rd = new Random();
               

                for (int i = 0; i < n.Length; i++)
                {
                    int rand_num = rd.Next(50, 200);
                    n[i] = rand_num;
                }


                int max = 0;
                int posmax = 0;
                int min = 200;
                int posmin = 0;
                // Imprimir el arreglo
                for (int i = 0; i < n.Length; i++)
                {
                    Console.WriteLine("posición {0} = {1} ", i, n[i]);

                    if(n[i] > max)
                    {
                        max = n[i];
                        posmax = i;

                    }
                    
                    if(n[i] < min){
                        min = n[i]; 
                        posmin = i;
                    }

                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Mínimo | Posición = "+ posmin + " | Valor = " + min);
                Console.WriteLine("Máximo | Posición = " + posmax + " | Valor = " + max);

                Console.ReadKey();
                Console.Clear();
                Main(args);
            }


            //Modulo imprimir matriz
            void imprimir(int[,] matriz)
            {

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }

                    Console.WriteLine();

                }
            }



            Console.ReadKey();
            
       

        }
    }

}
