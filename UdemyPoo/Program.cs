class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        int ordemMatriz;

        Console.Write("Informe a ordem da matriz: ");
        ordemMatriz = int.Parse(Console.ReadLine() ?? "");

        int[,] matriz = new int[ordemMatriz, ordemMatriz];

        for (var i = 0; i < ordemMatriz; i++)
        {
            var input = Console.ReadLine() ?? "";
            string[] valores = input.Split(' ');

            for (var y = 0; y < ordemMatriz; y++)
            {
                matriz[i, y] = int.Parse(valores[y]);
            }
        }

        Console.WriteLine("Main diagonal:");

        for (var i = 0; i < ordemMatriz; i++)
            Console.Write(matriz[i, i] + " ");
        Console.WriteLine("");

        int count = 0;
        for (var i = 0; i < ordemMatriz; i++)
        {
            for (var y = 0; y < ordemMatriz; y++)
            {
                if (matriz[i, y] < 0)
                    count++;
            }
        }

        Console.WriteLine($"Negative number: {count}");
    }
}
