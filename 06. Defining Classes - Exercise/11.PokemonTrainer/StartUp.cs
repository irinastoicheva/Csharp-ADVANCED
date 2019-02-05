namespace _11.PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Trainer> trainers = new List<Trainer>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Tournament")
                {
                    break;
                }

                string[] information = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = information[0];
                string pokemonName = information[1];
                string pokemonElement = information[2];
                int pokemonHealth = int.Parse(information[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (trainers.Where(x => x.Name == trainerName).Count() == 0)
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainers.Add(trainer);
                    trainer.AddPokemon(pokemon);
                }
                else
                {
                    Trainer trainer = trainers.Where(x => x.Name == trainerName).FirstOrDefault();
                    trainer.AddPokemon(pokemon);
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string element = command;

                foreach (Trainer trainer in trainers)
                {
                    if (trainer.Pokemons.Any(x => x.Element == element))
                    {
                        trainer.Badges += 1;
                    }
                    else
                    {
                        trainer.LoseHealth();
                        trainer.Pokemons = trainer.Pokemons.Where(x => x.Health > 0).ToList();
                    }
                }

                command = Console.ReadLine();
            }

            foreach (Trainer trainer in trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count()}");
            }
        }
    }
}
