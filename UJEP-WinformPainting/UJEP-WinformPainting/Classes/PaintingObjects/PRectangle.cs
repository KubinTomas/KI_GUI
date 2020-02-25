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
        private readonly Point originalStartPosition;
        public Pen Pen { get; set; }
        public PRectangle(Point position, Size size, Pen pen) : base(position, size)
        {
            Pen = pen;
            originalStartPosition = new Point(position.X, position.Y);
        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pen, GetRectangle());
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
    }
}
