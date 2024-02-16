using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLuby
{
    public class Bebida
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Bebida(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public double GetPreco()
        {
            return Preco;
        }

        public void SetPreco(double preco)
        {
            Preco = preco;
        }

        public int GetQuantidade()
        {
            return Quantidade;
        }

        public void SetQuantidade(int quantidade)
        {
            Quantidade = quantidade;
        }
    }
}
