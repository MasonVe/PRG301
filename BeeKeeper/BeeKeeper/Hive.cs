using System;
using System.Collections.Generic;
using System.Text;

namespace BeeKeeper
{
    public class Hive
    {
        public string name = "";
        public List<Bee> beelist;
        public int maxbees = 4;
        public static int maxhive = 0;
        public float size;

        public Hive()
        {
            //this.name = "";
            this.beelist = new List<Bee>();
        }


        public void AddBee (Bee newbee)
        {
            this.beelist.Add(newbee);
        }


        public void CollectHoney(int days)
        {
            float honey = 0;

            foreach (var bee in beelist)
            {
                honey = honey + days * bee.Size * 0.2f;
            }
            Console.WriteLine("has collected {0} grams of honey!", honey);
        }

    }
}
