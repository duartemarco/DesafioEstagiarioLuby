using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        //1.1
        CalcularFatorial(5);//120
        //Console.WriteLine(CalcularFatorial(5));

        //1.2
        CalcularPremio(100, "vip", null);//120
        CalcularPremio(100, "basic", 3);//300
        //Console.WriteLine(CalcularPremio(100, "vip", null));
        //Console.WriteLine(CalcularPremio(100, "basic", 3));

        //1.3
        //ContarNumerosPrimos(10);//4
        //Console.WriteLine(ContarNumerosPrimos(10));

        //1.4
        CalcularVogais("Luby Software");//4
        //Console.WriteLine(CalcularVogais("Luby Software"));

        //1.5
        //CalcularValorComDescontoFormatado("R$ 6.800,00", "30%")//"R$ 4.760,00"
        Console.WriteLine(CalcularValorComDescontoFormatado("R$ 6.800,00", "30%"));

        //1.6
        Console.WriteLine(CalcularDiferencaData("10122020", "25122020"));


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

    /*
    //1.3 Implemente a função abaixo para contar quantos números primos existe até o número informado.
    private static int ContarNumerosPrimos(int valor)
    {
        int contagem = 0;
        for (int i = 2; i < valor; i++)
        {
            if(VerificaPrimo(valor) == true)
            {
                contagem++;
            }

        }
    }
    private static bool VerificaPrimo(int valor)
    {
        if (valor <= 1)
        {
            return false;
        }
    }
    */

    //1.4 Implemente a função abaixo que conta e calcula a quantidade de vogais dentro de uma string.
    private static int CalcularVogais(string palavra)
    {
        int contagem = 0;
        palavra = palavra.ToLower();
        for (int i = 0; i < palavra.Length; i++)
        {
            if (palavra[i] == 'a' || palavra[i] == 'e' || palavra[i] == 'i' || palavra[i] == 'o' || palavra[i] == 'u')
            {
                contagem++;
            }
        }
        return contagem;
    }

    //1.5 Implemente a função abaixo que aplica uma porcentagem de desconto a um valor e retorna o resultado.
    private static string CalcularValorComDescontoFormatado(string valor, string desconto)
    {
        decimal value = decimal.Parse(valor.Replace("R$", "").Replace(".", "").Replace(",", "."));
        decimal discount = decimal.Parse(desconto.Replace("%", "")) / 100;
        decimal resultado = value * (1 - discount);
        return string.Format("R$ {0:#,0.00}", resultado);
    }

    //1.6 Implemente a função abaixo que obtém duas string de datas e calcula a diferença de dias entre elas.
    private static int CalcularDiferencaData(string data1, string data2)
    {
        
        CultureInfo ptBR = new CultureInfo("pt-BR");
        DateTime dataConvertida1 = DateTime.ParseExact(data1, "ddMMyyyy", ptBR, DateTimeStyles.None);
        DateTime dataConvertida2 = DateTime.ParseExact(data2, "ddMMyyyy", ptBR, DateTimeStyles.None);
        TimeSpan diferenca = dataConvertida2 - dataConvertida1;
        return diferenca.Days;

    }
}