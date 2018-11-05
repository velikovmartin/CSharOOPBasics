using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static List<Trainer> trainers;
        static void Main(string[] args)
        {
            trainers = new List<Trainer>();
            string input = Console.ReadLine();

            while (input != "Tournament")
            {
                string[] temp = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trainerName = temp[0];
                string pokemonName = temp[1];
                string pokemonElement = temp[2];
                int pokemonHelth = int.Parse(temp[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHelth);
                Trainer trainer = new Trainer(trainerName, pokemon);
                if (!trainers.Exists(x => x.Name == trainerName))
                {
                    trainers.Add(trainer);
                }
                else
                {
                    trainers.Find(x => x.Name == trainerName).Pokemon.Add(pokemon);
                }

                input = Console.ReadLine();
            }

            string element = Console.ReadLine();
            while (element != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemon.Exists(x => x.Element == element))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        foreach (var pokemons in trainer.Pokemon)
                        {
                            pokemons.Health -= 10;
                        }
                    }
                }
                trainers.ForEach(x => x.Pokemon.RemoveAll(item => item.Health <= 0));
                element = Console.ReadLine();
            }

            Print();
        }

        private static void Print()
        {
            foreach (var trainer in trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemon.Count}");
            }
        }
    }
}
