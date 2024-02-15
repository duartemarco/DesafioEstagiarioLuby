internal class Program
{
    private static void Main(string[] args)
    {
        //1.1
        CalcularFatorial(5);//120
            //Console.WriteLine(CalcularFatorial(5);
        //1.2
        CalcularPremio(100, "vip", null);
        CalcularPremio(100, "basic", 3);
            //Console.WriteLine(CalcularPremio(100, "vip", null));
            //Console.WriteLine(CalcularPremio(100, "basic", 3));
    }

    //1.1 Implemente a função abaixo para calcular fatorial de um número.
    private static int CalcularFatorial(int a)
    {
        int resposta = 1;
        for (int i = a; i >= 1; i--)
        {
            resposta *= i;
        }
        return resposta;
    }

    //1.2 Implemente a função abaixo que calcula o valor total do prêmio somando fator do tipo do prêmio conforme valores:
    private static int? CalcularPremio(double premio, string plano, double? fator)
    {
        if (premio > 0 && fator.HasValue)
        {
            // Fator sobrescreve o plano
            return (int)(premio * fator.Value);
        }
        else
        {
            switch (plano)
            {
                case "basic":
                    fator = 1.0;
                    break;
                case "vip":
                    fator = 1.2;
                    break;
                case "premium":
                    fator = 1.5;
                    break;
                case "deluxe":
                    fator = 1.8;
                    break;
                case "special":
                    fator = 2.0;
                    break;
                default:
                    fator = 1.0;
                    break;
            }
            return (int)(premio * fator);
        }
    }

    //1.3 Implemente a função abaixo para contar quantos números primos existe até o número informado.

}