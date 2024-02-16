using ProjetoLuby;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo à Máquina de Bebidas da Lupy!");
        //Console.WriteLine("Inicializando sistema:");
        VendingMachine vendingMachine = new VendingMachine();
        int entrada;

        // Adicionando bebidas ao estoque
        vendingMachine.AdicionarBebida(new Bebida("Pepsi", 3.00, 20));
        vendingMachine.AdicionarBebida(new Bebida("Fanta", 3.20, 18));
        vendingMachine.AdicionarBebida(new Bebida("Coca Cola", 4.0, 20));
        vendingMachine.AdicionarBebida(new Bebida("Lipton", 2.80, 15));

        do
        {
            ExibeMenu();
            entrada = int.Parse(Console.ReadLine());

            switch (entrada)
            {
                case 1:
                    vendingMachine.MostrarBebidas();
                    Console.WriteLine("Escolha sua bebida: (1- Pepsi, 2- Fanta, 3- Coca Cola, 4- Lipton): ");
                    int idBebida = int.Parse(Console.ReadLine());
                    string nomeBebida = null;
                    switch (idBebida)
                    {
                        case 1:
                            nomeBebida = "Pepsi";
                            break;
                        case 2:
                            nomeBebida = "Fanta";
                            break;
                        case 3:
                            nomeBebida = "Coca Cola";
                            break;
                        case 4:
                            nomeBebida = "Lipton";
                            break;
                        default:
                            Console.WriteLine("ID de bebida inválido.");
                            break;
                    }
                    if (nomeBebida != null)
                    {
                        Console.WriteLine("Informe a quantidade: ");
                        int unidades = int.Parse(Console.ReadLine());
                        int quantidadeDisponivel = vendingMachine.GetQuantidadeBebida(nomeBebida);
                        if (unidades <= quantidadeDisponivel)
                        {
                            Console.WriteLine("Informe o valor pago: ");
                            double valorPago = double.Parse(Console.ReadLine());
                            vendingMachine.ComprarBebida(nomeBebida, valorPago, unidades);
                        }
                        else
                        {
                            Console.WriteLine("Quantidade insuficiente em estoque.");
                        }
                    }
                    break;
                case 2:
                    vendingMachine.MostrarBebidas();
                    break;
                case 3:
                    vendingMachine.MostrarVendas();
                    break;
                case 4:
                    Console.WriteLine("Encerrando programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (entrada != 4);
    }

    public static void ExibeMenu()
    {
        Console.WriteLine("\nEscolha uma opção:");
        Console.WriteLine("1 - Comprar Bebida");
        Console.WriteLine("2 - Visualizar Estoque");
        Console.WriteLine("3 - Mostrar Total de Vendas");
        Console.WriteLine("4 - Sair");
    }
}