using System;

class Program
{
    static void Main()
    {
        // Задаем исходный массив строк
        Console.WriteLine("Введите строки через пробел:");
        string[] inputStrings = Console.ReadLine().Split(' ');

        // Создаем новый массив для хранения коротких строк
        string[] shortStrings = GetShortStrings(inputStrings);

        // Выводим результат
        Console.WriteLine("Короткие строки:");
        foreach (string str in shortStrings)
        {
            Console.WriteLine(str);
        }
    }

    static string[] GetShortStrings(string[] inputStrings)
    {
        // Считаем количество коротких строк, чтобы создать массив нужного размера
        int count = 0;
        foreach (string str in inputStrings)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив коротких строк
        string[] shortStrings = new string[count];
        int index = 0;
        foreach (string str in inputStrings)
        {
            if (str.Length <= 3)
            {
                shortStrings[index] = str;
                index++;
            }
        }

        return shortStrings;
    }
}

