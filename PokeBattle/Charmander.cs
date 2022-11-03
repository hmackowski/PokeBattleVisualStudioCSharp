using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeBattle
{
    
    internal class Charmander : Pokemon
    {
        

        String pname = "Charmander";
        private int hp = 0;
        private String[] moveSet = { "Ember", "Scratch", "Growl", "Flamethrower" };


        public void attack()
        {
            throw new NotImplementedException();
        }

        public String[] Array1
        {
            get { return moveSet; }
        }


        public String moves(int j)
        {
            return moveSet[j];
        }

        public String name()
        {
            return pname;
        }



        public Dictionary<string, int> move(int i)
        {
            throw new NotImplementedException();
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
