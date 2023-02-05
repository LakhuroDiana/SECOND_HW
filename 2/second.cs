System.Console.WriteLine("Введите число");
string number = Console.ReadLine();
int N = Convert.ToInt32(number);
if (N / 100 == 0)
{
    System.Console.WriteLine("третьей цифры нет");
}
else
{
    System.Console.WriteLine(N % 1000 / 100);
}