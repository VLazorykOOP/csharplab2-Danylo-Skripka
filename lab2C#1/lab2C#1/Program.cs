using System;

class Program
{
    static void Main(string[] args)
    {
        // Визначення розміру масиву
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Елементи масиву, які не діляться на 3 і 2:");

        // Ітеруємося по елементах масиву
        for (int i = 0; i < array.Length; i++)
        {
            // Перевіряємо, чи число не ділиться на 3 і 2
            if (array[i] % 3 != 0 && array[i] % 2 != 0)
            {
                Console.WriteLine("Елемент {0}: {1}", i, array[i]);
            }
        }

        Console.ReadLine();
    }
}
