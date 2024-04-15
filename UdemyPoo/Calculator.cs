namespace UdemyPoo;

public class Calculator
{
    // esse modificador de acesso (params) faz o compilador entender que ele pode receber vários valores por parâmetro e que eles devem ser armazenados no array values
    public int Sum(params int[] values)
    {
        int sumValue = 0;

        foreach (int value in values)
        {
            sumValue += value;
        }

        return sumValue;
    }

    // mesmo método mas de forma mais "tradicional" usando um array
    public int Sum2(int[] values)
    {
        int sumValue = 0;

        foreach (int value in values)
        {
            sumValue += value;
        }

        return sumValue;
    }
}
