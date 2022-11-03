using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBattle
{
    public interface Pokemon
    {
        
        String name();
        String moves(int i);

        void attack();
        int getAttackDamage(int attack);
        int getHp();
        void setHp(int hp);

    }

    
}
