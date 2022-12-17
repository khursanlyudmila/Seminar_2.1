Console.WriteLine("Введите число 1:");

string numberStr1 = Console.ReadLine() ?? "";
int number1 = int.Parse(numberStr1);

Console.WriteLine("Введите число 2:");

string numberStr2 = Console.ReadLine() ?? "";
int number2 = int.Parse(numberStr2);

Console.WriteLine("Введите число 3:");

string numberStr3 = Console.ReadLine() ?? "";
int number3 = int.Parse(numberStr3);

int result = number1;
if(number2 > result) result = number2;
if(number3 > result) result = number3;

Console.WriteLine($"Наибольшее число из {number1}, {number2} и {number3} - число {result}");
