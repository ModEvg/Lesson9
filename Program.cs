/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write($"Введите число M = ");
int M = int.Parse(Console.ReadLine()!);
Console.Write($"Введите число N = ");
int N = int.Parse(Console.ReadLine()!);

Console.Write($"Сумма натуральных элементов в промежутке от {M} до {N} = ");
Summa (M,N,0);

void Summa (int l, int k, int sum)
{
    if (l > k) {Console.Write($"{sum}"); return;}
    sum = sum+l;
    Summa(l+1,k,sum);
    
}