//Напишите программу, которая на вход принимает трехзначное число и на выходе показывает вторую цифру этого числа

Console.Write("Введите трехзначное число -> ");
int number = Convert.ToInt32(Console.ReadLine());  //345

if (number < 0)
{
    Console.WriteLine($"Ваше число {number} отрициательное, мы домножили его на -1");
    number = number * -1;
}

int firstDigit = number % 100;                     //45
int secondDigit = firstDigit / 10;                 //4

Console.WriteLine($"Вторая цифра числа {number} -> {secondDigit}");