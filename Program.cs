/*

Задача №19

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int num2 = num;
int big = 0;
int rev = 0;

while (num > 0)
{
    big = num % 10;
    rev = rev * 10 + big;
    num = (num / 10);
}
if (num2==rev)
{
    Console.WriteLine("Число является полиндромом");
}
else
{
   Console.WriteLine("Число не является полиндромом"); 
}
*/
 /*
  Задача №21
 Console.WriteLine("Введите координаты X1");
int X1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Y1");
int Y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Z1");
int Z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты X2");
int X2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Y2");
int Y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты Z2");
int Z2 = int.Parse(Console.ReadLine());

double D = Math.Sqrt(Math.Pow(X2-X1, 2)+Math.Pow(Y2-Y1, 2)+Math.Pow(Z2-Z1,2));
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {D}");
*/
/*
Задача №23
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

for(int i=1;i<=num;i++)
{
  double num2 = Math.Pow(i,3);
  Console.WriteLine(num2);
}
*/