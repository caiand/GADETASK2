using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Memo
  
{
   abstract class ResourceBuilding: Building
    {
       public string resourcetype;
       public int resourcegen;
       public int resourcegenperround;
       public int resourceremain;
        Random r = new Random();
        private int resource;

        public int Resourcetype
        {
            get { return Resourcetype; }
            set { Resourcetype = value; }
        }
        public int ResourceGen
        {
            get { return ResourceGen; }
            set { ResourceGen = value; }
        }
        public int ResourceRound
        {
            get { return ResourceRound; }
            set { ResourceRound = value; }
        }
        public int ResourceRemain
        {
            get { return ResourceRemain; }
            set { ResourceRemain = value; }


            
        }
        public void GenerateResource()
        {
            for (int i = 0; i < resourcegen; i++)
            {
                if (r.Next(0, 2) == 0)
                {
                    resourcetype t = new resourcetype(r.Next((0, 20), r.Next(0, 20), 100, 1, 20, (i % 2 == 0 ? 1 : 0), "M"),
                    map.Add(t));
                }
                else
                {
                    resourcetype f = new resourcetype(r.Next((0, 20), r.Next(0, 20), 100, 1, 20, (i % 2 == 0 ? 1 : 0), "M"),
                    map.Add(f));
                }

            }

        }
    }
}
