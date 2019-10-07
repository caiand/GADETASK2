using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Name
{
    Footsoldier,
    Knight,
    Tank,
    Healer,
    Assassin,
    Mage
}
namespace Memo
{
    public abstract class Unit
    {
        protected int Posx;
        protected int Posy;
        protected int health;
        protected int attack;
        protected int attackRange;
        protected int MaxHealth;
        protected int speed;
        protected int faction;
        protected string symbol;
        protected bool unitattack;
        Name type;

        public abstract void Move(int dir);
        public abstract void Combat(Unit attacker);
        public abstract void InRange(Unit other);
        public abstract void Death();
        public abstract override string ToString();



    }
}

