// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
void method (int arg)
{
    int arg0 = arg /10/10/10/10%10;
    int arg1 = arg /10/10/10%10;
    int arg3 = arg /10%10;
    int arg4 = arg %10;
    if (arg0 == arg4 || arg1 == arg3) Console.WriteLine ("-> ДА");
        else Console.WriteLine ("-> НЕТ");

}
int a0 = 14212;
int b0 = 12821;
int c0 = 23432;
Console.Write(a0);
method(a0);
Console.Write(b0);
method(b0);
Console.Write(c0);
method(c0);