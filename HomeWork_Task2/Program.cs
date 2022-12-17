Console.WriteLine("Введите число 1:");

string numberStr1 = Console.ReadLine() ?? "";
int number1 = int.Parse(numberStr1);

Console.WriteLine("Введите число 2:");

string numberStr2 = Console.ReadLine() ?? "";
int number2 = int.Parse(numberStr2);

int result = number1;
if(number2 > result) result = number2;

Console.WriteLine($"Наибольшее число из {number1} и {number2} - число {result}");