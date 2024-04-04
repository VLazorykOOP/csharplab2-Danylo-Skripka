using System;

class Program
{
    static void Main(string[] args)
    {
        // Запитуємо користувача про розмірність масиву
        Console.Write("Введіть розмірність масиву: ");
        int size = int.Parse(Console.ReadLine());

        // Ініціалізуємо масив зазначеного розміру
        int[] array = new int[size];

        // Заповнюємо масив користувацькими значеннями
        for (int i = 0; i < size; i++)
        {
            Console.Write("Введіть елемент масиву {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        // Знаходимо максимум з модулів елементів
        int maxAbs = int.MinValue;
        foreach (int num in array)
        {
            int abs = Math.Abs(num);
            if (abs > maxAbs)
            {
                maxAbs = abs;
            }
        }

        // Виводимо знайдений максимум
        Console.WriteLine("Максимум з модулів елементів: " + maxAbs);

        Console.ReadLine();
    }
}
