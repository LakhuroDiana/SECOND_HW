System.Console.WriteLine("Введите трёхзначное число");
string number = Console.ReadLine();
int N = Convert.ToInt32(number);
System.Console.WriteLine(N / 10 % 10);