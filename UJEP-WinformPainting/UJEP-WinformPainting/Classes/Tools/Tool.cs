using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UJEP_WinformPainting.Classes.Tools
{
    abstract class Tool
    {
        public string Identifier { get; protected set; }
        public string Name { get; protected set; }
        public bool IsEnabled { get; protected set; }
        public Cursor Cursor { get; set; }
    }
}
