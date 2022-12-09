int SecondNumb (int arg1)
{
    int result = arg1 / 10;
    result = result % 10;
    return result;
}

int a = 456;
int b = 782;
int c = 918;

int a1 = SecondNumb (a);
int b1 = SecondNumb (b);
int c1 = SecondNumb (c);

Console.WriteLine (a1);
Console.WriteLine (b1);
Console.WriteLine (c1);