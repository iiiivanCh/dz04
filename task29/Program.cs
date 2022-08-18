// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Console.Clear();

int num = GetNumberFromUser("Задаем количество элементов в массиве. Введите целое число: ", "Ошибка ввода!");
Console.WriteLine($"Количество элементов в массиве {num}");
int[] userArray = GetNewArray(num);
OutputUserArrayConsole(userArray);

// запрос данных от пользователя
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

// заполнение массива пользователем данными
int[] GetNewArray(int lengthNewArray)
{
  int[] newArray = new int[lengthNewArray];
  for (int i = 0; lengthNewArray > i; i++)
    newArray[i] = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
  return newArray;
}

// вывод получившегося массива в консоль
void OutputUserArrayConsole(int[] newArray)
{
  for (int i = 0; i < newArray.Length; i++)
  {
    if (i != newArray.Length - 1)
      Console.Write($"{newArray[i]}, ");
    else
      Console.Write($"{newArray[i]}  =>  ");
  }
  for (int j = 0; j < newArray.Length; j++)
  {
    if (j == 0)
      Console.Write($"[{newArray[j]}, ");
    if (j != newArray.Length - 1 && j != 0)
      Console.Write($"{newArray[j]}, ");
    if (j == newArray.Length - 1)
      Console.Write($"{newArray[j]}]");
  }
}