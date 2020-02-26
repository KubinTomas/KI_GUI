using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public PreparedPainting()
        {
            InitializeComponent();

            manager = new MainManager(new PaintingMemoryManager());
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            manager.MemoryManager.Draw(graphics);
        }

        /// <summary>
        /// uvolnime objekt, jiz ho nebudeme sledovat a menit pri pohybu myse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
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

            canvas.Refresh();
        }

        private void canvasRefresherTimer_Tick(object sender, EventArgs e)
        {
            //zajisti prekresleni
            canvas.Refresh();
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            manager.UpdatePreview(e.Location, manager.SelectedObject);

            if (manager.SelectedObject != null)
                canvas.Refresh();
        }
    }
}
