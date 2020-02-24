using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UJEP_WinformPainting.Classes.PaitingObjects
{
    class PRectangle : PaintingObject
    {
        public Pen Pen { get; set; }
        public PRectangle(Point position, Size size, Pen pen) : base(position, size)
        {
            Pen = pen;
        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pen, GetRectangle());
        }
    }
}
