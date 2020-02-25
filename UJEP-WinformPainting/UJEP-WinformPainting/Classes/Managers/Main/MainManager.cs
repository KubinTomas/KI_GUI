﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UJEP_WinformPainting.Classes.Managers.LivePreview;
using UJEP_WinformPainting.Classes.Managers.Memory;
using UJEP_WinformPainting.Classes.PaitingObjects;

namespace UJEP_WinformPainting.Classes.Managers.Main
{
    class MainManager: ILivePreview
    {
        public readonly IPaintingMemoryManager MemoryManager;
        public PaintingObject SelectedObject { get; set; }

        public MainManager(IPaintingMemoryManager memoryManager)
        {
            this.MemoryManager = memoryManager;
        }

        public void UpdatePreview(Point currentMousePosition, PaintingObject paintingObject)
        {
            if(paintingObject != null) paintingObject.Update(currentMousePosition);
        }

        public void BeginPreview(PaintingObject paintingObject)
        {
            MemoryManager.Add(paintingObject);

            SelectedObject = paintingObject;
        }

        public void EndPreview()
        {
            SelectedObject = null;
        }
    }
}