using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UJEP_WinformPainting.Classes.Tools
{
    class RectangleTool: Tool
    {
        public RectangleTool()
        {
            Identifier = this.GetType().Name;
            Name = "Rectangle tool";
            IsEnabled = true;

            Cursor = Cursors.Hand;
        }
    }
}
