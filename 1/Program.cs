// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в 
// промежутке от M до N. Использовать рекурсию, 
// не использовать циклы.



Console.WriteLine("Введите значение M:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение N:");
int N = Convert.ToInt32(Console.ReadLine());

void PrintNaturalNumbers (int start, int end)
{
if (start >= end )
{
Console.Write (start + " ");
PrintNaturalNumbers(start - 1, end);
}
else
{
Console.WriteLine("Введите M>N");
}
}

PrintNaturalNumbers(M,N);


