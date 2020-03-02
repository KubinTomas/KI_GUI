using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UJEP_WinformPainting.CustomComponents.Buttons
{
    class FlatButton: Control
    {
        private StringFormat stringFormat;
        private Rectangle borderRectangle;

        private SolidBrush borderBrush;
        private SolidBrush textBrush;

        private bool isActive;

        public override Cursor Cursor { get; set; } = Cursors.Hand;
        public float BorderThickness { get; set; } = 2;


        public FlatButton()
        {
            stringFormat = new StringFormat();
            isActive = false;

            borderBrush = new SolidBrush(Color.Black);
            textBrush = new SolidBrush(Color.White);
            base.BackColor = Color.Red;


            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;


            this.Paint += FlatButton_paint;
        }

        private void FlatButton_paint(object sender, PaintEventArgs e)
        {
            borderRectangle = new Rectangle(0, 0, Width, Height);
            e.Graphics.DrawRectangle(new Pen(borderBrush, BorderThickness), borderRectangle);
            e.Graphics.DrawString(this.Text, this.Font,(isActive) ? textBrush : borderBrush, borderRectangle, stringFormat);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            base.BackColor = Color.Gray;
            isActive = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            base.BackColor = Color.Red;
            isActive = false;
        }

    }
}
