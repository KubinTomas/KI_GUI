using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UJEP_WinformPainting.Classes.Managers.Memory;
using UJEP_WinformPainting.Classes.PaitingObjects;

namespace UJEP_WinformPainting.Classes
{
    class PaintingMemoryManager: IPaintingMemory
    {
        private List<PaintingObject> paintingObjects;

        public PaintingMemoryManager()
        {
            paintingObjects = new List<PaintingObject>();
        }

        public void Add(PaintingObject paintingObject)
        {
            paintingObjects.Add(paintingObject);
        }

        public void Draw(Graphics graphics)
        {
            paintingObjects.ForEach(o =>
            {
                o.Draw(graphics);
            });
        }

        public PaintingObject Get(int id)
        {
            return paintingObjects.SingleOrDefault(c => c.Id == id);
        }

        public void Remove(PaintingObject paintingObject)
        {
            paintingObjects.Remove(paintingObject);
        }

        public void Remove(int id)
        {
            var paintingObject = Get(id);

            if (paintingObject != null) Remove(paintingObject);
        }

        public void Update(PaintingObject paintingObject)
        {
            throw new NotImplementedException();
        }
    }
}
