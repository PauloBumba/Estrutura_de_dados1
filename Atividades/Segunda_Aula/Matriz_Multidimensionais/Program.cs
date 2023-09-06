
Console.WriteLine("Digite o número de linhas da matriz:");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número de colunas da matriz:");
int cols = int.Parse(Console.ReadLine());
int[,] matrix = new int[rows, cols];


for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
    
        Console.WriteLine("Digite o valor do elemento [" + i + ", " + j + "]:");
        int value = int.Parse(Console.ReadLine());
        matrix[i, j] = value;
    }
}


Console.WriteLine("A matriz foi criada com os seguintes valores:");

// Percorre as linhas da matriz
for (int i = 0; i < rows; i++)
{
    
    for (int j = 0; j < cols; j++)
    {

        Console.Write($matrix[i, j] + " ");
    }

    Console.WriteLine();
}
