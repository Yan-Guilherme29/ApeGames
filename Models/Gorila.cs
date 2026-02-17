using System;

namespace SimiosGame.Models
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
    }
}