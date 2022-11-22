

/*Задача №47*/

// double [,] array = new double [3, 4];
//  System.Console.WriteLine("---------------------------");

// for (int i = 0 ; i < 3 ; i++)
// {

//   for (int j = 0 ; j < 4 ; j++)
//  {
//      array [i,j] = new Random().Next(-9,10)+new Random().NextDouble();
//      array [i,j] = Math.Round(array[i,j],1);
//      System.Console.Write(array[i,j]+" "); 
//  }

//  System.Console.WriteLine( );
// }
// System.Console.WriteLine("---------------------------");


/*Задача №50*/

// Console.WriteLine("Введите номер строки:");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите номер столбца:");
// int b = Convert.ToInt32(Console.ReadLine());

//  System.Console.WriteLine( );

// double [,] array = new double[5, 7];

// for (int i = 0 ; i < 5 ; i++)
// {
//   for (int j = 0 ; j < 7 ; j++)
//  {
//      array [i,j] = new Random().Next(-10,10);
//     System.Console.Write(array[i,j]+"\t"); 
//  }
//  System.Console.WriteLine( );
// }


//  if ((c<=5)||(b<=7))
//     {
//      System.Console.WriteLine( "Такое число есть в сгенерированном массиве!");
    
//     }
//     else
//     {
//       System.Console.WriteLine( "Такого числа нет в сгенерированном массиве!");
//     }
//  System.Console.WriteLine( );


/*Задача №52*/

// int [,] array  = new int[3, 4];

//  for (int i = 0 ; i < 3 ; i++)
//  {
//    for (int j = 0 ; j < 4 ; j++)
//     {
//      array [i,j] = new Random().Next(0,41);
//      System.Console.Write(array[i,j]+"\t"); 
//     }
//     System.Console.WriteLine();
//  }
// System.Console.WriteLine( );

// double [] vid = new double[array.GetLength(0)];

//  for (int j = 0 ; j < array.GetLength(0) ; j++)
//  {
//     vid[j]=0;
//    for (int i = 0 ; i < array.GetLength(1) ; i++)
//     {
//             vid[j]+=array[i,j];
//     }
//     System.Console.WriteLine($"{vid[j]/4}" );
//  }