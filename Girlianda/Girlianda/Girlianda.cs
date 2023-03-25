using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace girlianda
{
    public class Param
    {
        public Image img;
        public Size size;
    }
    public class Yello : Param
    {
        public Yello()
        {
            size = new Size(40, 40);
            img = Image.FromFile("yello.jpg");
        }
    }
    public class Blue : Param
    {
        public Blue()
        {
            size = new Size(40, 40);
            img = Image.FromFile("blue.jpg");
        }
    }
    public class Green : Param
    {
        public Green()
        {
            size = new Size(40, 40);
            img = Image.FromFile("green.jpg");
        }
    }
    public class Girlianda
    {          
        public Point xy;
        public Param p;

        public Girlianda(Point coords, Param ap)
        {
            p = ap;
            xy = coords;
        }
    }
}
