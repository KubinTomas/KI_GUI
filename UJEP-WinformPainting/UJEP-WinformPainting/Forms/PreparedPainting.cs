using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UJEP_WinformPainting.Classes;
using UJEP_WinformPainting.Classes.Managers.Main;
using UJEP_WinformPainting.Classes.PaitingObjects;

namespace UJEP_WinformPainting.Forms
{
    public partial class PreparedPainting : Form
    {
        private MainManager manager;
        private Point prevoiusPressedMousePosition;
        public PreparedPainting()
        {
            InitializeComponent();

            manager = new MainManager(new PaintingMemoryManager());

            this.preparedPaintingControlPanel.SetManager(manager);

           

        }

        /// <summary>
        /// paint neovlivnuje picture box, tudiz image/bg image je null i kdyz to vypada ze kreslime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;


            manager.MemoryManager.Draw(graphics);

            if (manager.SelectedObject != null)
                manager.SelectedObject.DrawSelection(graphics);
        }

        /// <summary>
        /// uvolnime objekt, jiz ho nebudeme sledovat a menit pri pohybu myse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (manager.SelectedObject == null) return;

            manager.EndPreview();

            canvas.Refresh();
        }

        /// <summary>
        /// vytvorime objekt, a nechame ho vykreslit pri pohybu mysi aktualizujeme jeho size na zaklade pozice kde doslo ke kliknuti a aktualni pozice mysi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            manager.BeginPreview(e.Location);
            prevoiusPressedMousePosition = e.Location;

            canvas.Refresh();
        }

        private void canvasRefresherTimer_Tick(object sender, EventArgs e)
        {
            //zajisti prekresleni v loopu
            canvas.Refresh();
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (manager.SelectedObject == null) return;

            if (manager.IsMovingObject()) {
                manager.UpdatePosition(e.Location, prevoiusPressedMousePosition, manager.SelectedObject);

                prevoiusPressedMousePosition = e.Location;
            }
            else
                manager.UpdatePreview(e.Location, manager.SelectedObject);

            if (manager.SelectedObject != null)
                canvas.Refresh();
        }

        /// <summary>
        /// key preview musi byt true ve formulari a jejich properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreparedPainting_KeyDown(object sender, KeyEventArgs e)
        {
            //&& manager.SelectedObject != null
            if (e.KeyCode == Keys.Delete)
            {
                var paintingObjectId = manager.SelectedObject.Id;

                manager.SelectedObject = null;

                manager.MemoryManager.Remove(paintingObjectId);

                this.canvas.Refresh();
            }


            //save image to jpg
            if(e.KeyCode == Keys.S)
            {

                //canvas draw method neovlivnuje bitmapu, musime tedy vytvorit novou a zapsat primo do ni

                canvas.Image = new Bitmap(canvas.Width, canvas.Height);
                var graphics = Graphics.FromImage(canvas.Image);

                //vykreslime byli ctverec jako pozadi bitmapi, jinak by byla cerna
                graphics.FillRectangle(Brushes.White, 0, 0, canvas.Width, canvas.Height);

                //draw our stored objects
                manager.MemoryManager.Draw(graphics);

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.FileName = "image";
                saveDialog.DefaultExt = "jpg";
                saveDialog.Filter = "JPG images (*.jpg)|*.jpg";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileName = saveDialog.FileName;
                    if (!System.IO.Path.HasExtension(fileName) || System.IO.Path.GetExtension(fileName) != "jpg")
                        fileName = fileName + ".jpg";

                    new Bitmap(canvas.Image).Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                    MessageBox.Show("Obrazek ulozen");
                }
            }
        }
    }
}
