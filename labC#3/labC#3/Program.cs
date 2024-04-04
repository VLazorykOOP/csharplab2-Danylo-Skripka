using System;

class Program
{
    static void Main()
    {
        // Введення розмірності квадратної матриці
        Console.Write("Введіть розмірність квадратної матриці: ");
        int n = int.Parse(Console.ReadLine());

        // Ініціалізація матриці
        int[,] matrix = new int[n, n];

        // Введення елементів матриці
        Console.WriteLine("Введіть елементи квадратної матриці:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Елемент [{i + 1},{j + 1}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Ініціалізація вектора
        int[] vectorX = new int[n];

        // Введення елементів вектора
        Console.WriteLine("Введіть елементи вектора X:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Елемент [{i + 1}]: ");
            vectorX[i] = int.Parse(Console.ReadLine());
        }

        // Обчислення A * X
        int[] result = Multiply(matrix, vectorX);

        // Виведення результату
        Console.WriteLine("Результат множення A * X:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Елемент [{i + 1}]: {result[i]}");
        }

        Console.ReadLine();
    }

    // Метод для множення матриці на вектор
    static int[] Multiply(int[,] matrix, int[] vector)
    {
        int n = matrix.GetLength(0);
        int[] result = new int[n];

        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < n; j++)
            {
                sum += matrix[i, j] * vector[j];
            }
            result[i] = sum;
        }

        return result;
    }
}
