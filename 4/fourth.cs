int number = new Random().Next(100, 999);
System.Console.WriteLine(number);
number = number / 100 * 10 + number % 10;
System.Console.WriteLine(number);