/*
 Задайте прямоугольный двумерный массив. Напишите программу, 
 которая будет находить строку с наименьшей суммой элементов.
 */
 int[,] generate2DArray(int lengthRow, int lengthCol, int deviation)
{
    int[,] array = new int[lengthRow,lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i,j] = new Random().Next(-deviation,deviation +1);
        }
    }
    return array;
}

void printColor(string information, ConsoleColor color, bool newLine = false)
{
    Console.ForegroundColor = color;
    Console.Write(information);
    Console.ResetColor();
    if(newLine)
    {
        Console.WriteLine();
    }
}

void print2DArray(int[,] array, string Name = "")
{
    printColor(Name,ConsoleColor.DarkCyan,true);
    Console.Write("\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        printColor(i + "\t",ConsoleColor.DarkYellow,(i >= array.GetLength(1) - 1));
    }
       for (int i = 0; i < array.GetLength(0); i++)
    {
        printColor(i + "\t",ConsoleColor.DarkYellow);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i!=j)
            {
                Console.Write(array[i,j] + "\t");
            }
            else
            {
                printColor(array[i,j] + "\t",ConsoleColor.DarkCyan);
            }
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] array = generate2DArray(5,5,10);
print2DArray(array, "Заданный массив");

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой элементов ");


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

