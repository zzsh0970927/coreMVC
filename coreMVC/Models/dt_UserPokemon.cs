using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreMVC.Models
{
    public class dt_UserPokemon
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PokemonId { get; set; }
        public int PokemonLv { get; set; }
        public int PokemonItem { get; set; }
        public int Del { get; set; }
    }
}
