namespace ApeGames.Models
{
    public class Inimigo : Personagem
    {
        public Inimigo(string nome, int vida, int forca) 
            : base(nome, vida, forca)
        {
        }

        public void Provocar()
        {
            Console.WriteLine($"Inimigo {Nome} está provocando!");
        }
    }
}