Console.WriteLine("Введите число:");

string numberStr = Console.ReadLine() ?? "";
int number = int.Parse(numberStr);
if(number % 2 == 0)
{
    Console.WriteLine($"Число {number} является четным - да");
}
else
{
    Console.WriteLine($"Число {number} является четным - нет");
}
