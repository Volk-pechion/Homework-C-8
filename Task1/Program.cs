//Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.


int Promt(string message)
{
 System.Console.Write(message);
 return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row,int column, int min, int max)
{
    var array = new int [row, column];
    var rnd = new Random();
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array [i, j] = rnd.Next(min, max+1);
        }
        
       }
       return array;
}

void PrintArray(int [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            System.Console.Write(array [i, j] + "\t");
        }
        System.Console.WriteLine();
       }
}

int[,] OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
  return array;
}


int row = Promt("Количество строк: ");
int column = Promt("Количество столбцов: ");
int min = -10;
int max = 10;
int [,] array = GenerateArray(row, column, min, max);
PrintArray(array);
System.Console.WriteLine("Упорядоченный массив");

PrintArray(OrderArrayLines(array));