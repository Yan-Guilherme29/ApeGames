using System;

namespace SimiosGame.Models
{
    public class Personagem
    {
        public string Nome { get;set;}
        public int Vida { get; private set;}
        public int Forca {get;set;}
    
        public Personagem (string nome, int vida, int forca) {
            Nome = nome;
            Vida = vida;
            Forca = forca;
        }


        public void Atacar(Personagem alvo )
        {
            Console.WriteLine($"{Nome} atacou {alvo.Nome} com o total de {Forca} danos de força!");
            alvo.ReceberDano(Forca);
        }


        public void ReceberDano(int dano)
        {
            Vida -= dano;
                if (Vida < 0)
            {
                Vida = 0;
            }

            Console.WriteLine($"{Nome} recebeu {dano} de dano! \n Vida restante: {Vida}");

        }
    }
}



