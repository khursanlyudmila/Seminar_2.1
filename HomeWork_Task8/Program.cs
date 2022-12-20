Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

int count = 1;

while (count <= number)
{
    if(number % 2 == 0)
    {
        Console.Write($"{count+1}, ");
    }
    else
        Console.Write($"{count-1}, ");
    count += 2;
}
