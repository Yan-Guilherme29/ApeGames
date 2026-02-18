using ApeGames.Models;
using ApeGames.Services;

Gorila gorila = new Gorila("Kong", 100, 15, 50);
Inimigo inimigo = new Inimigo("Caçador", 80, 10);

BatalhaService batalha = new BatalhaService(gorila, inimigo);
batalha.Iniciar();
