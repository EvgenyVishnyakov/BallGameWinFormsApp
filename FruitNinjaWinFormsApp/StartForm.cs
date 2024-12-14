using System;
using System.Windows.Forms;

namespace FruitNinjaWinFormsApp
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.ShowDialog();
            this.Hide();
        }
    }
}
