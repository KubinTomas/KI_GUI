using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UJEP_WinformPainting.Classes.PaitingObjects;

namespace UJEP_WinformPainting.Classes.Managers.LivePreview
{
    interface ILivePreview
    {
        void UpdatePreview(Point currentMousePosition, PaintingObject paintingObject);

        /// <summary>
        /// nastavi objekt jako vybrany a pridaho do pameti
        /// </summary>
        /// <param name="paintingObject"></param>
        void BeginPreview(PaintingObject paintingObject);
        void EndPreview();
    }
}
