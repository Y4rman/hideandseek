using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hideandseek
{
    internal class seeker
    {
        private int hp = 100;
        private int damage = 20;
        private int speed = 100;

        public void SeekMiss(int dmg)
        {
            hp -= dmg;
        }
        
        public int GetDamage()
        {
            return damage;
        }
    }
}
