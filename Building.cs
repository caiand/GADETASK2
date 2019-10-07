using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memo
{
   abstract class Building
    {
        int xpos;
        int ypos;
        int health;
        int MaxHealth;
        int faction;
        string symbol;

        private int Xpos;

        public int posx
        {
            get { return posx; }
            set { posx = value; }
        }
        public int posy
        {
            get { return posy; }
            set { posy = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public int MaxH
        {
            get { return MaxHealth; }         
        }
        public int Faction
        {
            get { return faction; }
            set { faction = value; }
        }
        public int Symbol
        {
            get { return Symbol; }
        }
        public abstract void Destruct();
        public abstract override string ToString();

    }
}
