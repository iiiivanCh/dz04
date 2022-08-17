// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

// тип данных применен осознано, т.к. решить задачу бедного
// шаха с шахматной доской и удвоения зерен на каждой клетке
// решить по другому не удалось, более глобальных задач
// не рассматривал

double numA = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
double numB = GetNumberFromUser("Введите целое число B: ", "Ошибка ввода!");

Console.WriteLine("Возводим число А в натуральную степень В");
double result = GetNumberDegree(numA, numB);
Console.WriteLine($"\tA = {numA}, B = {numB}  ->  {result}");

Console.WriteLine("Проверим методом Math.Pow класса Math");
double resultDuble = (double)(Math.Pow(numA, numB));
Console.WriteLine($"\tA = {numA}, B = {numB}  ->  {resultDuble}");


double GetNumberFromUser(string message, string errorMessage)
{
  while (true)
  {
    Console.Write(message);
    bool isCorrect = double.TryParse(Console.ReadLine(), out double userNumber);
    if (isCorrect)
      return userNumber;
    Console.WriteLine(errorMessage);
  }
}

double GetNumberDegree(double numberUserA, double numberUserB)
{
  double i;
  double total = 1;
  for (i = 0; i < numberUserB; i++)
  {
    if (numberUserB == 1)
      total = numberUserA;
    if (numberUserB > 1)
      total *= numberUserA;
  }
  return total;
}