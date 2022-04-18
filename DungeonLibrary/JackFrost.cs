using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Jackfrost : Monster
    {
        public bool IsCold { get; set; }

        public Jackfrost(string name, int life, int maxLife, int hitChance, int block, int minDamage,
            int maxDamage, string description, bool isCold)
            : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            IsCold = isCold;

        }

      

        public override string ToString()
        {
            return base.ToString() + (IsCold ? "Mood Gloomy" : "Happy frost");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            
            if (IsCold)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }
    }
}
