// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double Number(double a, int b)
{
    double res = a;
    for (int i = 1; i < b; i++)
    {
        res = res*a;
    }
    return res;
}

Console.WriteLine("Введите 2 числа");
Console.WriteLine("Число A");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Число B");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Number(n1,n2));