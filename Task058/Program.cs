﻿/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] Matrix1 = new Int32[2, 2];
int[,] Matrix2 = new Int32[2, 2];
int[,] MatrixS = new int[Matrix1.GetLength(0), Matrix2.GetLength(1)];

randomFilling(Matrix1, 1, 10);
randomFilling(Matrix2, 1, 10);

Console.WriteLine("Первая матрица: ");
arrayOutput(Matrix1);
Console.WriteLine(" ");

Console.WriteLine("Вторая матрица: ");
arrayOutput(Matrix2);
Console.WriteLine(" ");

arrayOutput(matrixMultiplication(Matrix1, Matrix2));

int[,] matrixMultiplication(int[,] Matrix1, int[,] Matrix2)
{
    for (int i = 0; i < Matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix2.GetLength(1); j++)
        {
            MatrixS[i, j] = 0;

            for (int k = 0; k < Matrix1.GetLength(1); k++)
            {
                MatrixS[i, j] += Matrix1[i, k] * Matrix2[k, j];
            }
        }
    }
    return MatrixS;
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

Console.WriteLine("Произведение двух матриц");
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