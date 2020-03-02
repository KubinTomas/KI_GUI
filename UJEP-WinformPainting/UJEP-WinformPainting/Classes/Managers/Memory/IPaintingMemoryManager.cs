using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UJEP_WinformPainting.Classes.PaitingObjects;

namespace UJEP_WinformPainting.Classes.Managers.Memory
{
    public interface IPaintingMemoryManager
    {
        void Add(PaintingObject paintingObject);
        void Remove(PaintingObject paintingObject);
        void Update(PaintingObject paintingObject);
        void Remove(int id);
        PaintingObject Get(int id);
        void Draw(Graphics graphics);
    }
}
