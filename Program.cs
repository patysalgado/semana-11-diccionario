namespace semana_11_diccionario
{
using System;
using System.Collections.Generic;

class program
{
        static Dictionary<string, string> diccionario = new Dictionary<string, string>()
    {
        {"time", "tiempo"},
        {"person", "persona"},
        {"year", "año"},
        {"way", "camino"},
        {"day", "día"},
        {"thing", "cosa"},
        {"man", "hombre"},
        {"world", "mundo"},
        {"life", "vida"},
        {"hand", "mano"},
        {"part", "parte"},
        {"child", "niño/a"},
        {"eye", "ojo"},
        {"woman", "mujer"},
        {"place", "lugar"},
        {"work", "trabajo"},
        {"week", "" +
                "semana"},
        {"case", "caso"},
        {"point", "punto"},
        {"government", "gobierno"},
        {"company", "empresa"}
    };

        static void Main()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("=======================================================");
                Console.WriteLine("1. Traducir una frase");
                Console.WriteLine("2. Ingresar más palabras al diccionario");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        TraducirFrase();
                        break;
                    case 2:
                        AgregarPalabra();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        break;
                }
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 0);
        }

        static void TraducirFrase()
        {
            Console.Write("\nIngrese la frase a traducir: ");
            string frase = Console.ReadLine().ToLower();
            string[] palabras = frase.Split(' ');

            for (int i = 0; i < palabras.Length; i++)
            {
                if (diccionario.ContainsKey(palabras[i]))
                {
                    palabras[i] = diccionario[palabras[i]];
                }
            }

            Console.WriteLine("\nSu frase traducida es: " + string.Join(" ", palabras));
        }

        static void AgregarPalabra()
        {
            Console.Write("\nIngrese la palabra en inglés: ");
            string palabraIngles = Console.ReadLine().ToLower();

            Console.Write("Ingrese su traducción en español: ");
            string palabraEspanol = Console.ReadLine().ToLower();

            if (!diccionario.ContainsKey(palabraIngles))
            {
                diccionario.Add(palabraIngles, palabraEspanol);
                Console.WriteLine("✅ Palabra agregada con éxito.");
            }
            else
            {
            }

            Console.WriteLine("⚠️ Esta palabra ya existe en el diccionario.");
        }
    }
}