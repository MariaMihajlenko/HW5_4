//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5
using System;
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int s = 123;
        int[] a = new int[s];
        for (int i = 0; i < s; i++)
            a[i] = random.Next(100);
 Console.Write("[");
          { for (int i = 0; i <  s; i++)
            Console.Write($"{" " }{+ a[i]}{","}");
          }
          Console.Write("]");
          int result = 0;
        for (int i = 0; i < s; i++)
        {
            if (a[i] > 9 && a[i]<100) 
            result= result+1;
          
        }
    
        Console.WriteLine("  ");
        Console.WriteLine("  ");
        Console.Write(result);
        
    }

}
