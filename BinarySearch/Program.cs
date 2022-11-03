using System;
using System.Reflection;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter lenght of array : ");
            int array_lenght = int.Parse(Console.ReadLine());
            int[] array = new int[array_lenght];
            int left = 0;
            int right = array_lenght-1;
            int middle;
            int result = -1;

            Console.WriteLine("Please enter sorted array!!!");

            for (int index = 0; index < array_lenght; index++)
            {
                Console.Write($"{index + 1}.Element : ");
                array[index] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the number you are looking for : ");
            int number = int.Parse(Console.ReadLine());

            while (left <= right)
            {
                middle = (left + right) / 2;

                if (array[middle] == number)
                {
                    Console.WriteLine($"Number was found \nIndex : {middle}");
                    result = 1;
                    break;
                }

                else if(array[middle] > number)
                {
                    right = middle - 1;
                }

                else
                {
                    left = middle + 1;                     
                }
            }
            if(result == -1)
            {
                Console.WriteLine("Number wasn't found!!!");
            }
        }
    }
}
