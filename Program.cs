

(int lenght, string[] array) = InputWithChoise();

int[] count = new int[array.Length];
System.Console.WriteLine("Исходный массив:");
FillPrint.FillPrint.PrintMassive(array);
System.Console.WriteLine();
System.Console.WriteLine($"Массив из элементов, длиной не более {lenght}:");
FillPrint.FillPrint.PrintMassive(FillArrayResult(count, FindIndex(array, lenght, count)));



int FindIndex(string[] arr, int lenght, int[] countArr)
{

  int k = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i].Length <= lenght)
    {
      countArr[k] = i;
      k++;
    }

  }
  return k;

}


string[] FillArrayResult(int[] countArr, int k)
{

  string[] result = new string[k];

  for (int i = 0; i < result.Length; i++)
  {
    result[i] = array[countArr[i]];
  }
  return result;
}


(int, string[]) InputWithChoise()
{

  int lenght = 0;

  System.Console.WriteLine("Выберете вариант:");
  System.Console.WriteLine("1. Вводить данные вручную.");
  System.Console.WriteLine("2. Воспользоваться одной из заготовок.");
  int choise = int.Parse(Console.ReadLine() ?? "2");

  if (choise == 1)
  {
    System.Console.WriteLine("Введите максимальную длину строки:");
    lenght = int.Parse(Console.ReadLine()!);

    System.Console.WriteLine("Введите массив строк через \",\"");
    string[] arr = Console.ReadLine()!.Split(",").ToArray();
    return (lenght, arr);
  }
  else
  {
    Random rand = new Random();
    lenght = 3;
    string[][] arrayOptions = new string[][] {
      new string[] { "hello", "2", "world", ":-)" },
      new string[] { "1234", "1567", "-2", "abra cadabra", "123" },
      new string[] {"Russia", "Denmark", "Kazan"}
    };
    string[] arr = arrayOptions[rand.Next(0, arrayOptions.GetLength(0))];
    return (lenght, arr);
  }


}