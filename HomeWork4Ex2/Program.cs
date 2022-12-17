int number = ReadInt("Введите число: ");
int count = NumberKol (number);
SumNumbers(number, count);


int ReadInt(string chislo)
{
    Console.Write(chislo);
    return Convert.ToInt32(Console.ReadLine());
}


int NumberKol(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}


void SumNumbers(int n, int count)
{
    int sum = 0;
    for (int i = 1; i <= count; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}