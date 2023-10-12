Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int sqr = number2 * number2;
if (number1 == sqr) Console.WriteLine($"Число {number1} является квадратом числа {number2}");
else Console.WriteLine($"Число {number1} НЕ является квадратом числа {number2}");