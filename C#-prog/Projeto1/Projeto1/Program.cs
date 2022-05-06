using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            SByte n1 = 100;
            int   n2 = 1000;
            int   n3 = 2147483647;
            long n4 = 21474836471816;

            bool completo = false;
            char genero = 'F';

            char letra = '\u0041';

            float n5 = 4.5f;
            double n6 = 4.55;

            string nome = "Maria";

            object m1 = "Rogerio"; //variavel object recebe qualquer informação
            object m2 = 4.55f;

            int m5 = int.MinValue;
            int m6 = int.MaxValue;

            Console.WriteLine(nome);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(letra);

            n1++;

            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
        }
    }
}
