int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(0,14);
    Console.Write(randomArray[i]+ " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int Pow(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;
}
int TODEC(int[] value)
{
    int result = 0;
    int count = value.Length;
    for (int i = 0; i < value.Length; i++)
{
    result += value[i] * Pow(15, count - 1 - i);
}
    return result;
}
Console.WriteLine(TODEC(randomArray));