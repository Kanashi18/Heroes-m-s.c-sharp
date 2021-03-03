using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.Resources
{
    class Point
    {
        private int x;
        private int y;
        public void setx(int tmp) {x = tmp; }
        public void sety(int tmp) { y = tmp; }

    }
    public class Charter
    {
        public string name = null;
        public int attack = 0;
        public int defense = 0;
        public int damage = 0;
        public int hp = 0;
        public int speed = 0;
        public Image charterImage = null;
        public void setSettings(string nm, int at, int def, int dam, int HP, int sp,Image img)
        {
            name = nm;
            attack = at;
            defense = def;
            damage = dam;
            hp = HP;
            speed = sp;
            charterImage = img;
        }
        
    }
}
