//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int[] arr = new int[8];

void Fill_And_Show(int[] a)
{
    int l = a.Length;

        for (int i = 0; i < l; i++)
        {
            a[i] = new Random().Next(-20, 20);
            Console.Write($"{a[i]}|");
        }

}

Fill_And_Show(arr);