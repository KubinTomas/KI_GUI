using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UJEP_WinformPainting.Classes.PaitingObjects;

namespace UJEP_WinformPainting.Classes.Tools
{
    class RectangleTool: Tool
    {
        public RectangleTool()
        {
            Identifier = this.GetType().Name;
            Name = "Rectangle tool";
            IsEnabled = true;
            PaintingType = typeof(PRectangle);

            Cursor = Cursors.Hand;
        }
    }
}
