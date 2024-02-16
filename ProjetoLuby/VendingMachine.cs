using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLuby
{
    public class VendingMachine
    {
        private double totalDeVendas = 0;
        private Dictionary<string, Bebida> bebidas = new Dictionary<string, Bebida>();

        public void AdicionarBebida(Bebida bebida)
        {
            bebidas[bebida.Nome] = bebida;
        }

        public void MostrarBebidas()
        {
            Console.WriteLine("\nBebidas Disponíveis:");
            foreach (var par in bebidas)
            {
                Console.WriteLine($"{par.Key}: R${par.Value.GetPreco().ToString("F2")}. Quantidade: {par.Value.GetQuantidade()}");
            }
        }

        public void ComprarBebida(string nomeBebida, double valorPago, int unidades)
        {
            if (!bebidas.ContainsKey(nomeBebida) || bebidas[nomeBebida].GetQuantidade() <= 0)
            {
                Console.WriteLine("Bebida não encontrada no estoque");
                return;
            }

            var bebida = bebidas[nomeBebida];
            if (valorPago < bebida.GetPreco() * unidades)
            {
                Console.WriteLine($"Valor insuficiente. Falta R${((bebida.GetPreco() * unidades) - valorPago).ToString("F2")} para comprar {unidades} unidades de {bebida.Nome}");
                return;
            }

            bebida.SetQuantidade(bebida.GetQuantidade() - unidades);
            totalDeVendas += bebida.GetPreco() * unidades;
            double troco = valorPago - (bebida.GetPreco() * unidades);
            Console.WriteLine($"\nComprou {unidades} unidades de {bebida.Nome}. Troco: R${troco.ToString("F2")}");
        }

        public void MostrarVendas()
        {
            Console.WriteLine($"Valor total de Vendas: R${totalDeVendas.ToString("F2")}");
        }

        public int GetQuantidadeBebida(string nomeBebida)
        {
            if (bebidas.ContainsKey(nomeBebida))
                return bebidas[nomeBebida].GetQuantidade();
            else
                return 0;
        }
    }
}
