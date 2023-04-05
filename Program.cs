using System;

namespace CsE23
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCÍCIO 23
            Console.Write("Achando os divisores\n\nInforme um valor: ");
            int N = int.Parse(Console.ReadLine());
            int divisores;
            
            for (int i = 1; i <= N; i++)
            {
                if(N % i == 0)
                    Console.WriteLine("\nDivisores:" + i);
            }
            Console.WriteLine("\nFim do Programa!\n");
        }
    }
}
