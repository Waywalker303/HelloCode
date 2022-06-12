// создаёт случайное трёх значное число и выводит первый и последний знак
int number = new Random().Next(100, 1000);

Console.WriteLine(number);

int firstDigit = number % 10; // 1 варинат
int secondDigit = number / 100;
Console.WriteLine(secondDigit * 10 + firstDigit); 

int result = secondDigit * 10 + firstDigit; // 2й варинат
Console.WriteLine(result); 