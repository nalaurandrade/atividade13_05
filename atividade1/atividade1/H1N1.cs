using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{
    public class H1N1 : Virus
    {
        public override void ImprimirRecomendacoesTratamento()
        {
            Console.WriteLine("Digite a variação do H1N1 (AAA ou outra):");
            string variacao = Console.ReadLine();
            string resultado = AnalisarVariacao(variacao);
            Console.WriteLine(resultado);
        }

        public string AnalisarVariacao(string variacao)
        {
            if (variacao == "AAA")
            {
                return "Ficar em casa por 5 dias.";
            }
            else
            {
                return "Pode trabalhar e usar máscara.";
            }
        }
    }

}
