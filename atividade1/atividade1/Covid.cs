using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{
    public class Covid : Virus
    {
        public int TotalQuarentenaDias { get; set; }

        // Implementação do método abstrato da classe base
        public override void ImprimirRecomendacoesTratamento()
        {
            Console.WriteLine($"Dia de retorno ao trabalho após {TotalQuarentenaDias} dias de quarentena.");
        }
    }
}
