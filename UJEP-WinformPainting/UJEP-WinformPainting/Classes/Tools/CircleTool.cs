using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UJEP_WinformPainting.Classes.PaintingObjects;

namespace UJEP_WinformPainting.Classes.Tools
{
    class CircleTool: Tool
    {
        public CircleTool()
        {
            Identifier = this.GetType().Name;
            Name = "Circle tool";
            IsEnabled = true;
            PaintingObject = new PCircle();
            Cursor = Cursors.Hand;
        }
    }
}
