class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        double[,] matriz = new double[2, 3];

        Console.WriteLine(matriz.Length);

        // quantidade de linhas
        Console.WriteLine(matriz.Rank);

        // tamanho da primeira dimensão (linhas)
        Console.WriteLine(matriz.GetLength(0));

        // tamanho da segunda dimensão (colunas)
        Console.WriteLine(matriz.GetLength(1));
    }
}
