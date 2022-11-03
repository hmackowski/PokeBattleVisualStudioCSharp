using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBattle
{
    internal class Squirtle : Pokemon
    {
        String pname = "Squirtle";
        private int hp = 0;
        private String[] moveSet = { "Bubble", "Tackle", "Tail Whip", "Water Gun" };

        public void attack()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, int> move(int i)
        {
            throw new NotImplementedException();
        }

        public string moves(int i)
        {
            return moveSet[i];
        }

        public string name()
        {
            return pname;
        }

        public int getAttackDamage(int attack)
        {
            Random r = new Random();
            int damage = 0;
            switch (attack)
            {
                case 0:
                    damage = r.Next(18, 22);
                    break;
                case 1:
                    damage = r.Next(8, 12);
                    break;
                case 2:
                    damage = r.Next(7, 10);
                    break;
                default:
                    damage = r.Next(20, 25);
                    break;
            }
            return damage;
        }

        public int getHp()
        {
            return hp;
        }

        public void setHp(int hp)
        {
            this.hp = hp;
        }
    }
}
