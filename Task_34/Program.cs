void FillArray(int[] mass)
{
    for(int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(100, 1001);
    }
}

int CountChet(int[] mass)
{
    int count = 0;
    for (int j = 0; j < mass.Length; j++)
    {
        if (mass[j] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void Output(int[] mass)
{
    for(int k = 0; k < mass.Length; k++)
    {
        Console.Write(mass[k] + "; ");
    }
}

Console.Write("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];

FillArray(array);
Output(array);
Console.WriteLine();
Console.Write( $"Кол-во четных чисел = {CountChet(array)}");
