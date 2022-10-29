// See https://aka.ms/new-console-template for more information
using System;
public class PrimeNumberExample
{
    public static void Main(string[] args)
    {
        int n, i, m = 0, flag = 0;
        Console.Write("saisit une nombre: ");
        n = int.Parse(Console.ReadLine());
        m = n / 2;
        for (i = 2; i <= m; i++)
        {
            if (n % i == 0)
            {
                Console.Write("le nombre n'est pas premier .");
                flag = 1;
                break;
            }
        }
        if (flag == 0)
            Console.Write("le nombre est premier.");
    }
}