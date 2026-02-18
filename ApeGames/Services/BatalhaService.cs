using ApeGames.Models;

namespace ApeGames.Services
{
    public class BatalhaService
    {
        private readonly Gorila _gorila;
        private readonly Inimigo _inimigo;

        public BatalhaService(Gorila gorila, Inimigo inimigo)
        {
            _gorila = gorila;
            _inimigo = inimigo;
        }

        public void Iniciar()
        {
            Console.WriteLine("🔥 BATALHA INICIADA 🔥");

            while (_gorila.Vida > 0 && _inimigo.Vida > 0)
            {
                TurnoJogador();

                if (_inimigo.Vida <= 0)
                {
                    Console.WriteLine("\n🏆 O Gorila venceu!");
                    break;
                }

                TurnoInimigo();

                if (_gorila.Vida <= 0)
                {
                    Console.WriteLine("\n💀 O Inimigo venceu!");
                    break;
                }

                MostrarStatus();
            }

            Console.WriteLine("\nFim da batalha!");
        }

        private void TurnoJogador()
        {
            Console.WriteLine("\n=== TURNO DO GORILA ===");
            Console.WriteLine("1 - Atacar");
            Console.WriteLine("2 - Ataque Especial");
            Console.WriteLine("3 - Comer Banana");
            Console.Write("Escolha: ");

            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    _gorila.Atacar(_inimigo);
                    break;

                case "2":
                    _gorila.Especial(_inimigo);
                    break;

                case "3":
                    _gorila.ComerBanana();
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        private void TurnoInimigo()
        {
            Console.WriteLine("\n=== TURNO DO INIMIGO ===");
            _inimigo.Atacar(_gorila);
        }

        private void MostrarStatus()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"Vida Gorila: {_gorila.Vida} | Energia: {_gorila.Energia}");
            Console.WriteLine($"Vida Inimigo: {_inimigo.Vida}");
            Console.WriteLine("---------------------------");
        }
    }
}
