// Задание 1. Совместная работа
// Семинар 1. Знакомство с языками программирования
// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// Console.WriteLine("Введите число");
// int num1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = int.Parse(Console.ReadLine());

// if(num1 == num2*num2)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// int negNum = -1 * num;

// while(negNum<= num)
// {
// Console.WriteLine(negNum);

// negNum = negNum+1;
// negNum+=1;
// negNum++;
// }
// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// int num1 =num/100;
// int num3 = num % 10;

// int result = num1+num3;
// Console.WriteLine(result);

// Console.WriteLine("Сум = "+ result+ " кнг");// Конкатенация
// Console.WriteLine($"Сум = {result} кнг");// Интерполяция
// Большее из двух чисел

// Инструкция по использованию платформы



// Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.

// Пример использования:
// На входе:


// firstNumber: '5'
// secondNumber: '6'
// На выходе:


// Первое число `5` меньше чем второе число `6`
// На входе:


// firstNumber: '3'
// secondNumber: '6'
// На выходе:


// Первое число `3` меньше чем второе число `6`
// На входе:


// firstNumber: '3'
// secondNumber: '3'
// На выходе:


// Введенные числа равны `3`

// Console.WriteLine("Введите число");
// int firstNumber = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int secondNumber = int.Parse(Console.ReadLine());

// if(firstNumber < secondNumber)
// {
//     Console.WriteLine(secondNumber);
// }
// else
// {
//     Console.WriteLine(firstNumber);
// }

// using System;

// public class Answer {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         // Введите свое решение ниже
//         if(firstNumber < secondNumber)
//         {
//             Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
//         }
//         else if(firstNumber == secondNumber) 
//         {
//             Console.WriteLine($"Введенные числа равны `{firstNumber}`");
//         }
//         else
//         {
//             Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
//         }     
//     }

//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2) {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = 7;
//             secondNumber = 6;
//         }

//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// }

// using System;
// using System.ComponentModel.DataAnnotations;

// public class Answer {
    
//   static int FindMax(int a, int b, int c)
//     {
//       // Введите свое решение ниже
//         int max = a;
//         if (b>max)
//         {
//             max = b;
//         }
//         if (c>max)
//         {
//             max = c;
//         }
//         return max;
//     }

//   // Не удаляйте и не меняйте метод Main! 
//   static public void Main(string[] args) 
//     {
//         int a, b, c;

//         if (args.Length >= 3) {
//            a = int.Parse(args[0]);
//            b = int.Parse(args[1]);
//            c = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            a = 8;
//            b = 6;
//            c = 7;
//         }

//         // Не удаляйте строки ниже
//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }

// using System;

// class Answer {
//     static void CheckIfEven(int number)
//     {
//       // Введите свое решение ниже
//         int rem = number % 2;
//         if (rem == 0)
//         {
//             System.Console.WriteLine($"Число `{number}` чётное");
//         }
//         else
//         {
//             System.Console.WriteLine($"Число `{number}` нечётное");    
//         }          
//     }
  

//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 6;
//         }

//         // Не удаляйте строки ниже
//         CheckIfEven(number);
//     }
// }

// number = 5 -> 2    4

// number = 8 -> 2    4    6    8
// using System;

// public class Answer {
//     static void PrintEvenNumbers(int number)
//     {
//       // Введите свое решение ниже
//         int n = 1;
//         int rem;

//         while (n<=number)
//         {
//             rem = n % 2;
//             if (rem == 0)
//             {
//                 System.Console.Write(n+"\t");        
//             }
//             n++;
//         }
        
//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 5;
//         }

//         // Не удаляйте строки ниже
//         PrintEvenNumbers(number);
//     }
// }