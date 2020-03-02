namespace UJEP_WinformPainting.Forms
{
    partial class PreparedPainting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.canvasRefresherTimer = new System.Windows.Forms.Timer(this.components);
            this.preparedPaintingControlPanel = new UJEP_WinformPainting.CustomComponents.PreparedPaintingControlPanel();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.canvas.Location = new System.Drawing.Point(22, 138);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1150, 600);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // canvasRefresherTimer
            // 
            this.canvasRefresherTimer.Tick += new System.EventHandler(this.canvasRefresherTimer_Tick);
            // 
            // preparedPaintingControlPanel
            // 
            this.preparedPaintingControlPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.preparedPaintingControlPanel.Location = new System.Drawing.Point(22, 12);
            this.preparedPaintingControlPanel.Name = "preparedPaintingControlPanel";
            this.preparedPaintingControlPanel.Size = new System.Drawing.Size(1150, 120);
            this.preparedPaintingControlPanel.TabIndex = 1;
            // 
            // PreparedPainting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.preparedPaintingControlPanel);
            this.Controls.Add(this.canvas);
            this.Name = "PreparedPainting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreparedPainting";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Timer canvasRefresherTimer;
        private CustomComponents.PreparedPaintingControlPanel preparedPaintingControlPanel;
    }
}