// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
Console.Clear();
void FillMatrix( int[,] matrix) // Заполняем рандомными числами
{
    for ( int i = 0; i < matrix.GetLength(0); i++)
    {
        for ( int j = 0; j < matrix.GetLength(1) ; j++)
        {
            matrix[i, j] = new Random().Next(0,10); 
        }
    
    }


}

void PrintMatrix(int [,] matrix) // функция печати матрицы
{
    for ( int  i = 0; i < matrix.GetLength(0); i++)
    {
        for ( int j = 0; j < matrix.GetLength(1) ; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

void SortingMatrix(int[,] matrix) // 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int count = 0; count < matrix.GetLength(1) - 1; count++)
            {
                if (matrix[i, count] < matrix[i, count + 1])
                {
                    int t = matrix[i, count];
                    matrix[i, count] = matrix[i, count + 1];
                    matrix[i, count + 1] = t;
                }
            }
        }
    }
}

Console.Write("Введите число строк: ");
int i = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов: ");
int j = int.Parse(Console.ReadLine() ?? "0");
int [,] matrix = new int[i, j];

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
SortingMatrix(matrix);
PrintMatrix(matrix);