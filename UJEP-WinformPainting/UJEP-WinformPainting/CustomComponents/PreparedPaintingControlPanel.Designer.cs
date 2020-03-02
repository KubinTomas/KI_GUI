namespace UJEP_WinformPainting.CustomComponents
{
    partial class PreparedPaintingControlPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreparedPaintingControlPanel));
            this.toolGroupBox = new System.Windows.Forms.GroupBox();
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.colorBlackBtn = new System.Windows.Forms.Button();
            this.colorGreenBtn = new System.Windows.Forms.Button();
            this.colorRedBtn = new System.Windows.Forms.Button();
            this.currentSelectedColorBtn = new System.Windows.Forms.Button();
            this.circleBtn = new System.Windows.Forms.Button();
            this.rectangleBtn = new System.Windows.Forms.Button();
            this.penBtn = new System.Windows.Forms.Button();
            this.flatBtn = new UJEP_WinformPainting.CustomComponents.Buttons.FlatButton();
            this.toolGroupBox.SuspendLayout();
            this.colorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolGroupBox
            // 
            this.toolGroupBox.Controls.Add(this.circleBtn);
            this.toolGroupBox.Controls.Add(this.rectangleBtn);
            this.toolGroupBox.Controls.Add(this.penBtn);
            this.toolGroupBox.Location = new System.Drawing.Point(3, 3);
            this.toolGroupBox.Name = "toolGroupBox";
            this.toolGroupBox.Size = new System.Drawing.Size(351, 114);
            this.toolGroupBox.TabIndex = 0;
            this.toolGroupBox.TabStop = false;
            this.toolGroupBox.Text = "Tools";
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.currentSelectedColorBtn);
            this.colorGroupBox.Controls.Add(this.colorRedBtn);
            this.colorGroupBox.Controls.Add(this.colorGreenBtn);
            this.colorGroupBox.Controls.Add(this.colorBlackBtn);
            this.colorGroupBox.Location = new System.Drawing.Point(361, 4);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(213, 113);
            this.colorGroupBox.TabIndex = 1;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Colors";
            // 
            // colorBlackBtn
            // 
            this.colorBlackBtn.BackColor = System.Drawing.Color.Black;
            this.colorBlackBtn.Location = new System.Drawing.Point(7, 20);
            this.colorBlackBtn.Name = "colorBlackBtn";
            this.colorBlackBtn.Size = new System.Drawing.Size(25, 25);
            this.colorBlackBtn.TabIndex = 0;
            this.colorBlackBtn.UseVisualStyleBackColor = false;
            // 
            // colorGreenBtn
            // 
            this.colorGreenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.colorGreenBtn.Location = new System.Drawing.Point(38, 20);
            this.colorGreenBtn.Name = "colorGreenBtn";
            this.colorGreenBtn.Size = new System.Drawing.Size(25, 25);
            this.colorGreenBtn.TabIndex = 1;
            this.colorGreenBtn.UseVisualStyleBackColor = false;
            // 
            // colorRedBtn
            // 
            this.colorRedBtn.BackColor = System.Drawing.Color.Red;
            this.colorRedBtn.Location = new System.Drawing.Point(69, 20);
            this.colorRedBtn.Name = "colorRedBtn";
            this.colorRedBtn.Size = new System.Drawing.Size(25, 25);
            this.colorRedBtn.TabIndex = 2;
            this.colorRedBtn.UseVisualStyleBackColor = false;
            // 
            // currentSelectedColorBtn
            // 
            this.currentSelectedColorBtn.BackColor = System.Drawing.Color.Black;
            this.currentSelectedColorBtn.Location = new System.Drawing.Point(195, 15);
            this.currentSelectedColorBtn.Name = "currentSelectedColorBtn";
            this.currentSelectedColorBtn.Size = new System.Drawing.Size(12, 88);
            this.currentSelectedColorBtn.TabIndex = 3;
            this.currentSelectedColorBtn.UseVisualStyleBackColor = false;
            // 
            // circleBtn
            // 
            this.circleBtn.Image = global::UJEP_WinformPainting.Properties.Resources.circleCursor1;
            this.circleBtn.Location = new System.Drawing.Point(118, 35);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(50, 50);
            this.circleBtn.TabIndex = 2;
            this.circleBtn.UseVisualStyleBackColor = true;
            this.circleBtn.Click += new System.EventHandler(this.circleBtn_Click);
            // 
            // rectangleBtn
            // 
            this.rectangleBtn.Image = global::UJEP_WinformPainting.Properties.Resources.rectangleV4;
            this.rectangleBtn.Location = new System.Drawing.Point(62, 35);
            this.rectangleBtn.Name = "rectangleBtn";
            this.rectangleBtn.Size = new System.Drawing.Size(50, 50);
            this.rectangleBtn.TabIndex = 1;
            this.rectangleBtn.UseVisualStyleBackColor = true;
            this.rectangleBtn.Click += new System.EventHandler(this.rectangleBtn_Click);
            // 
            // penBtn
            // 
            this.penBtn.Image = ((System.Drawing.Image)(resources.GetObject("penBtn.Image")));
            this.penBtn.Location = new System.Drawing.Point(6, 35);
            this.penBtn.Name = "penBtn";
            this.penBtn.Size = new System.Drawing.Size(50, 50);
            this.penBtn.TabIndex = 0;
            this.penBtn.UseVisualStyleBackColor = true;
            this.penBtn.Click += new System.EventHandler(this.penBtn_Click);
            // 
            // flatBtn
            // 
            this.flatBtn.BorderThickness = 2F;
            this.flatBtn.Location = new System.Drawing.Point(1006, 19);
            this.flatBtn.Name = "flatBtn";
            this.flatBtn.Size = new System.Drawing.Size(127, 23);
            this.flatBtn.TabIndex = 2;
            this.flatBtn.Text = "I am custon Flat";
            // 
            // PreparedPaintingControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.flatBtn);
            this.Controls.Add(this.colorGroupBox);
            this.Controls.Add(this.toolGroupBox);
            this.Name = "PreparedPaintingControlPanel";
            this.Size = new System.Drawing.Size(1150, 120);
            this.toolGroupBox.ResumeLayout(false);
            this.colorGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox toolGroupBox;
        private System.Windows.Forms.Button penBtn;
        private System.Windows.Forms.Button rectangleBtn;
        private System.Windows.Forms.Button circleBtn;
        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.Button colorRedBtn;
        private System.Windows.Forms.Button colorGreenBtn;
        private System.Windows.Forms.Button colorBlackBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button currentSelectedColorBtn;
        private Buttons.FlatButton flatBtn;
    }
}
