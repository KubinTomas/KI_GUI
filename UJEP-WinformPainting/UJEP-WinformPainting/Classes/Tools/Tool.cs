using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UJEP_WinformPainting.Classes.PaitingObjects;

namespace UJEP_WinformPainting.Classes.Tools
{
    abstract class Tool
    {
        public PaintingObject PaintingObject { get; protected set; }
        public string Identifier { get; protected set; }
        public string Name { get; protected set; }
        public bool IsEnabled { get; protected set; }
        public Cursor Cursor { get; set; }



        public static Tool Default { get { return new RectangleTool(); } }
        public static Tool Rectanhgle { get { return new RectangleTool(); } }
        public static Tool Circle { get { return new CircleTool(); } }
    }
}
