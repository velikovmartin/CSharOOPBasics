using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemon = new List<Pokemon>();

        public Trainer(string name, Pokemon pokemon, int badges = 0)
        {
            this.Name = name;
            this.Pokemon.Add(pokemon);
            this.Badges = badges;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Badges
        {
            get { return badges; }
            set { badges = value; }
        }

        public List<Pokemon> Pokemon
        {
            get { return pokemon; }
            set { pokemon = value; }
        }
    }
}
