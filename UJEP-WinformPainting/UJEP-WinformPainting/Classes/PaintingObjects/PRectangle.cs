using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UJEP_WinformPainting.Classes.ColorCon;

namespace UJEP_WinformPainting.Classes.PaitingObjects
{
    class PRectangle : PaintingObject
    {
        private readonly Point originalStartPosition;
        public PRectangle(Point position, Size size, ColorContainer colorContainer) : base(position, size, colorContainer)
        {
            originalStartPosition = new Point(position.X, position.Y);
        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(ColorContainer.Pen, GetRectangle());
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
            return new PRectangle(position, size, colorContainer);
        }
    }
}
