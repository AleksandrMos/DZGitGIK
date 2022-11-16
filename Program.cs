/*
Задача №34

int count=0;
int [] array =  new int[3];

for (int i =0; i<array.Length; i++)
{
  
  array[i] = new Random().Next(100,1000);
  Console.WriteLine(array[i]);
  if (i%2<=0)
  {
  count++;
  } 
}
Console.WriteLine(count);
*/

/*
Задача 36


Console.WriteLine(" Введите количество чисел в массиве");
int num = Convert.ToInt32(Console.ReadLine());

int summa =0;
int[] array = Method(num);
int[] Method (int num)
{
  int[] array = new int[num];

  for (int i=0; i<num; i++)
  {
    array[i]=new Random().Next(-100,100);
    int element = array[i];
    if (i%2 !=0)
    {
      summa = summa +element;
    }
  }
  return array;
}
Console.WriteLine(String.Join(",",array));
Console.WriteLine($"Сумма элементов на нечётных позициях :{summa}");
*/
/*
Задача №38

Console.WriteLine(" Введите количество чисел в массиве");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = Method2(num);
int[] Method2 (int num)
{
  int[] array = new int[num];
  for (int i=0; i<num; i++)
  {
    array[i] = new Random().Next(-100,100);
  }
  return array;
}
Console.WriteLine(String.Join(",",array));

int max = array[0];
int min = array[0];
for(int i=0; i<num; i++)
{
  if (array[i] > max)
  max = array[i];
   if (array[i] < min)
  min = array[i];
}

Console.WriteLine($"Вывод:{max - min}");
*/
