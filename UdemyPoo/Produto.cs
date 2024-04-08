namespace UdemyPoo;

public class Produto
{
    public string Name;
    public double Price;
    public int Amount;

    // construtor padrão
    public Produto()
    {
        Amount = 0;
    }

    /*
        construtor que recebe dois argumentos
        o detalhe é que eu teria que declarar o valor padrão para Amount (Amount = 0)
        quando eu faço ': this()' estou usando o construtor padrão dentro do construtor
        que recebe dois argumentos
    */
    public Produto(string name, double price) : this()
    {
        Name = name;
        Price = price;
    }

    /*
        retorna dois erros
        o primeiro é porque não existe um atributo algo
        se corrigirmos esse erro, o outro é porque não existe um construtor que recebe 'algo' como argumento
    */
    // public Produto (string name, double price) : this(algo)
    // {
    //     Name = name;
    //     Price = price;
    // }

    /*
        aqui o 'this' faz referência ao construtor que recebe dois argumentos: name e price
    */
    public Produto(string name, double price, int amount) : this(name, price)
    {
        Amount = amount;
    }
}
