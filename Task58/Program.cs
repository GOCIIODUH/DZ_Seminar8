// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] ProductTwoMatrix(int[,] matrix1, int[,] matrix2)
{
    int x = 0;
    if (matrix1.GetLength(0) > matrix2.GetLength(0))
    {
        x = matrix1.GetLength(0);
    }
    else
    {
        x = matrix2.GetLength(0);
    }
    int[,] composition = new int[matrix1.GetLength(0), matrix1.GetLength(0)];
    for (int m = 0; m < matrix1.GetLength(0); m++)
    {
        for (int n = 0; n < matrix1.GetLength(0); n++)
        {
            for (int j = 0; j < x; j++)
            {
                composition[m, n] += matrix1[m, j] * matrix2[j, n];
            }
        }
    }
    return composition;
}

bool CheckMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(0) == matrix2.GetLength(1) && matrix1.GetLength(1) == matrix2.GetLength(0)) return true;
    else
    {
        return false;
    }
}

int numberRows1 = InputData("Введите необходимое количество строк 1 матрицы: ");
int numberColumns1 = InputData("Введите необходимое количество столбцов 1 матрицы: ");
int leftBorder1 = InputData("Введите левую границу для формирования 1 матрицы: ");
int rightBorder1 = InputData("Введите правую границу для формирования 1 матрицы: ");

int numberRows2 = InputData("Введите необходимое количество строк 2 матрицы: ");
int numberColumns2 = InputData("Введите необходимое количество столбцов 2 матрицы: ");
int leftBorder2 = InputData("Введите левую границу для формирования 2 матрицы: ");
int rightBorder2 = InputData("Введите правую границу для формирования 2 матрицы: ");


int[,] myMatrix1 = CreatingMatrix(numberRows1, numberColumns1, leftBorder1, rightBorder1);
int[,] myMatrix2 = CreatingMatrix(numberRows2, numberColumns2, leftBorder2, rightBorder2);

PrintMatrix(myMatrix1);
System.Console.WriteLine();
PrintMatrix(myMatrix2);
System.Console.WriteLine();

if (CheckMatrix(myMatrix1, myMatrix2) == true)
{
    PrintMatrix(ProductTwoMatrix(myMatrix1, myMatrix2));
}
else
{
    System.Console.WriteLine("Чтобы можно было умножить две матрицы, количество столбцов первой матрицы должно быть равно количеству строк второй матрицы");
}

