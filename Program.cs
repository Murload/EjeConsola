using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int i;
            int seleccion = 1;
            while (seleccion != 0)
            {
                Console.WriteLine("Escribe {1} para ir al programa (1)");
                Console.WriteLine("Escribe {2} para ir al programa (2)");
                Console.WriteLine("Escribe {3} para ir al programa (3)");
                Console.WriteLine("Escribe {4} para ir al programa (4)");
                Console.WriteLine("Escribe {5} para ir al programa (5)");
                Console.WriteLine("Escribe {6} para ir al programa (6)");
                Console.WriteLine("Escribe {7} para ir al programa (7)");
                Console.WriteLine("Escribe {8} para ir al programa (8)");
                seleccion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (seleccion)
                {
                    case 1:
                        Console.WriteLine("Digita un número");
                        int cpar;
                        num = Convert.ToInt32(Console.ReadLine());

                        cpar = num % 2;

                        if (cpar == 0)
                        {
                            Console.WriteLine("El nùmero " + num + " es par");
                        }
                        else
                        {
                            Console.WriteLine("El nùmero " + num + " es impar");
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        int mul;
                        Console.WriteLine("Digite un numero:");
                        num = Convert.ToInt32(Console.ReadLine());

                        for (i = 1; i <= 10; i++)
                        {
                            mul = num * i;
                            Console.WriteLine(+num + "x" + i + "=" + mul);
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        int cal;
                        int j;
                        for (i = 2; i <= 10; i++)
                        {
                            for (j = 1; j <= 10; j++)
                            {
                                cal = i * j;

                                Console.WriteLine(i + "x" + j + "=" + cal);

                            }
                            Console.WriteLine("");
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        {
                            Console.WriteLine("Escribe el numero que deseas sabes si es primo o no");
                            int numero, cont = 0;
                            numero = Convert.ToInt32(Console.ReadLine());


                            for (i = 1; i <= numero; i++)
                            {
                                if (numero % i == 0)
                                {
                                    cont = cont + 1;
                                }
                            }
                            if (cont > 2)
                            {
                                Console.WriteLine("Este numero no es primo");

                            }
                            else
                            {
                                Console.WriteLine("Este numero es primo");
                            }


                            Console.ReadKey();
                            Console.Clear();

                        }
                        break;
                    case 5:
                        {

                            int[] edad = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                            int a;



                            for (i = 0; i < 9; i++)
                            {
                                for (j = 0; j < 9; j++)
                                {
                                    if (edad[j] > edad[j + 1])
                                    {
                                        a = edad[j + 1];
                                        edad[j + 1] = edad[j];
                                        edad[j] = a;

                                    }
                                }

                            }
                            foreach (int n in edad)
                            {
                                Console.Write(n + "-");

                            }


                            Console.ReadKey();
                            Console.Clear();




                        }
                        break;
                    case 6:
                        {
                            string nombre1;
                            int[] edad = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                            string[] nombre = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
                            Console.WriteLine("Ingrese el nombre de la persona la cualquiere buscar:");
                            nombre1 = Console.ReadLine();
                            bool a = false;

                            for (i = 0; i < nombre.Length; i++)
                            {
                                if (nombre[i] == nombre1)
                                {
                                    a = true;
                                    if (a == true)
                                    {
                                        Console.WriteLine("LA PERSONA " + nombre1 + " FUE ENCONTRADA");
                                    }



                                }
                            }

                            Console.ReadKey();
                            Console.Clear();

                        }
                        break;
                    case 7:
                        {

                            int[] edad = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                            string[] nomb = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
                            Console.WriteLine("\n los vectores registrados son: \n");
                            Console.WriteLine("      Nombre  |  Edad");
                            for (int y = 0; y <= 9; y++)
                            {
                                Console.WriteLine("      " + nomb[y] + " -->   " + edad[y]);
                            }
                            int H = edad.Length;
                            for (int l = 1; l < H; l++)
                            {
                                for (int k = 0; k < H - l; k++)
                                {
                                    if (edad[k] > edad[k + 1])
                                    {
                                        int temp = edad[k];
                                        string temp2 = nomb[k];
                                        edad[k] = edad[k + 1];
                                        nomb[k] = nomb[k + 1];
                                        edad[k + 1] = temp;
                                        nomb[k + 1] = temp2;
                                    }
                                }
                            }
                            Console.WriteLine("\n Las edades y nombres ordenadas del menor al mayor son: \n");
                            Console.WriteLine("      Nombre  |  Edad");

                            for (int z = 0; z <= 9; z++)
                            {
                                Console.WriteLine("      " + nomb[z] + " -->   " + edad[z]);
                            }
                            Console.WriteLine("\n     --------------------//--------------------\n");
                            Console.ReadLine();







                            Console.ReadKey();
                            Console.Clear();

                        }
                        break;
                    case 8:

                        Console.Write("\n ingrese el palabra:  ");
                        String palindromo = (Console.ReadLine());
                        char[] PolidromoArray = palindromo.ToCharArray();
                        String contrario = "";
                        for (int f = PolidromoArray.Length - 1; f >= 0;f--)
                        {
                            contrario += PolidromoArray[f];
                        }
                        if (palindromo == contrario)
                        {
                            Console.WriteLine("\n    La palabra " + palindromo + ", Es palindromo");
                            Console.WriteLine("\n     --------------------//--------------------\n");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("\n    La palabra " + palindromo + ", no es palindromo");
                            Console.WriteLine("\n    Su inverso es: " + contrario);
                            Console.ReadLine();
                        }


                        Console.ReadKey();
                        Console.Clear();
                        break;


                    default:
                        {
                            Console.WriteLine("ESCRIBIO UN NUMERO NO PERMITIDO. REINTENTAR");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;


                }
            }
        }
    



    }
}
