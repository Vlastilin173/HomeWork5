// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// void InputArray(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(100, 1000); // [100, 999]
// }


// int ReleaseArray(int[] array)
// {
    
//   int count = 0;
//   foreach (int element in array)
//   {
//     if (element % 2 == 0 )
//       count++; // count = count + 1;
//   }
//  Console.WriteLine($"Количество четных чисел:  {count}");
//   return count;
  
// }

// Console.Clear();
// int[] array = new int[5];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// ReleaseArray(array);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// void InputArray(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 21); // [1, 20]
// }

// void ReleaseArray (int [] array)
// {
//     for (int i =0; i < array.Length; i++);
//     Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// }
  
// Console.Clear();
// Console.Write ("Введите число элементов массива: ");
// int a = Convert.ToInt32 (Console.ReadLine());
// int [] numbers = new int [a];
// InputArray (numbers);
// ReleaseArray (numbers);
// int sum = 0;
// for (int i = 0; i < a; i++)
// {
//     if (i % 2 != 0)
//     {
//     sum = sum + numbers[i];
//     }
// }
// Console.WriteLine ("Cумма элементов стоящих на нечетном месте: "+sum);



// Задача 38: Задайте массив вещественных(дробных) чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.1, 7.23, 22.57, 2.45, 78.78] -> 76.33

Console.Write ("Введите число элементов массива: ");
int a = Convert.ToInt32 (Console.ReadLine());
double [] numbers = new double [a];
InputArray (numbers);
ReleaseArray (numbers);

double max = numbers [0];
for (int i = 0; i < a; i++)
    {
        if (numbers[i] > max)
         {
            max = numbers[i];
         }
    }
double min = numbers [0];
for (int i = 0; i < a; i++)
    {
        if (numbers[i] < min)
         {
            min = numbers[i];
         }
    }
double diff = max - min;
Console.WriteLine ("Разница между max и min эл. массива: "+diff);
void InputArray (double [] array)
  {
    for (int i =0; i < array.Length; i++)
    {
     
       numbers [i] =  Math.Round(new Random().NextDouble() * 100, 2); //Смена диапазона чисел массива
      
    }
    Console.Clear();
    Console.WriteLine($"Начальный массив: [{string.Join(", ", array )}]");
  }

  void ReleaseArray (double [] array)
  {
    for (int i =0; i < array.Length; i++);
   
  }
