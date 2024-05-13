using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade2
{
    public class Estado
    {
        private List<Cidade> cidades;

        public Estado()
        {
            cidades = new List<Cidade>();
        }

        public void CadastrarCidade(string nome, int populacao)
        {
            Cidade novaCidade = new Cidade { Nome = nome, Populacao = populacao };
            cidades.Add(novaCidade);
        }

        public void ImprimirCidades()
        {
            Console.WriteLine("Cidades do estado:");
            foreach (var cidade in cidades)
            {
                Console.WriteLine($"Nome: {cidade.Nome}, População: {cidade.Populacao}");
            }
        }

        public Cidade LocalizarCidadeMaiorPopulacao()
        {
            if (cidades.Count == 0)
            {
                Console.WriteLine("Não há cidades cadastradas.");
                return null;
            }

            Cidade cidadeMaiorPopulacao = cidades[0];
            foreach (var cidade in cidades)
            {
                if (cidade.Populacao > cidadeMaiorPopulacao.Populacao)
                {
                    cidadeMaiorPopulacao = cidade;
                }
            }

            return cidadeMaiorPopulacao;
        }
    }


}
