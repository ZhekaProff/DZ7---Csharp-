// Написать программу, которая обменивает элементы первой строки и последней строки
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

Console.Write("Введите число строк: ");
int i = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов: ");
int j = int.Parse(Console.ReadLine() ?? "0");
int [,] matrix = new int[i, j];

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

int tmp = 0;
for ( j = 0; j < matrix.GetLength(1); j++)
{
     tmp = matrix[matrix.GetLength(0) - 1, j];
     matrix[matrix.GetLength(0) - 1, j] = matrix[0, j];
     matrix[0, j] = tmp;
}
PrintMatrix(matrix);
