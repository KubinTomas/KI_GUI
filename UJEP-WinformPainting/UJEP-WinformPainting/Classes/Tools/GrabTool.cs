using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UJEP_WinformPainting.Classes.Tools
{
    class GrabTool: Tool
    {
        public GrabTool()
        {
            Identifier = this.GetType().Name;
            Name = "Grab tool";
            IsEnabled = true;
            PaintingObject = null;

            Cursor = Cursors.Arrow;
        }
    }
}
