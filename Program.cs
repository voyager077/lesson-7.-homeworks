﻿//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void PrintInterval(int m, int n)
{
  int start = m;
  int end = n;
  if(m > n)
  {
    start = n;
    end = m;
  }

  Console.Write($"{start} ");

  start = start + 1;

  if (start > end) {
    return;
  } else {  
    PrintInterval(start, end);
  }
}

PrintInterval(140, 50);

Console.WriteLine();


//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

		int AkkermanFunc(int m, int n)
		{
			if(m == 0)
			{
				return n + 1;
			}
			if(m > 0 && n == 0)
			{
				return AkkermanFunc(m - 1, 1);
			}
			return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
		}
		
		Console.WriteLine(AkkermanFunc(1,12));


//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


	void printReversed(int[] arr, int? optionalIndex = null) {
	
	
		int i = optionalIndex ?? arr.Length - 1;
		
		if (i < 0) {
			return;
		}

		Console.WriteLine(arr[i]);
		
		printReversed(arr, i - 1);
		}
		int[] array = {1, 2, 3, 4, 5, 6};
		
	printReversed(array);	
	