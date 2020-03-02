using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UJEP_WinformPainting.Classes.ColorCon
{
    public class ColorContainer
    {
        public Color Color { get; set; }
        public Brush Brush { get; set; }
        public Pen Pen { get; set; }

        public ColorContainer(Brush brush, Pen pen, Color color)
        {
            Brush = brush;
            Color = color;
            Pen = pen;
        }
        public ColorContainer()
        {
            Color = Color.Black;
            Brush = new SolidBrush(Color);
            Pen = new Pen(Color);
        }
   
        public static ColorContainer Default { get { return new ColorContainer(); } }
    }
}
