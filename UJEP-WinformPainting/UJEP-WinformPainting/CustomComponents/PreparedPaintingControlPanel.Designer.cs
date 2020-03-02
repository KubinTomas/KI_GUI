﻿namespace UJEP_WinformPainting.CustomComponents
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
            this.circleBtn = new System.Windows.Forms.Button();
            this.rectangleBtn = new System.Windows.Forms.Button();
            this.penBtn = new System.Windows.Forms.Button();
            this.toolGroupBox.SuspendLayout();
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
            // PreparedPaintingControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.toolGroupBox);
            this.Name = "PreparedPaintingControlPanel";
            this.Size = new System.Drawing.Size(1150, 120);
            this.toolGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox toolGroupBox;
        private System.Windows.Forms.Button penBtn;
        private System.Windows.Forms.Button rectangleBtn;
        private System.Windows.Forms.Button circleBtn;
    }
}
