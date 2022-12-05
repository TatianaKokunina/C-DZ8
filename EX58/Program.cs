/*  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/
int[,] firstMatrix = new Int32[2, 2];
int[,] secondMatrix = new Int32[2, 2];
int[,] newMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

randomFilling(firstMatrix, 1, 10);
randomFilling(secondMatrix, 1, 10);

Console.WriteLine("Первая матрица: ");
arrayOutput(firstMatrix);
Console.WriteLine(" ");

Console.WriteLine("Вторая матрица: ");
arrayOutput(secondMatrix);
Console.WriteLine(" ");
Console.WriteLine("Произведение двух матриц");
arrayOutput(matrixMultiplication(firstMatrix, secondMatrix));

int[,] matrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = 0;

            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                newMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return newMatrix;
}

void randomFilling(int[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
}

void arrayOutput(int[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }

        Console.WriteLine(" ");
      
    }
}