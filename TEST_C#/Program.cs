using System;
using System.Drawing; // Включення бібліотеки System.Drawing, яка має структуру Point

class Program
{
    static void Main()
    {
        // Створюємо масив для зберігання 10 коордінат
        var pointsArray = new Point[10];

        // Створюємо об’єкт Random для генерації випадкових чисел
        var random = new Random();

        // Генеруємо випадкові точки
        for (int i = 0; i < pointsArray.Length; i++)
        {
            // Генерація випадкової координати X від -100 до 100
            int x = random.Next(-100, 101);

            // Генерація випадкової координати Y від -100 до 100
            int y = random.Next(-100, 101);

            // Створюємо нову точку з цими координатами та зберегаємо її в масиві
            pointsArray[i] = new Point(x, y);
        }

        // Ініціалізуймо найвищу та найправішу точки як перші значення в масиві
        Point highest = pointsArray[0];
        Point rightmost = pointsArray[0];

        // Переглядаємо масив, щоб знайти найвищу та найправішу точки
        for (int i = 1; i < pointsArray.Length; i++)
        {
            // Якщо поточний Y більший за найвищий Y, тоді оновлюємо змінну на поточний Y
            if (pointsArray[i].Y > highest.Y)
            {
                highest = pointsArray[i];
            }

            // Якщо поточний X більший за найправіший X, тоді оновлюємо змінну на поточний X
            if (pointsArray[i].X > rightmost.X)
            {
                rightmost = pointsArray[i];
            }
        }

        // Виводимо всі згенеровані точки
        Console.WriteLine("Згенеровані точки:");
        foreach (var point in pointsArray)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }

        // Виводимо найвищу та найправішу точки
        Console.WriteLine($"\nНайвища точка: ({highest.X}, {highest.Y})");
        Console.WriteLine($"Найправіша точка: ({rightmost.X}, {rightmost.Y})");
    }
}