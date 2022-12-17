void method1 ()
{
Console.WriteLine("used method num. 1");
}
//method1();


void method2 (string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//method2("Text", 4);


int method3()
{
    return DateTime.Now.Year;
}
int year = method3 ();
//Console.WriteLine(year);

string method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }   
    return result;
}
//string res = method4(10, "Hi, cat ");
//Console.WriteLine(res);



string method44(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }   
    return result;
}
//string res = method44(10, "m");
//Console.WriteLine(res);


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
    //Console.WriteLine($"{i} x {j} = {i * j}");
    }
   // Console.WriteLine();
}


//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками (|),
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
 +"ежели бы вас послали вместо нашего милого Винценгероде,"
 +"вы бы взяли приступом согласие прусского короля."
 +"Вы так красноречивы. Вы дадите мне чаю?";

 // string s = "qwerty"
 //             012
 // s[3] // r

 string Replace(string text, char oldValue, char newValue)
 {
    string result = String.Empty;

    int lenght = text.Length;
    for ( int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
 }
string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);