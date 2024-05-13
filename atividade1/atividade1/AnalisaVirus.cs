using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace atividade1
{
    public class AnalisaVirus
    {
        // Método para escolher e analisar o vírus
        public void AnalisarVirus()
        {
            Console.WriteLine("Escolha o tipo de vírus (Covid ou H1N1):");
            string tipoVirus = Console.ReadLine();

            Virus virus;

            // Verifica o tipo de vírus escolhido
            if (tipoVirus.ToLower() == "covid")
            {
                virus = new Covid();
                Console.WriteLine("Digite o total de dias de quarentena:");
                ((Covid)virus).TotalQuarentenaDias = int.Parse(Console.ReadLine());
            }
            else if (tipoVirus.ToLower() == "h1n1")
            {
                virus = new H1N1();
            }
            else
            {
                Console.WriteLine("Tipo de vírus inválido.");
                return;
            }

            // Imprime as recomendações de tratamento
            virus.ImprimirRecomendacoesTratamento();
        }
    }
}
