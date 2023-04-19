using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 5; 
            int[] arr = new int[size]; 
            Random rand = new Random(); 
    
            for (int i = 0; i < size; i++) 
            {
                arr[i] = rand.Next(1, 101); 
            }

            Console.Write("Массив: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.Write("\n \n");
            
            int max = arr[0];
            for (int i = 1; i < size; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Максимальное значение (цикл): " + max);

            max = arr.Max();
            Console.WriteLine("Максимальное значение (функция): " + max);

            int min = arr[0];
            for (int i = 1; i < size; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.Write("\n \n");
            Console.WriteLine("Минимальное значение (цикл): " + min);

            min = arr.Min();
            Console.WriteLine("Минимальное значение (функция): " + min);

            Console.Write("\n \n");

            double average = arr.Average();
            Console.WriteLine("Среднее значение: " + average);

            Console.Write("Введите число для поиска: ");
            int search = int.Parse(Console.ReadLine());
            int index = -1;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == search)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine("Индекс элемента: " + index);

            Console.Write("\n \n");

            int count = 0;
            for (int i = 0; i < size; i++)
            {
                count++;
            }
            Console.WriteLine("Количество элементов (цикл): " + count);

            count = arr.Length;
            Console.WriteLine("Количество элементов (функция): " + count);

            Console.Write("\n \n");

            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Сумма значений (цикл): " + sum);

            sum = arr.Sum();
            Console.WriteLine("Сумма значений (функция): " + sum);

            Console.Write("\n \n");

            int product = 1;
            for (int i = 0; i < size; i++)
            {
                product *= arr[i];
            }
            Console.WriteLine("Произведение значений (цикл): " + product);

            product = arr.Aggregate((a, b) => a * b);
            Console.WriteLine("Произведение значений (функция): " + product);

            Console.Write("\n \n");

            // чиним копирование массивов

            int[] arr1= new int[] { 1, 2, 3, 4, 5 }; 
            int[] arr2 = new int[arr1.Length]; 
            Array.Copy(arr1, arr2, arr1.Length); 
            arr2[0] = 3;

            Console.WriteLine(arr1[0] + " " + arr2[0]);


        }
    }
}
