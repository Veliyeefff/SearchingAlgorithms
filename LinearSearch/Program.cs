using System;

namespace LİnearSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter lenght of array : ");
            int array_lenght = int.Parse(Console.ReadLine());
            int[] array = new int[array_lenght];
            int result = -1;

            
            for(int index = 0; index < array_lenght; index++)
            {
                Console.Write($"{index+1}.Element : ");
                array[index] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the number you are looking for : ");
            int number = int.Parse(Console.ReadLine());

            for(int index = 0; index < array_lenght; index++)
            {
                if(number == array[index])
                {
                    Console.WriteLine($"Number was found... \nIndex : {index}");
                    result = 1;
                    break;
                }
            }
            if(result == -1)
            {
                Console.WriteLine("Number wasn't found!!!");
            }
        }
    }
}
