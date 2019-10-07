using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memo
{
    class GameEngine
    {
        Map map;
        private int round;
        Random r = new Random();
      
        public int rnd()
        {
            get;
            { return round; }
           
        }
        public int ProductionSpeed()
        {
            get;
            { return ProductionSpeed;}
        }

        public GameEngine(int numUnits, Textbox txtInfo, Groupbox grpMap)
        {
            grpMap = grpMap;
            Map map = new Map(20, txtInfo);
            map.Generate();
            map.Display(grpMap);

            round = 1;
        }
        public void Update()
        {
           foreach( Unit u in map.Units)
            {
                if(u is Melee)
                {
                    Melee mu = (Melee)u;
                    if (mu.Health <= mu.Maxhealth * 0.25)
                    {
                        mu.Move(r.Next(0, 4));
                    }
                    else
                    {
                        int shortest = 100;
                        Unit closest = mu;
                        foreach (Unit U in map.Units)
                        {
                            if(u is Melee)
                            {
                                Melee othermu = (Melee)U;
                               int distance = Math.Abs(mu.Xpos - othermu.Xpos) + Math.Abs(mu.Ypos - othermu.Ypos);
                              if(distance < shortest)
                                {
                                    shortest = distance;
                                    closest = othermu;
                                }
                            }
                        }
                        if (shortest <= mu.AttackRange)
                        {
                            mu.UnitAttack = true;
                            mu.Combat(closest);
                        }
                        else
                        {
                            if(closest is Melee)
                            {
                                Melee closestmu = (Melee)closest;
                                if (mu.Xpos > closestmu.Xpos)
                                {
                                    mu.Move(0);
                                }
                                else if(mu.Xpos<closestmu.Xpos)
                                {
                                    mu.Move(0);
                                }
                                else if (mu.Xpos < closestmu.Xpos)
                                {
                                    mu.Move(2);
                                }
                                else if (mu.Xpos < closestmu.Xpos)
                                {
                                    mu.Move(3);
                                }
                                else if (mu.Xpos < closestmu.Xpos)
                                {
                                    mu.Move(1);
                                }
                            }

                        }
                    }
                }
            }
            map.Display(grpMap);
            round++;
        }
    }
}
