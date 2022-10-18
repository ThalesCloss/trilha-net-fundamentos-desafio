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

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine()?.ToUpper();
            if (placa.Length == 0)
            {
                Console.WriteLine("A placa não foi informada, nenhum veículo será estacionado");
                return;
            }
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine()?.ToUpper();

            if (!veiculos.Contains(placa))
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                return;
            }

            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

            int.TryParse(Console.ReadLine(), out int horas);
            decimal valorTotal = precoInicial + (precoPorHora * horas);

            veiculos.Remove(placa);

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal:C}");

        }

        public void ListarVeiculos()
        {
            if (!veiculos.Any())
            {
                Console.WriteLine("Não há veículos estacionados.");
                return;

            }
            Console.WriteLine("Os veículos estacionados são:");
            veiculos.ForEach((placa) => Console.WriteLine(placa));

        }
    }
}
