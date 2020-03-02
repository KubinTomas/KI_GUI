using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UJEP_WinformPainting.Classes.ColorCon;

namespace UJEP_WinformPainting.Classes.PaitingObjects
{
    public abstract class PaintingObject
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
        public ColorContainer ColorContainer { get; set; }
        public Point Position { get; set; }
        public Size Size { get; set; }

        public PaintingObject(Point position, Size size, ColorContainer colorContainer)
        {
            Position = position;
            Size = size;
            Id = UniqueId;
            ColorContainer = colorContainer;
        }

        public PaintingObject() { }

        public PaintingObject(ColorContainer colorContainer) {
            ColorContainer = colorContainer;
        }

        public abstract PaintingObject GetInstance(Point position, Size size, ColorContainer colorContainer);

        public abstract PaintingObject GetInstance(Point position);

        public abstract PaintingObject GetInstance(Point position, ColorContainer colorContainer);


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
