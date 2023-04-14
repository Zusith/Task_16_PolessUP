int n = 28;
Console.WriteLine("Ввод: " + n);
Console.WriteLine(CanSumPowThree(n, out int degree1, out int degree2));
Console.WriteLine(RowFormula(n, degree1, degree2));


bool CanSumPowThree(int n, out int degree1, out int degree2)
{
    degree1 = 0; degree2 = 0;
    int firstsummand = (int)Math.Pow(3, degree1);
    int secondsummand = (int)Math.Pow(3, degree2);

    while (Math.Pow(3, degree1) < n)
    {
        firstsummand = (int)Math.Pow(3, degree1);
        degree1++;
    }
    while (Math.Pow(3, degree2) <= n - firstsummand)
    {
        secondsummand = (int)Math.Pow(3, degree2);
        degree2++;
    }
    degree1--; degree2--;
    return firstsummand + secondsummand == n;
}

string? RowFormula(int n, int degree1, int degree2)
{
    if (n == Math.Pow(3, degree1) + Math.Pow(3, degree2))
        return $"{n} = {Math.Pow(3, degree1)} + {Math.Pow(3, degree2)}";
    else
        return "Нет решения";
}