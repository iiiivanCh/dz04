// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int num = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");

Console.WriteLine("Cумма цифр в числе А");
Console.WriteLine($"\t{num} -> {GetSumDigits(num)}");

int GetNumberFromUser(string message, string errorMessage)
{
  while (true)
  {
    Console.Write(message);
    bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
    if (isCorrect)
      return userNumber;
    Console.WriteLine(errorMessage);
  }
}

int GetSumDigits(int number)
{
  int sum = 0;
  for (; number > 0; number /= 10)
    sum += number % 10;
  return sum;
}
