using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            string x;
            int y;
            double z;
            char w;

            Console.WriteLine("Informe o X - string: ");
            x = Console.ReadLine();

            Console.WriteLine("Informe o Y inteiro: ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o z double: ");
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o w: ");
            w = char.Parse(Console.ReadLine());

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(w);

            Console.ReadLine();
        }
    }
}
