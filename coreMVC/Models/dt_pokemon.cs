using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreMVC.Models
{
    public class dt_pokemon
    {
        public int Id { get; set; }
        public string PokemonName { get; set; }
        public int PokemonAttribute { get; set; }
        public double PokemonAtk { get; set; }
        public double PokemonDef { get; set; }
        public double PokemonVit { get; set; }
        public int Del { get; set; }
        public int PokemonLevel { get; set; }
        public string PokemonItem { get; set; }
    }
}
