using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UJEP_WinformPainting.Classes.ColorCon;
using UJEP_WinformPainting.Classes.PaitingObjects;

namespace UJEP_WinformPainting.Classes.PaintingObjects
{
    class PCircle : PaintingObject
    {
        private readonly Point originalStartPosition;
        public PCircle(Point position, Size size, ColorContainer colorContainer) : base(position, size, colorContainer)
        {
            originalStartPosition = new Point(position.X, position.Y);
        }

        public PCircle() { }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(ColorContainer.Pen, GetRectangle());
        }
        public override void Update(Point currentMousPosition)
        {
            var width = currentMousPosition.X - originalStartPosition.X;
            var height = currentMousPosition.Y - originalStartPosition.Y;

            var posX = originalStartPosition.X;
            var posY = originalStartPosition.Y;

            if (width < 0)
            {
                width = width * (-1);
                posX = originalStartPosition.X - width;
            }

            if (height < 0)
            {
                height = height * (-1);
                posY = originalStartPosition.Y - height;
            }

            Size = new Size(width, height);
            Position = new Point(posX, posY);
        }

        public override PaintingObject GetInstance(Point position, Size size, ColorContainer colorContainer)
        {
            return new PCircle(position, size, colorContainer);
        }

        public override PaintingObject GetInstance(Point position)
        {
            return new PCircle(position, new Size(1, 1), new ColorContainer());
        }

        public override PaintingObject GetInstance(Point position, ColorContainer colorContainer)
        {
            return new PCircle(position, new Size(1, 1), colorContainer);
        }
    }
}
