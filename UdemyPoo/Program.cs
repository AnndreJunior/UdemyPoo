using UdemyPoo;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        /*
        ambas as variáveis recebem o valor da soma retornado pelo método Sum
        não há sobrecarga de métodos, mas apenas um método que recebe um array de números
        usando o modificador de parâmetros (params) não é necessário passar uma instância de um array de números(new int[] { values })
        */
        var value1 = new Calculator().Sum(3, 5);
        var value2 = new Calculator().Sum(3, 5, 7);

        Console.WriteLine(value1);
        Console.WriteLine(value2);

        /*
        aqui é necessário passar um array como parâmetro
        dependendo da versão do C#/.net será necessário passar uma instância (new int[] { 3, 5, 7 })
        */
        var value3 = new Calculator().Sum2([3, 5]);
        var value4 = new Calculator().Sum2([3, 5, 7]);

        Console.WriteLine(value3);
        Console.WriteLine(value4);
    }
}