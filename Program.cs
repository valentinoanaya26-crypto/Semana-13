using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CasoTema7
{
    internal class Program
    {
        static public void numero_naturales()
        {
            Console.Write("Ingresar numero de N: ");
            int N = int.Parse(Console.ReadLine());
            int S = 0;
            for (int c = 1; c <= N; c++)
            {
                S = S + c;
            }
            Console.WriteLine("La suma es: " + S);
        }


        static public int sumaNN_con_recursividad(int N)
        {
            if (N == 0)
            {
                return 0;
            }
            else
            {
                return N + sumaNN_con_recursividad(N - 1);
            }
        }


        static public int sumaNP_con_recursividad(int N)
        {
            if (N == 0)
            {
                return 0;
            }
            else
            {
                return (2 * N) + sumaNP_con_recursividad(N - 1);
            }
        }


        static public long factorial(int N)
        {
            if (N == 0 || N == 1)
            {
                return 1;
            }
            else
            {
                return N * factorial(N - 1);
            }
        }


        static public int potencia(int B, int exp)
        {
            if (exp == 0)
            {
                return 1;
            }
            else
            {
                return B * potencia(B, exp - 1);
            }
        }


        static public void conteo_regresivo(int N)
        {
            if (N < 0)
            {
                return;
            }
            else
            {
                Console.WriteLine(N);
                conteo_regresivo(N - 1);
            }
        }


        static public int suma_arreglos(int[] numeros, int indice)
        {
            if (indice >= numeros.Length)
            {
                return 0;
            }
            return numeros[indice] + suma_arreglos(numeros, indice + 1);
        }

        static void Main(string[] args)
        {
            int opc;
            bool valor = true;
            while (valor)
            {
                Console.Clear();
                Console.WriteLine("************************");
                Console.WriteLine("\tMenu de opciones");
                Console.WriteLine("************************");
                Console.WriteLine("[1]. Suma de N numeros naturales");
                Console.WriteLine("[2]. Suma de N numeros naturales con recursividad");
                Console.WriteLine("[3]. Suma de N numeros pares con recursividad");
                Console.WriteLine("[4]. Factorial");
                Console.WriteLine("[5]. Potencia de B^exp con recursividad");
                Console.WriteLine("[6]. Conteo regresivo con recursividad");
                Console.WriteLine("[7]. Arreglos");
                Console.WriteLine("[8]. Salir");
                Console.Write("\nIngrese una opcion: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        numero_naturales();
                        break;
                    case 2:
                        Console.Write("Ingresar numero N: ");
                        int N = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma es: " +
                          sumaNN_con_recursividad(N));
                        break;
                    case 3:
                        Console.Write("Ingresar cantidad de numeros pares: ");
                        int N2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma de los pares es: " +
                          sumaNP_con_recursividad(N2));
                        break;
                    case 4:
                        Console.Write("Ingresar numero N: ");
                        int N3 = int.Parse(Console.ReadLine());
                        if (N3 < 0)
                        {
                            Console.WriteLine("No existe factorial para numeros negativos.");
                        }
                        else
                        {
                            Console.WriteLine("El factorial es: " +
                              factorial(N3));
                        }
                        break;
                    case 5:
                        Console.Write("Ingresar base B: ");
                        int B = int.Parse(Console.ReadLine());
                        Console.Write("Ingresar exponente exp: ");
                        int exp = int.Parse(Console.ReadLine());
                        if (exp < 0)
                        {
                            Console.WriteLine("Ingrese un exponente no negativo.");
                        }
                        else
                        {
                            Console.WriteLine("El resultado es: " +
                              B + "^" + exp + " = " + potencia(B, exp));
                        }
                        break;
                    case 6:
                        Console.Write("Ingresar numero N: ");
                        int N4 = int.Parse(Console.ReadLine());
                        conteo_regresivo(N4);
                        break;
                    case 7:
                        Console.WriteLine("Arreglos");
                        break;
                    case 8:
                        valor = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                if (valor)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}