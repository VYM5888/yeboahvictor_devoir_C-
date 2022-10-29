// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main()
    {
        int i;
        int[] a = new int[30];   
        Console.Write("saisir le nombre de values: ");
          
        int n = Convert.ToInt16(Console.ReadLine());
        
        for (i = 1; i <= n; i++)
        {
            Console.Write("Enterer No " + i + ":");
              
            a[i] = Convert.ToInt16(Console.ReadLine());
        }
         
        for (i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
          
        Console.Write("ordre : ");
        for (i = 1; i <= n; i++)
        {
            Console.Write(a[i] + " ");
        }
        
        Console.ReadKey();
    }
}
