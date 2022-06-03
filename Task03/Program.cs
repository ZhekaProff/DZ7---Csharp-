// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

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


Console.Clear();
Console.Write("Введите число строк: ");
int i = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов: ");
int j = int.Parse(Console.ReadLine() ?? "0");
int [,] matrix = new int[i, j];

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

if (matrix.GetLength(0) == matrix.GetLength(1))
{
    int[,] tmp = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for ( i = 0; i < matrix.GetLength(0); i++)
    {
        for ( j = 0; j < matrix.GetLength(1); j++)
        {
            tmp[i, j] = matrix[i, j];
        }
    }
    for ( i = 0; i < matrix.GetLength(0); i++)
    {
        for ( j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = tmp[j, i];
        }
    }
PrintMatrix(matrix);
}
else
{
    Console.WriteLine("Матрица не квадратная");
}