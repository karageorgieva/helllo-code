void method (int number1, int number2)
{
    int n =  number1;
for (int i = 1; i < number2; i++)
{ 
    
    number1 = number1*n;

}
    Console.WriteLine(number1);
}
Console.Write("3 5 --> ");
method(3,5);
Console.Write("2 4 --> ");
method(2,4);