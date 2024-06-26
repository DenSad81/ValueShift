using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[5] { 1, 2, 3, 4, 5 };

        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");

        Console.WriteLine();
        Console.Write("Введите смещение: ");
        int numberOfShift = Convert.ToInt32(Console.ReadLine());

        for (int j = 0; j < numberOfShift % array.Length; j++)
        {
            int tempElement = array[0];

            for (int i = 0; i < array.Length - 1; i++)
                array[i] = array[i + 1];

            array[array.Length - 1] = tempElement;
        }

        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");

        Console.WriteLine();
    }
}