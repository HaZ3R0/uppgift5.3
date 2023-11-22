using System;
namespace uppgift5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[3];
            Console.WriteLine("Skriv in 3 tal med mellanrum i mellan");
            string talen = Console.ReadLine();
            string[] x = talen.Split(' ');
            int a = int.Parse(x[0]);
            int b = int.Parse(x[1]);
            int c = int.Parse(x[2]);

            int sum = (a + b + c);
            Console.WriteLine(sum);
        }
    }
}