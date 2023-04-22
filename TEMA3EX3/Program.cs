using System;
//Scrieti o functie care va determina daca un numar este sau nu patrat perfect. Apelati-o si afisati-i rezultatu
namespace TEMA3EX3
{
    class Program
    {
        public static bool EstePatratPerfect(int numar)
        {
            if (numar < 0)
            {
                return false;
            }

            int radacinaPatrata = (int)Math.Sqrt(numar);
            return radacinaPatrata * radacinaPatrata == numar;
        }

        static void Main(string[] args)
        {
            int numar = int.Parse(Console.ReadLine());
            bool estePatratPerfect = EstePatratPerfect(numar);

            if (estePatratPerfect)
            {
                Console.WriteLine("patrat perfect.");
            }
            else
            {
                Console.WriteLine(" nu e un patrat perfect.");
            }
        }
    }
}