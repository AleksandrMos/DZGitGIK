/*
Задача №41
Console.WriteLine("Введите числа(через пробел):");
int [] arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

int count = 0;

for (int i =0; i < arr.Length; i++)
{
  if (arr[i]>0)
  {
    count++;
  }

}
 Console.WriteLine($"Вы ввели числе >0: {count}");


Задача №43 

Console.WriteLine("Введите k1");
double k1 =Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b1");
double b1 =Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k2");
double k2 =Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b2");
double b2 =Convert.ToDouble(Console.ReadLine());

if(k1==k2)
{
  Console.WriteLine("||");
}
else
{
  double x = (b2-b1)/(k1-k2);
  double y = k1*x+b1;

  Console.WriteLine($"Точка пересечения:({x}; {y}");
}
*/

