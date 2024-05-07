namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        //Pede para o usuário digitar uma placa (ReadLine) e adiciona na lista "veiculos"
        public void AdicionarVeiculo()
        {
            string placaVeiculo = null;

            while(placaVeiculo == null)
            {
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                placaVeiculo = Console.ReadLine();
                if(placaVeiculo == null)
                {
                    Console.WriteLine("Placa inválida. Digite novamente");
                }
                else
                {
                    veiculos.Add(placaVeiculo);
                    Console.WriteLine("Veiculo adicionado!");
                }
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover: ");
            // Pede para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado.     
                int horas = 0;
                bool sucesso = int.TryParse(Console.ReadLine(), out horas);

                if (!sucesso)
                {
                    Console.WriteLine("Por favor, digite um número válido para as horas.");
                }
                decimal valorTotal = 0; 

                // Realiza o cálculo para a variável valorTotal
                valorTotal = precoInicial + precoPorHora * horas;

                // Remove a placa digitada da lista de veículos
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Realiza um laço de repetição, exibindo os veículos estacionados
                foreach(string v in veiculos)
                {
                Console.WriteLine(v);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
