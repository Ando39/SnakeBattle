using System;
using System.Windows.Forms;

namespace SnakeBattle
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            this.Cursor = new Cursor("images/greenCursor.cur");
            background.Controls.Add(titleLabel);
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Spusteni noveho formu s predanim parametru type

        private void playButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Button b = sender as Button;
            int type = 0;
            switch (b.Name)
            {
                case "playPVP": type = GameForm.PVP; break;
                case "playPVC": type = GameForm.PVC; break;
                case "playCVC": type = GameForm.CVC; break;
            }
            new GameForm(type).Show();
        }

        //Zobrazeni informace o hre bez spusteni noveho formu

        private void howtoButton_Click(object sender, EventArgs e)
        {
            howToBox.Show();
            howToBox.BringToFront();
            backButton.Show();
            backButton.BringToFront();
            backButton.Focus();
        }

        //Skryti informace o hre

        private void backButton_Click(object sender, EventArgs e)
        {
            backButton.Hide();
            howToBox.Hide();
            howToBox.SendToBack();
            howtoButton.Focus();
        }

        private void closeGame(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
