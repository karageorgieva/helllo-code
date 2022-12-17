 int TODEC(int[] value)
{
    int result = 0;
    int count = value.Length;
    for (int i = 0; i < count; i++)
{
    result += value[i] * double(15, count - 1 - i);
}
    return result;
}
Console.WriteLine(TODEC(new int[] {9, 4, 12}));
