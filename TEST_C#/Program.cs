using System;
using System.Drawing; // Включення бібліотеки System.Drawing, яка має структуру Point

class Program
{
    static void Main()
    {
        // Створюємо масив для зберігання 10 коордінат
        var pointsArray = new Point[10];

        // Клас для генерації випадкових чисел
        var random = new Random();

        // Генеруємо випадкові координати(числа)
        for (int i = 0; i < pointsArray.Length; i++)
        {
            // Генерує випадкове число по X в межах від -100 до 100 включно
            int x = random.Next(-100, 101);

            // Генерує випадкове число по Y в межах від -100 до 100 включно
            int y = random.Next(-100, 101);

            // Створюємо нову точку з X,Y координатами, які були попередньо згенеровані, та зберегаємо їх в масиві
            pointsArray[i] = new Point(x, y);
        }

        // Ініціалізуймо найвищу та найправішу точку
        Point highest = pointsArray[0];
        Point rightmost = pointsArray[0];

        // Переглядаємо масив, щоб знайти найвищу та найправішу точку
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
        for (int i = 0; i < pointsArray.Length; i++)
        {
            Console.WriteLine("(" + pointsArray[i].X + ", " + pointsArray[i].Y + ")");
        }

        // Виводимо найвищу та найправішу точку
        Console.WriteLine($"\nНайвища точка: ({highest.X}, {highest.Y})");
        Console.WriteLine($"Найправіша точка: ({rightmost.X}, {rightmost.Y})");
    }
}