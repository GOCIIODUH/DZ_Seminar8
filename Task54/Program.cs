// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int[,] CreatingMatrix(int numberRows, int numberColumns, int leftBorder, int rightBorder)
{
    int[,] matrix = new int[numberRows, numberColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftBorder, rightBorder + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

}
int InputData(string text)
{
    System.Console.Write(text);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int[,] ArrangeRows(int[,] matrix)
{
    int previous;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int nj = j + 1; nj < matrix.GetLength(1); nj++)
            {
                if (matrix[i, j] < matrix[i, nj])
                {
                    previous = matrix[i, j];
                    matrix[i, j] = matrix[i, nj];
                    matrix[i, nj] = previous;
                }
            }
        }
    }
    return matrix;
}


int numberRows = InputData("Введите необходимое количество строк матрицы: ");
int numberColumns = InputData("Введите необходимое количество столбцов матрицы: ");
int leftBorder = InputData("Введите левую границу для формирования матрицы: ");
int rightBorder = InputData("Введите правую границу для формирования матрицы: ");


int[,] myMatrix = CreatingMatrix(numberRows, numberColumns, leftBorder, rightBorder);
PrintMatrix(myMatrix);
System.Console.WriteLine();
PrintMatrix(ArrangeRows(myMatrix));
