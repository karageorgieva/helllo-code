void kub(int number)
{
for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");

}
    Console.WriteLine("");
}
Console.Write("3 --> ");
kub(3);
Console.Write("5 --> ");
kub(5);