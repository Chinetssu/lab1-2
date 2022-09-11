using System;

namespace lab1_2
{
    public class Logic
    {
        public static string Search(int amount, int[] sequence)
        {
            string result;
            int adds = -1;
            int prev = sequence[0];
            for (int i = 1; i < amount; i++)
            {
                if (sequence[i] == prev)
                {
                    adds = i;
                }
                prev = sequence[i];
            }
            if (adds == -1)
            {
                result = "Пары одинаковых соседних чисел нет";
            }
            else
            {
                result = "Пара одинаковых соседних чисел найдена \r\n Их порядковые номера: " + adds + " и " + (adds + 1);
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Дана последовательность натуральных чисел. Определить, есть ли в последовательности хотя бы одна
            // n-ка одинаковых “соседних” чисел (n и элементы последовательности вводятся с клавиатуры).
            //В случае положительного ответа определить порядковые номера чисел первой из таких пар.
            int amount;
            Console.WriteLine("Введите колличество чисел");
            amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите последовательность чисел через Enter:");
            int[] sequence = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                sequence[i] = int.Parse(Console.ReadLine());
            }
            Console.Write(Logic.Search(amount,sequence));
        }
    }
}
