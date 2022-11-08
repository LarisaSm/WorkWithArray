
int size = 3;
int lenght = 3;
// string[] array = new string[] { "hello", "2", "world", ":-)" };
string[] array = new string[] { "1234", "1567", "-2 ", "abra cadabra" };
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




