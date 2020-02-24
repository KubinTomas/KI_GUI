using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UJEP_WinformPainting.Forms;

namespace UJEP_WinformPainting
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void preparedPaintingBtn_Click(object sender, EventArgs e)
        {
            //tento formulář nemůžeme rovnou zavřít, protože by se nám pak ukončila celá aplikace, proto se skrývá a později se volá jeho zavření společně s hlavní aplikací
            this.Hide();

            var preparedPainting = new PreparedPainting();
            preparedPainting.Closed += (s, args) => this.Close();
            preparedPainting.Show();
        }
    }
}
