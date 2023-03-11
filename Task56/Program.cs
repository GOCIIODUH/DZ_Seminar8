// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
int SmallestAmount(int[,] matrix)
{
    int[] sumArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumArray[i] += matrix[i, j];
        }
    }
    int min = sumArray[0];
    int index = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        if (sumArray[i] < min)
        {
            min = sumArray[i];
            index = i+1;
        }
    }
    return index;
}


int numberRows = InputData("Введите необходимое количество строк матрицы: ");
int numberColumns = InputData("Введите необходимое количество столбцов матрицы: ");
int leftBorder = InputData("Введите левую границу для формирования матрицы: ");
int rightBorder = InputData("Введите правую границу для формирования матрицы: ");


int[,] myMatrix = CreatingMatrix(numberRows, numberColumns, leftBorder, rightBorder);
PrintMatrix(myMatrix);
System.Console.WriteLine($"{SmallestAmount(myMatrix)} строка");
