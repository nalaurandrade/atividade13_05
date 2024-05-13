using atividade2;

class Program
{
    static void Main(string[] args)
    {
        Estado estado = new Estado();

        Console.WriteLine("Cadastro de Cidades:");

        while (true)
        {
            Console.WriteLine("Digite o nome da cidade (ou 'sair' para encerrar):");
            string nomeCidade = Console.ReadLine();

            if (nomeCidade.ToLower() == "sair")
                break;

            Console.WriteLine("Digite a população da cidade:");
            int populacaoCidade;
            if (!int.TryParse(Console.ReadLine(), out populacaoCidade))
            {
                Console.WriteLine("População inválida. Tente novamente.");
                continue;
            }

            estado.CadastrarCidade(nomeCidade, populacaoCidade);
        }

        estado.ImprimirCidades();

        Cidade cidadeMaiorPopulacao = estado.LocalizarCidadeMaiorPopulacao();
        if (cidadeMaiorPopulacao != null)
        {
            Console.WriteLine($"Cidade com maior população: {cidadeMaiorPopulacao.Nome}, População: {cidadeMaiorPopulacao.Populacao}");
        }
    }
}