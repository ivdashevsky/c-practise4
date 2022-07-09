//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void SumNum(int num)
{
    int l = Convert.ToString(num).Length;
    double summa = 0;
    for (int i = 1; i <= l; i++)
    {   
        //a = a/10;
        summa = summa + Math.Truncate((num%(Math.Pow(10,Convert.ToDouble(i))))/Math.Pow(10,Convert.ToDouble(i)-1));
    }
    Console.WriteLine($"Сумма цифр в числе = {summa}");
}

SumNum(Math.Abs(75684765));
