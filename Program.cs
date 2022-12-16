/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Write($"Введите число m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write($"Введите число n = ");
int n = int.Parse(Console.ReadLine()!);

Console.Write($"Функция Аккермана равна {Akkerman(m,n)}");

int Akkerman (int l, int k)
{
    if (l == 0)  return k+1;
    if (l != 0 && k ==0)  return Akkerman(l-1,1);
    if (l > 0 && k > 0) return Akkerman(l - 1, Akkerman(l, k - 1));
    return Akkerman(l, k);
}