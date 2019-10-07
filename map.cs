using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memo
{
   [Serializable] class Map
    {
        List<Unit> units = new List<Unit>();
        Random r = new Random();
        int numUnits = 0;
        Textbox txtInfo;
        FactoryBuilding fb;

        public List<Unit> Units
        {
            get { return Units; }
            set { Units = value; }
        }
        public Map(int n, Textbox txtInfo)
        {
            txtInfo = txtInfo;
            numUnits = n;
        }
        public void Generate()
        {
            for (int i = 0; i < numUnits; i++)
            {
                if (r.Next(0, 2) == 0)
                {
                    Melee m = new Melee(r.Next((0, 20), r.Next(0, 20), 100, 1, 20, (i % 2 == 0 ? 1 : 0), "M"),
                    units.Add(m));
                }
                else
                {
                    Range r = new Range(r.Next((0, 20), r.Next(0, 20), 100, 1, 20, (i % 2 == 0 ? 1 : 0), "M"),
                    units.Add(r));
                }

            }

        }
        public void Display()
        {
            groupBox.Controls.Clear();
            foreach (Unit u in units)
            {

                Melee mu = (Melee)u;
                Button b = new Button();
                b.Width = 40;
                b.Height = 40;
                b.Location = new Point(mu.Xpos * 40, mu.Ypos * 40);
                b.Text = mu.Symbol;
                if (mu.Faction == 0)
                {
                    b.ForeColor = Color.Red;
                }
                else
                {
                    b.ForeColor = Color.Green;
                }
            }

            
             else
{
                Range ru = (Melee)f;
                Button b = new Button();
                b.Width = 40;
                b.Height = 40;
                b.Location = new Point(ru.Xpos * 40, ru.Ypos * 40);
                b.Text = ru.Symbol;
                if (ru.Faction == 0)
                {
                    b.ForeColor = Color.Red;
                }
                else
                {
                    b.ForeColor = Color.Green;
                }

            }
            b.Click += Unit_Click;
            groupbox.Controls.Add(b);

        }

        internal static object Add(resourcetype f, t)
        {
            throw new NotImplementedException();
        }

        public void Unit_Click(Object sender, EventArgs e)
        {
            int x, y;
            Button b = (Button)sender;
            x = b.Location.X / 20;
            y = b.Location.Y / 20;
            foreach (Unit u in units)
            {
                if (u is Range)
                {
                    Range ru = (Range)u;
                    if (ru.Xpos == x && ru.Ypos == y)
                    {
                        txtInfo.Text = "";
                        txtInfo.Text = ru.ToString();
                    }
                }
                else if (u is Melee)
                {
                    Melee mu = (Melee)u;
                    if (mu.Xpos == x && mu.Ypos == y)
                    {
                        txtInfo.Text = "";
                        txtInfo.Text = mu.ToString();
                    }
                }


            }

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
        public void GenerateUnit()
        {
            for (int i = 0; i < Units; i++)
            {
                if (r.Next(0, 2) == 0)
                {
                    unitType m = new unitType(r.Next((0, 20), r.Next(0, 20), 100, 1, 20, (i % 2 == 0 ? 1 : 0), "M"),
                    map.Add(m));
                }
                else
                {
                    unitType r = new unitType(r.Next((0, 20), r.Next(0, 20), 100, 1, 20, (i % 2 == 0 ? 1 : 0), "M"),
                    map.Add(r));
                }

            }
        }
        public void GenerateBuildings()
        {
            groupBox.Controls.Clear();
            foreach (Unit u in units)
            {

                FactoryBuilding fb = (FactoryBuilding)fb;
                Button b = new Button();
                b.Width = 40;
                b.Height = 40;
                b.Location = new Point(fb.Xpos * 40, fb.Ypos * 40);
                b.Text = fb.Symbol;
                if (fb.Faction == 0)
                {
                    b.ForeColor = Color.Blue;
                }
                else
                {
                    b.ForeColor = Color.Yellow;
                }
            }
            
             else
{
                ResourceBuilding rb = (ResourceBuilding)rb;
                Button b = new Button();
                b.Width = 40;
                b.Height = 40;
                b.Location = new Point(rb.Xpos * 40, rb.Ypos * 40);
                b.Text = rb.Symbol;
                if (rb.Faction == 0)
                {
                    b.ForeColor = Color.Blue;
                }
                else
                {
                    b.ForeColor = Color.Yellow;
                }

            }
            b.Click += Unit_Click;
            groupbox.Controls.Add(b);

        }
    }
    public void Generate(Object sender, EventArgs e)
    {
        int x, y;
        Button b = (Button)sender;
        x = b.Location.X / 20;
        y = b.Location.Y / 20;
        foreach (ResourceBuilding in b)
        {
            if (rb is ResourceBuilding)
            {
                ResourceBuilding rb = (Range)rb;
                if (rb.Xpos == x && rb.Ypos == y)
                {
                    txtInfo.Text = ;
                    txtInfo.Text = rb.ToString();
                }
            }
            else if (b is FactoryBuilding)
            {
                FactoryBuilding fb = (Melee)fb;
                if (fb.Xpos == x && fb.Ypos == y)
                {
                    txtInfo.Text = "%";
                    txtInfo.Text = fb.ToString();
                }
            }


        }

    }
}

