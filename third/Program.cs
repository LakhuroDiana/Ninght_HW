// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

System.Console.WriteLine("Введите натуральное число m");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите натуральное число n");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();

int Ackerman(int a, int b)
{
    if (a==0)
    {
        return b+1;
    }
    else if (b==0)
    {
        return Ackerman(a-1,1);
    }
    else
    {
        return Ackerman(a-1,Ackerman(a,b-1));
    }
}

System.Console.WriteLine(Ackerman(m,n));