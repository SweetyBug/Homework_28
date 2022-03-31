void FillArray(double[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().NextDouble() * 20;
    }
}

void Output(double[] mass)
{
    for (int j = 0; j < mass.Length; j++)
    {
        Console.Write(mass[j] + "; ");
    }
}

double Maximum(double[] mass)
{
    double maxN = mass[0];
    for (int k = 0; k < mass.Length; k++)
    {
        if (mass[k] > maxN)
        {
            maxN = mass[k];
        }
    }
    Console.WriteLine($"Максимальное число = {maxN}");
    return maxN;
}

double Minimum(double[] mass)
{
    double minN = mass[0];
    for (int k = 0; k < mass.Length; k++)
    {
        if (mass[k] < minN)
        {
            minN = mass[k];
        }
    }
    Console.WriteLine($"Минимальное число = {minN}");
    return minN;
}

double[] array = new double[5];

FillArray(array);
Output(array);
Console.WriteLine();
double numb1 = Maximum(array);
double numb2 = Minimum(array);
double res = numb1 - numb2;

Console.Write("{0:0.00}", res);
