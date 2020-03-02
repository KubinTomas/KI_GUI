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
        public bool IsBeingCreated { get; set; }

        public PaintingObject(Point position, Size size, ColorContainer colorContainer) : this()
        {
            Position = position;
            Size = size;
            Id = UniqueId;
            ColorContainer = colorContainer;
        }

        public PaintingObject()
        {
            IsBeingCreated = true;
        }

        public PaintingObject(ColorContainer colorContainer) : this()
        {
            ColorContainer = colorContainer;
        }

        public abstract PaintingObject GetInstance(Point position, Size size, ColorContainer colorContainer);

        public abstract PaintingObject GetInstance(Point position);

        public abstract PaintingObject GetInstance(Point position, ColorContainer colorContainer);

        public bool Intresect(Point mousePosition)
        {
            return Position.X <= mousePosition.X && mousePosition.X <= Position.X + Size.Width
                && Position.Y <= mousePosition.Y && mousePosition.Y <= Position.Y + Size.Height;
        }

        public abstract void Update(Point currentMousePosition);

        public void UpdatePosition(Point positionMove)
        {
            Position = new Point(Position.X + positionMove.X, Position.Y + positionMove.Y);
        }

        public Rectangle GetRectangle()
        {
            return new Rectangle(Position.X, Position.Y, Size.Width, Size.Height);
        }

        public int GetDistance(Point p1, Point p2)
        {
            throw new NotImplementedException();
        }

        public abstract void Draw(Graphics g);

        public void DrawSelection(Graphics g)
        {
            g.DrawRectangle(Pens.Blue, GetRectangle());
        }

    }
}
