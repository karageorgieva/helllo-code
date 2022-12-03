int a = 5;
int b = 8;
int countB = 1;
int countA = 1;

while(countA <= a)
{
    if((countA % 2) == 0)
    {
    Console.Write(countA);    
    Console.Write(" ");
    }
    countA++;
}
Console.WriteLine(" ");
while(countB <= b)
{
    if((countB % 2) == 0)
    {
    Console.Write(countB);    
    Console.Write(" ");
    }
    countB++;
}