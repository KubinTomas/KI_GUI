using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UJEP_WinformPainting.Classes.ColorCon;
using UJEP_WinformPainting.Classes.Managers.LivePreview;
using UJEP_WinformPainting.Classes.Managers.Memory;
using UJEP_WinformPainting.Classes.PaitingObjects;
using UJEP_WinformPainting.Classes.Tools;

namespace UJEP_WinformPainting.Classes.Managers.Main
{
    public class MainManager : ILivePreview
    {
        public readonly IPaintingMemoryManager MemoryManager;
        public Tool SelectedTool { get; set; }
        public PaintingObject SelectedObject { get; set; }
        public ColorContainer SelecedColorContainer { get; private set; }

        public MainManager(IPaintingMemoryManager memoryManager)
        {
            this.MemoryManager = memoryManager;

            this.SelectedTool = Tool.Default;
            this.SelecedColorContainer = ColorContainer.Default;
        }

        public void UpdatePreview(Point currentMousePosition, PaintingObject paintingObject)
        {
            if (paintingObject != null) paintingObject.Update(currentMousePosition);
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

        public void BeginPreview(Point mousePosition)
        {
            if (IsGrabTool()) SetSelectedObject(mousePosition);
            else
                BeginDrawing(mousePosition);

        }
        private void SetSelectedObject(Point mousePosition)
        {
            var selectedObject = MemoryManager.GetObjectOnPosition(mousePosition);
        }

        private void BeginDrawing(Point mousePosition)
        {
            var paintingObject = SelectedTool.PaintingObject.GetInstance(mousePosition, SelecedColorContainer);

            BeginPreview(paintingObject);
        }


        private bool IsGrabTool()
        {
            return SelectedTool is GrabTool;
        }

        public void SetSelectedColor(Color color)
        {
            SelecedColorContainer = new ColorContainer(new SolidBrush(color), new Pen(color, 8), color);
        }
    }
}
