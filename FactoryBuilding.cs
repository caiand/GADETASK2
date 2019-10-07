using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Memo
{
    
   abstract class FactoryBuilding: Building
    {
        Random r = new Random();
       public int unitType;
       public int productSpeed;
       public int spawnpoint;


        private int Unit;

        public int Units
        {
            get { return Unit; }
            set { Unit = value; }
        }
        public int ProductSpeed
        {
            get { return productSpeed; }
            set { productSpeed = value; }
        }
        public int SpawnPoint
        {
            get { return SpawnPoint; }
            set { SpawnPoint = value; }
        }
        public float spawntime = 3;
        public float delay = 2;
        public Unit[] Melee;
        public Unit[] Range;
        public void Spawn(int spawn,int delay,int melee,int range)
        {
            int unit = melee, Range;
            int Delay = unit;
            int Spawn = Units;
  
        }
        public void GenerateResource()
        {
            for (int i = 0; i < unitType; i++)
            {
                if (r.Next(0, 2) == 0)
                {
                    unitType t = new unitType(r.Next((0, 20), r.Next(0, 20), 100, 1, 20, (i % 2 == 0 ? 1 : 0), "M"),
                    map.Add(t));
                }
                else
                {
                    unitType f = new unitType(r.Next((0, 20), r.Next(0, 20), 100, 1, 20, (i % 2 == 0 ? 1 : 0), "M"),
                    map.Add(f));
                }

            }

        }
}
