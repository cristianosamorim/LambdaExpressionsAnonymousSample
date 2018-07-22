using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace LambdaExpressionsAnonymousSample
{
    public class Cachorro
    {
        public string Nome{ get; set; }
        public int Idade { get; set; }
    }



    class Program
    {
        public static int CalculateElapsedDays(DateTime from, DateTime now) => (now - from).Days;


        static void Main(string[] args)
        {
            Expression<Func<double, double, double, double, double, double>> infix = (a, b, c, d, e) => a + b - c * d / 2 + e * 3;
            Expression<Func<int, int, int>> somaExp = (a, b) => (a + b);

            var testeValor = infix.Compile();
            Console.WriteLine(infix);
            Console.WriteLine(testeValor(1,2,3,4,5));
            Console.WriteLine("Calculando o total de dias {0}", CalculateElapsedDays(new DateTime(2022,11,18), DateTime.Now ));

            var list = MultpilicationFormatter.Format(Enumerable.Range(1, 10).ToList());
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }



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
