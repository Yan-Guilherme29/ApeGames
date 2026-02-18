using System;

namespace ApeGames.Models
{
    public class Gorila : Personagem
    {
        public int Energia { get; private set; }


        public Gorila(string nome, int vida, int forca, int energia) : base(nome,vida,forca)
        {
            Energia = energia;
        }

    public void Pular()
        {

            if (Energia >= 10)
            {
                Energia -= 10;
                Console.WriteLine($"Gorila {Nome} pulou! \n Energia restante: {Energia}");
            }
            else
            {
                Console.WriteLine($"Gorila {Nome} não tem energia suficiente para pular! \n Energia atual: {Energia}");
            }
        }

    public void ComerBanana()
        {
            Energia += 20;

            if (Energia > 100)
            {
                Energia = 100;
            }

            Console.WriteLine($"Gorila {Nome} comeu a banana! \n Mais 20 de Energia! \n Energia Atual: {Energia}");
        }

    public void Especial(Personagem alvo)
        {
            if (Energia >= 20)
            {
                Energia -= 20;
                int danoEspecial = Forca * 2;
                Console.WriteLine($"Gorila {Nome} usou o ataque especial contra {alvo.Nome}! \n Causou {danoEspecial} de dano! \n Energia restante: {Energia}");
                alvo.ReceberDano(danoEspecial);
            }
            else
            {
                Console.WriteLine($"Gorila {Nome} não tem energia suficiente para usar o ataque especial! \n Energia atual: {Energia}");
            }
        }
    }
}