using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreMVC.Models
{
    public class PokemonGoContext : DbContext
    {
        public PokemonGoContext(DbContextOptions<PokemonGoContext> options) : base(options)
        {

        }
        public DbSet<dt_Attribute> dt_Attribute { get; set; }
        public DbSet<dt_Item> dt_Item { get; set; }
        public DbSet<dt_pokemon> dt_pokemon { get; set; }
        public DbSet<dt_Skill> dt_Skill { get; set; }
        public DbSet<dt_UserPokemon> dt_UserPokemon { get; set; }
        public DbSet<dt_users> dt_users { get; set; }
    }
}
