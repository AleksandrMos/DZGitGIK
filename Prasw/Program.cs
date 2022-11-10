/*
Задача 25
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите требуюмую степень");
int Stepen = int.Parse(Console.ReadLine());

int Geti(int num)
{
 int num1=0;
 int count=0;   
while (count <=0)
{
  int num2 = Convert.ToInt32(Math.Pow(number, Stepen));
 count+=1;
 num1=num2;
}
return num1;
}
Console.WriteLine(Geti(number));
*/

/*
Задача №27
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

int NumSum(int num)
{
 int num1=0;
 int count=0;   
while (number > 0)
{
 count=number%10;
 num1 +=count;
 number=number/10;
}
return num1;
}
Console.WriteLine(NumSum(number));
*/

/*
Задача 29
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

int[] array = GetArray(number);
int[] GetArray(int size)
{
    int[] array = new int [size];
    for (int i=0; i<size;i++)
    {
        array[i]=new Random().Next(0,100);
    }
    return array;
}
Console.WriteLine(String.Join(",",array));
*/

