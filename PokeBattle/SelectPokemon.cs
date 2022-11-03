    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeBattle
{
    internal class SelectPokemon
    {
        private String[] pokemonName = { "Charmander", "Squirtle", "Bulbasaur" };

        public string selectPokemon(int selectPokemon)
        {
            switch (selectPokemon)
            {
                case 0:
                    PokeApp.partnerPokemon = new Charmander();
                    PokeApp.partnerPokemon.setHp(100);
                    break;
                case 1:
                    PokeApp.partnerPokemon = new Squirtle();
                    PokeApp.partnerPokemon.setHp(130);
                    break;
                case 2:
                    PokeApp.partnerPokemon = new Bulbasaur();
                    PokeApp.partnerPokemon.setHp(115);
                    break;
            }

            return PokeApp.partnerPokemon.name();
        }

        public String selectOpponentPokemon()
        {
            Random r = new Random();
            int oppPokemon = r.Next(0, pokemonName.Length);
            return pokemonName[oppPokemon];
        }
    }
}
