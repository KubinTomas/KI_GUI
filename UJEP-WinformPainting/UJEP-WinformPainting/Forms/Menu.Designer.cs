namespace UJEP_WinformPainting
{
    partial class Menu
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
            this.schoolPaintingBtn = new System.Windows.Forms.Button();
            this.preparedPaintingBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // schoolPaintingBtn
            // 
            this.schoolPaintingBtn.Location = new System.Drawing.Point(88, 154);
            this.schoolPaintingBtn.Name = "schoolPaintingBtn";
            this.schoolPaintingBtn.Size = new System.Drawing.Size(108, 52);
            this.schoolPaintingBtn.TabIndex = 0;
            this.schoolPaintingBtn.Text = "Open school painting";
            this.schoolPaintingBtn.UseVisualStyleBackColor = true;
            // 
            // preparedPaintingBtn
            // 
            this.preparedPaintingBtn.Location = new System.Drawing.Point(88, 84);
            this.preparedPaintingBtn.Name = "preparedPaintingBtn";
            this.preparedPaintingBtn.Size = new System.Drawing.Size(108, 52);
            this.preparedPaintingBtn.TabIndex = 0;
            this.preparedPaintingBtn.Text = "Open prepared  paiting";
            this.preparedPaintingBtn.UseVisualStyleBackColor = true;
            this.preparedPaintingBtn.Click += new System.EventHandler(this.preparedPaintingBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(88, 221);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(108, 52);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.preparedPaintingBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.schoolPaintingBtn);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button schoolPaintingBtn;
        private System.Windows.Forms.Button preparedPaintingBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

