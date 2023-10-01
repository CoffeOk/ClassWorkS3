/* На вход: координаты (x;y), x, y != 0
На выход: Номер четверти площади в которой находится точка
 */

int Chetvert (int xKoord, int yKoord)
{
    if (xKoord > 0 && yKoord > 0) return 1;
    else if (xKoord < 0 && yKoord > 0) return 2;
    else if (xKoord < 0 && yKoord < 0) return 3;
    else if (xKoord > 0 && yKoord < 0) return 4;
    return 0;
}

 int x, y;
 Coordinati:
 Console.Write("Введите целое число x: ");
while(!int.TryParse(Console.ReadLine(), out x))
    Console.Write("Ошибка ввода. Введите целое число: ");

Console.Write("Введите целое число y: ");
while(!int.TryParse(Console.ReadLine(), out y))
    Console.Write("Ошибка ввода. Введите целое число: ");

int chetvert = Chetvert (x, y);
if (x == 0 || y == 0)
{
    Console.Write("Ошибка ввода. Введите координаты не равные 0: ");
    goto Coordinati;
}
else
{
    Console.Write($"{x}, {y} -> {chetvert}");
}