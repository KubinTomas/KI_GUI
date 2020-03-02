using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UJEP_WinformPainting.Classes.Managers.Main;
using UJEP_WinformPainting.Classes.Tools;

namespace UJEP_WinformPainting.CustomComponents
{
    /// <summary>
    /// Pokud nefunguje pridani custom komponenty,
    /// 1) Build - Clean solution - asi staci jen krok 2, obsahuje i clean
    /// 2) Build - Rebuild solution 
    /// </summary>
    public partial class PreparedPaintingControlPanel : UserControl
    {
        private MainManager manager;
        public PreparedPaintingControlPanel()
        {
            InitializeComponent();

            InitPreSelectedDefaultColorsBtn();

        }

        private void InitPreSelectedDefaultColorsBtn()
        {
            colorBlackBtn.Click += new EventHandler(onFastSaveColorBtnClick);
            colorRedBtn.Click += new EventHandler(onFastSaveColorBtnClick);
            colorGreenBtn.Click += new EventHandler(onFastSaveColorBtnClick);
        }

        private void onFastSaveColorBtnClick(object sender, EventArgs e)
        {
            currentSelectedColorBtn.BackColor = ((Button)sender).BackColor;

            manager.SetSelectedColor(((Button)sender).BackColor);
        }

        public void SetManager(MainManager manager)
        {
            this.manager = manager;

            currentSelectedColorBtn.BackColor = manager.SelecedColorContainer.Color;
        }

        private void penBtn_Click(object sender, EventArgs e)
        {

        }

        private void rectangleBtn_Click(object sender, EventArgs e)
        {
            manager.SelectedTool = Tool.Rectanhgle;
        }

        private void circleBtn_Click(object sender, EventArgs e)
        {
            manager.SelectedTool = Tool.Circle;
        }
    }
}
