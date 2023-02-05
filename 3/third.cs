System.Console.WriteLine("Введите цифру, обозначающую день недели");
string number = Console.ReadLine();
int N = Convert.ToInt32(number);
if (N < 1 || N > 7)
{
    System.Console.WriteLine("Такого дня недели нет");
}
else
{
    if (N == 6 || N == 7)
    {
        System.Console.WriteLine("Это выходной");
    }
    else
    {
        System.Console.WriteLine("Это  не выходной");
    }
}
