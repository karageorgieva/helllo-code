Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArray(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0) count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArray(int[] numbers)
{
    for(int n = 0; n < numbers.Length; n++)
    {
        numbers[n] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int n = 0; n < numbers.Length; n++)
    {
        Console.Write(numbers[n] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}