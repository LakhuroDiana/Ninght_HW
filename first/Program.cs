// Задайте значения M и N. Напишите программу,
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

System.Console.WriteLine("Введите натуральное число N");
uint N = Convert.ToUInt32(Console.ReadLine());
System.Console.WriteLine("Введите натуральное число M, большее N");
uint M = Convert.ToUInt32(Console.ReadLine());
System.Console.WriteLine();

uint OutPut(uint a, uint b)
{
    if (a <= b)
    {
        if (a % 2 == 0)
        {
            System.Console.WriteLine(a + " ");
        }
        return OutPut(a + 1, b);
    }
    else
    {
        return 1;
    }
}

OutPut(N, M);