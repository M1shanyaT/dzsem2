//Напишите программу, которая выволит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите своё число -> ");
string stringNumber = Console.ReadLine();

int number;

bool isNumber = int.TryParse(stringNumber, out number);
 if (isNumber && stringNumber.Length >= 3)
 {
    Console.WriteLine("Ваше число подходит.");
    Console.WriteLine($"Третья цифра числа {number} -> {stringNumber[2]}");
 }
 else
 {
    Console.WriteLine("В вашем числе есть буквы, либо его длинна не подходит для решения задачи.");
 }