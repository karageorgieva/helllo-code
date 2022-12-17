Console.WriteLine("Ввидите число");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number == 6 ||  Number == 7)
{
  Console.WriteLine("да, выходной");
}

else if (Number < 1 || Number >7) {

  Console.WriteLine("Sorry, такого дня не существует");

}
else  {

  Console.WriteLine("не выходной");

}