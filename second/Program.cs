// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Введите натуральное число N");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите натуральное число M, большее N");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

int Sum(int a, int b)
{
    if (a <= b)
    {
        return a + Sum(a + 1, b);
    }
    else
    {
        return 0;
    }

}

System.Console.WriteLine(Sum(N, M));