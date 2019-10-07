using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memo
{
    public abstract class Melee : Unit
    {
        public bool IsDead { get; set; }
        public int Xpos
        {
            get { return base.Posx; }
            set { base.Posx = value; }
        }

        public int Ypos
        {
            get { return base.Posy; }
            set { base.Posy = value; }
        }

        public int Health
        {
            get { return base.health; }
            set { base.health = value; }
        }
        public int Maxhealth
        {
            get { return base.MaxHealth; }
        }
        public int Attack
        {
            get { return base.attack; }
            set { base.attack = value; }
        }
        public int Spped
        {
            get { return base.speed; }
            set { base.speed = value; }
        }

        public int AttackRange
        {
            get { return base.attackRange; }
            set { base.attackRange = value; }
        }
        public int Faction
        {
            get { return base.faction; }
            set { base.faction = value; }
        }
        public string Symbol
        {
            get { return base.symbol; }
            set { base.symbol = value; }
        }
        public bool UnitAttack
        {
            get { return base.unitattack; }
            set { base.unitattack = value; }
        }
        public Melee(int x, int y, int h, int s, int a, int f, string sy)
        {
            Xpos = x;
            Ypos = y;
            health = h;
            base.MaxHealth = h;
            speed = s;
            attack = a;
            attackRange = 1;
            base.faction = f;
            symbol = sy;
            UnitAttack = false;
            IsDead = false;

        }

        public override void Death()
        {
            symbol = "D";
            IsDead = true;
        }
        public override void Move(int dir)
        {
            switch (dir)
            {
                case 0: Ypos--; break;//North
                case 1: Xpos++; break;//East
                case 2: Ypos++; break;//South
                case 3: Xpos--; break;//West
                default: break;
            }
        }
        public override void Combat(Unit attacker)
        {
            if (attacker is Melee)
            {
                health = health - ((Melee)attacker).Attack;
            }
            else if (attacker is Range)
            {
                Range ru = ((Range)attacker);
                health = health - (ru.Attack - ru.AttackRange);
            }

            if (health <= 0)
            {
                Death();//YOU DEAD BITCHHHH!!!!!!
            }

        }
        public override void InRange(Unit other)
        {
            int disatnce = 0;
            int otherX, otherY;
            if (other is Melee)
            {
                otherX = ((Melee)other).Xpos;
                otherY = ((Melee)other).Ypos;
            }
            else if (other is Range)
            {
                otherX = ((Range)other).Xpos;
                otherY = ((Range)other).Ypos;
            }


            disatnce = Math.Abs(Xpos - otherX) + Math.Abs(Ypos - otherY);
            if (disatnce <= AttackRange)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            string temp = "";
            temp += (this is Melee ? "Melee:" : "Ranged: ");
            temp += "{" + symbol + "}";
            temp += "{" + Xpos + "," + Ypos + "}";
            temp += health + "," + attack + "," + attackRange + "," + speed + "}";
            temp += (IsDead ? "Dead" : "Alive");
            return ",";
        }
    }
}
