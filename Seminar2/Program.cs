﻿System.Console.WriteLine("Выберите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
//if (number == 1) Console.WriteLine("Понедельник");
//if (number == 2) Console.WriteLine("Вторник");
//if (number == 3) Console.WriteLine("Среда");
//if (number == 4) Console.WriteLine("Четверг");
//if (number == 5) Console.WriteLine("Пятница");
//if (number == 6) Console.WriteLine("Суббота");
//if (number == 7) Console.WriteLine("Воскресенье");
//if (number < 1) Console.WriteLine("Вы выбрали иную цифру");
//if (number > 7) Console.WriteLine("Вы выбрали иную цифру");

if (number == 1) Console.WriteLine("Понедельник");
else if (number == 2) Console.WriteLine("Вторник");
else if (number == 3) Console.WriteLine("Среда");
else if (number == 4) Console.WriteLine("Четверг");
else if (number == 5) Console.WriteLine("Пятница");
else if (number == 6) Console.WriteLine("Суббота");
else if (number == 7) Console.WriteLine("Воскресенье");
else if (number < 1) Console.WriteLine("Вы выбрали иную цифру");
else if (number > 7) Console.WriteLine("Вы выбрали иную цифру");
else Console.WriteLine("Вы выбрали иную цифру");