/* На вход координаты (x;y)
На выход расстояние между точками d 2D пространстве */

double Length(int[] pointA, int[] pointB)
    {
    double distance = Math.Sqrt(Math.Pow(pointB[0] - pointA[0], 2) + Math.Pow(pointB[1] - pointA[1], 2));
    return distance;
    }

 int x1, x2, y1, y2;

Console.Write ("Введите целое число x1: ");
while (!int.TryParse (Console.ReadLine(), out x1))
    Console.Write ("Ошибка ввода. Введите целое число: ");

Console.Write ("Введите целое число x2: ");
while (!int.TryParse (Console.ReadLine(), out x2))
    Console.Write ("Ошибка ввода. Введите целое число: ");

Console.Write ("Введите целое число y1: ");
while (!int.TryParse (Console.ReadLine(), out y1))
    Console.Write ("Ошибка ввода. Введите целое число: ");

Console.Write ("Введите целое число y2: ");
while (!int.TryParse (Console.ReadLine(), out y2))
    Console.Write ("Ошибка ввода. Введите целое число: ");

double result = Length(new int[]{x1, y1}, new int[]{x2, y2});
Console.Write($"{Math.Round (result, 2, MidpointRounding.ToZero)}");
// Console.WriteLine($"{result:F2}");