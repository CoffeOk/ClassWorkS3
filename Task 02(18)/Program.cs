/* Ввод: номер четверти
Вывод: диопозон возможных координат */

string? DiapCoord (int nChetvert)
{
        if (nChetvert == 1) 
        return "x(0 : +infinity), y(0 : +infinity)";
    else if (nChetvert == 2)    
        return "x(0 : -infinity), y(0 : +infinity)";
    else if (nChetvert == 3)    
        return "x(0 : -infinity), y(0 : -infinity)";
    else if (nChetvert == 4)    
        return "x(0 : +infinity), y(0 : -infinity)";
    return null;
}

int n;
Chetvert:
Console.Write("Введите целое число n: ");
while(!int.TryParse(Console.ReadLine(), out n))
    Console.Write("Ошибка ввода. Введите целое число: ");

string dC = DiapCoord(n);
if (n <= 4)
{
    Console.Write($"{n} -> {dC}");
}
else
{
    goto Chetvert;
}