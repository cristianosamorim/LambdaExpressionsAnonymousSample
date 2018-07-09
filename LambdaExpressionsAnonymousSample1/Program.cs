using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionsAnonymousSample1
{
    public class Cachorro
    {
        public string Nome{ get; set; }
        public int Idade { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var animal = new List<Cachorro>() {
                new Cachorro { Nome = "Neymar", Idade = 4 },
                new Cachorro { Nome = "Fernandinho", Idade = 9 },
                new Cachorro { Nome = "Miranda", Idade = 3 }
            };

            var animalLista = animal.Select(x => new { Idade = x.Idade, NomeAnimal = x.Nome });

            foreach (var item in animalLista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();

            var sortedDogs = animalLista.OrderByDescending(x => x.Idade);
            foreach (var dog in sortedDogs)
            {
                Console.WriteLine($"Meu cachorro {dog.NomeAnimal} com a idade de {dog.Idade} passados.");
            }

            Console.Read();
        }
    }
}
