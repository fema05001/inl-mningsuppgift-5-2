using System;
namespace Uppgift_5_2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många heltal vill du skriva in?");
            string a = Console.ReadLine();
            int b = int.Parse(a);
            int[] c = new int[b];
            Console.WriteLine(" ");
            Console.WriteLine("Skriv in " + b + " Heltal");
            for (int i = 0; i < b; i++)
            {

                string s = Console.ReadLine();
                int f = int.Parse(s);
                c[i] = f;


            }
            Console.WriteLine(" ");
            Console.WriteLine("Här är talen du skrev in.");
            for (int j = 0; j < b; j++)
            {
                Console.Write("Tal " + (j + 1) + ":");
                Console.WriteLine(c[j]);

            }
        }

    }
}