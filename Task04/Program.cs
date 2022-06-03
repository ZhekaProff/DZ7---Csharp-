// В прямоугольной матрице найти строку с наименьшей суммой элементов. 
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

int SmallSumElements( int [,] matrix)
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0) 
            {
                sum = sum +  matrix[i, j];
                minSum = minSum + matrix[i, j]; 
            }
            else sum = sum + matrix[i, j]; 
        }
        if (sum < minSum)
        {
            minSum = sum;
            minNum = i;
        }
        sum = 0;
    }
    return minNum;
}

int [,] matrix = new int[3, 6];

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Cтрока с наименьшей суммой элементов: {SmallSumElements(matrix) + 1}");