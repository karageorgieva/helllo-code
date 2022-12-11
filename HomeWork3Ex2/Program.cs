// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (0,0); B (1,1) -> ~1.4
//A (2,4); B (0,7) -> ~3.6

double x1 = 0;
double x2 = 1;
double y1 = 0;
double y2 = 1;
double a = x2 - x1;
double b = y2 - y1;
double n = a*a + b*b; 
double d = Math.Sqrt(n);
Console.WriteLine("A (0,0); B (1,1)");
Console.WriteLine(d);

double x11 = 2;
double x21 = 0;
double y11 = 4;
double y21 = 7;
double a1 = x21 - x11;
double b1 = y21 - y11;
double n1 = a1*a1 + b1*b1; 
double d1 = Math.Sqrt(n1);
Console.WriteLine("A (2,4); B (0,7)");
Console.WriteLine(d1);