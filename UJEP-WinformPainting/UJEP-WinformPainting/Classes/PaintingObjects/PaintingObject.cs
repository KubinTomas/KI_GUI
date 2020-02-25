using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UJEP_WinformPainting.Classes.PaitingObjects
{
    abstract class PaintingObject
    {
        #region uniqueId 
        public static int UniqueId
        {
            get
            {
                return uniqueId++;
            }
        }

        private static int uniqueId = 1;

        #endregion

        public readonly int Id;
        public Color Color { get; set; }
        public Point Position { get; set; }
        public Size Size { get; set; }

        public PaintingObject(Point position, Size size)
        {
            Position = position;
            Size = size;
            Id = UniqueId;
        }

        public abstract void Update(Point currentMousPosition);

        public Rectangle GetRectangle()
        {
            return new Rectangle(Position.X, Position.Y, Size.Width, Size.Height);
        }

        public int GetDistance(Point p1, Point p2)
        {
            throw new NotImplementedException();
        }

        public abstract void Draw(Graphics g);

    }
}
