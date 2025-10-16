using System;

namespace Desafio.Services
{
    public class RandomService : IRandomService
    {
        private readonly Random _random = new Random();

        public int GerarNumeroAleatorio()
        {
            return _random.Next(1, 1000);
        }
    }
}