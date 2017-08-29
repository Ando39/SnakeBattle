using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeBattle
{
    public partial class GameForm : Form
    {
        public const int PVP = 1, PVC = 2, CVC = 3;
        const int SQUARESIZE = 25;
        const string SNAKE1COLOR = "Green", SNAKE2COLOR = "Purple";
        int type, defaultTick;
        int width, height;
        int snake1Dir, snake2Dir;
        bool isDirectionChange1 = false;
        bool isDirectionChange2 = false;

        private GameLogic game;

        /// <summary>
        ///Vytvoreni instance herni logiky dle typu hry
        ///Nastaveni designu horniho herniho panelu (pole info)
        /// </summary>
        /// <param name="type">Parametr type urcuje typ hry (PVP/PVC/CVC)</param>

        public GameForm(int type)
        {
            InitializeComponent();

            this.type = type;
            defaultTick = timer1.Interval;

            this.Cursor = new Cursor("images/greenCursor.cur");

            Label[] info = new Label[] { scoreLabel1, scoreLabel2, lengthLabel1, lengthLabel2,
                                         score1, score2, length1, length2};
            foreach (Label l in info)
                infoPanel.Controls.Add(l);

            if (type == CVC) timer1.Interval = 150;

            width = grass.Width;
            height = grass.Height;

            game = new GameLogic(width / SQUARESIZE, height / SQUARESIZE);

            switch (type)
            {
                case PVP: game.InitBoard(true, true, 0); break;
                case PVC: game.InitBoard(true, false, 3); break;
                case CVC: game.InitBoard(false, false, 8); break;
            }

            snake1Dir = game.board.snake1.direction;
            snake2Dir = game.board.snake2.direction;

            DrawBoard();
        }

        /// <summary>
        /// Vykresleni hernich komponent
        /// </summary>
        private void DrawBoard()
        {
            DrawFood();
            DrawSnake(game.board.snake1, SNAKE1COLOR);
            DrawSnake(game.board.snake2, SNAKE2COLOR);
            grass.Controls.Add(pressKey);
            pressKey.BringToFront();

            length1.Text = game.board.snake1.body.Count + "";
            length2.Text = game.board.snake2.body.Count + "";

            score1.Text = game.board.snake1.GetScore() + "";
            score2.Text = game.board.snake2.GetScore() + "";
        }

        private void DrawFood()
        {
            for (int i = 0; i < game.board.foodArray.Count; ++i)
            {
                Food f = game.board.foodArray[i];
                PictureBox pb = MakePictureBox("food" + f.x + "," + f.y, SQUARESIZE, f.x, f.y);
                pb.Image = Image.FromFile("images/food/food_" + f.type + ".png");
            }
        }

        /// <summary>
        /// Vyber slozky dle barvy hada a nasledne vykresleni jeho casti
        /// Nazev obrazku je vybran dle parametru SnakePart.direction 
        /// aktualni a predchozi Snakepart 
        /// </summary>
        /// <param name="s">Had, ktery se ma vykreslit</param>
        /// <param name="color">Barva hada</param>
        private void DrawSnake(Snake s, string color)
        {
            string[] directions = new string[4] { "up", "right", "down", "left" };
            for (int i = 0; i < s.body.Count; ++i)
            {
                SnakePart sp = s.body[i];
                PictureBox pb = MakePictureBox("snake" + sp.x + "," + sp.y, SQUARESIZE, sp.x, sp.y);
                string pictPath = "images/body/" + color + "/";

                if (i == 0 || i == s.body.Count - 1)
                {
                    if (i == 0) pictPath += "head_";
                    else pictPath += "tail_";
                    pictPath += directions[sp.direction - 1];
                }
                else
                {
                    pictPath += "body_";
                    SnakePart prev = s.body[i - 1];
                    int spdir = sp.direction;
                    int prevdir = prev.direction;

                    if (spdir == prevdir)
                        pictPath += directions[(spdir - 1) % 2];
                    else
                        pictPath += directions[spdir - 1] + "_" + directions[prevdir - 1];
                }

                pb.Image = Image.FromFile(pictPath + ".png");
            }
        }

        /// <summary>
        /// Vytvoreni obrazku o velikosti GameForm.squareSize 
        /// s pruhlednym pozadim
        /// </summary>
        /// <param name="name">Nazev PictureBoxu</param>
        /// <param name="squareSize">Velikost obrazku</param>
        /// <param name="x">Pozice vytoreni</param>
        /// <param name="y">Pozice vytoreni</param>
        /// <returns>Vytoreny PictureBox</returns>

        private PictureBox MakePictureBox(string name, int squareSize, int x, int y)
        {
            PictureBox pb = new PictureBox();
            pb.Name = name;
            pb.Size = new Size(squareSize, squareSize);
            pb.Location = new Point(squareSize * x, squareSize * y);

            grass.Controls.Add(pb);
            pb.BackColor = Color.Transparent;
            pb.BringToFront();

            return pb;
        }

        /// <summary>
        /// Q - pauza, sipky - hrac 1, WDSA - hrac 2
        /// isDirectionChange - pri stisknuti tlacitka smeru jiz nelze
        /// zmenit smer, dokud se neprevede pohyb (tj. timer.Tick),
        /// navic je pak mozne ovladat oba hady soucasne
        /// </summary>

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys)'Q')
            {
                timer1.Enabled = !timer1.Enabled;
                pressKey.Visible = !pressKey.Visible;
            }

            if (type == PVP || type == PVC)
            {
                if (!isDirectionChange1)
                {

                    int dir = game.board.snake1.direction;

                    if (e.KeyCode == Keys.Up && dir != Board.DOWN) dir = Board.UP;
                    else if (e.KeyCode == Keys.Right && dir != Board.LEFT) dir = Board.RIGHT;
                    else if (e.KeyCode == Keys.Down && dir != Board.UP) dir = Board.DOWN;
                    else if (e.KeyCode == Keys.Left && dir != Board.RIGHT) dir = Board.LEFT;

                    if (game.board.snake1.direction != dir) isDirectionChange1 = true;
                    game.board.snake1.direction = dir;
                }

                if (type == PVP && !isDirectionChange2)
                {
                    int dir2 = game.board.snake2.direction;

                    if (e.KeyCode == (Keys)'W' && dir2 != Board.DOWN) dir2 = Board.UP;
                    else if (e.KeyCode == (Keys)'D' && dir2 != Board.LEFT) dir2 = Board.RIGHT;
                    else if (e.KeyCode == (Keys)'S' && dir2 != Board.UP) dir2 = Board.DOWN;
                    else if (e.KeyCode == (Keys)'A' && dir2 != Board.RIGHT) dir2 = Board.LEFT;

                    if (game.board.snake2.direction != dir2) isDirectionChange2 = true;

                    game.board.snake2.direction = dir2;

                }
            }
        }

        /// <summary>
        /// Krok hry - posun hadu
        /// game.MoveAndUpdate vraci nenulu pokud jeden z hadu narazil
        /// Pri nenulovem gameOver nastane konec hry a vypise se vitez
        /// </summary>

        private void timer1_Tick(object sender, EventArgs e)
        {
            grass.Controls.Clear();
            
            int gameOver = game.MoveAndUpdate();

            if (gameOver == 0) DrawBoard();
            else
            {
                timer1.Enabled = false;
                if (gameOver == 1) label1.Text = SNAKE2COLOR + " snake won! ";
                if (gameOver == 2) label1.Text = SNAKE1COLOR + " snake won! ";
                gameEnd.Show();
                replay.Focus();
            }

            isDirectionChange1 = false;
            isDirectionChange2 = false;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new MenuForm().Show();
        }

        private void replay_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GameForm(type).Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
