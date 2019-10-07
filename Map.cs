using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Map
    {

        Random r = new Random();
        public List<Unit> units = new List<Unit>();
        int NumUni;

        public Map(int unitU = 0)
        {
            NumUni = unitU;
        }
        public void BattleField()
        {
            for(int i = 0; i < NumUni; i++)
            {
                if (r.Next(0, 2) == 0)
                {
                    RangedUnit archer = new RangedUnit(0, 0, Faction.Punks, 12, 5, 2, 3, Color.Blue, false);
                    units.Add(archer);
                }
                else
                {
                    MeleeUnit warrior = new MeleeUnit(0, 0, Faction.Punks, 15, 7, 3, 3, Color.Red, false);
                    units.Add(warrior);
                }
            }
            for (int i = 0; i < NumUni; i++)
            {
                if (r.Next(0, 2) == 0)
                {
                    RangedUnit archer = new RangedUnit(0, 0, Faction.Diesel, 12, 5, 2, 3, Color.Blue, false);
                    units.Add(archer);
                }
                else
                {
                    MeleeUnit warrior = new MeleeUnit(0, 0, Faction.Diesel, 15, 7, 3, 3, Color.Red, false);
                    units.Add(warrior);
                }
            }
            foreach(Unit u in units)
            {
                for(int i = 0; i < units.Count; i++)
                {
                    int Xpos = r.Next(0, 20);
                    int Ypos = r.Next(0, 20);

                    while(Xpos == units[i].Posx&&Ypos == units[i].Posy)
                    {
                        Xpos = r.Next(0, 20);
                        Ypos = r.Next(0, 20);
                    }
                    u.Posx = Xpos;
                    u.Posy = Ypos;
                }
            }
            PlaceUnits();
        }
        public void PlaceUnits()
        {
            foreach(Unit u in units)
            {
                Button btn = new Button();
                btn.name = u.ToString();
                btn.size = new Size (30, 30);
                btn.Location = new point(u.Posx * 20, u.Posy * 20);
                btn.Text = u.health.ToString();

                Button.Add(btn);


            }
        }
    }
}
