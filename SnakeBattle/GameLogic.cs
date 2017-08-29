using System;
using System.Collections.Generic;

namespace SnakeBattle
{
    /// <summary>
    /// Cast hada, obsahuje souradnice v poli a smer pohybu
    /// </summary>
    struct SnakePart
    {
        public int x, y, direction;

        public SnakePart(int x, int y, int direction)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
        }
    }

    /// <summary>
    /// Had sestavajici z SnakePart[]
    /// </summary>

    class Snake
    {
        private int[,] directions = new int[4, 2] { { 0, -1 }, { 1, 0 }, { 0, 1 }, { -1, 0 } };

        public List<SnakePart> body = new List<SnakePart>();
        public int direction;
        private int score = 0;

        public bool isPlayer;
        
        /// <param name="isPlayer">Jedna-li se o hrace (true) nebo pocitac (false)</param>
        /// <param name="headx">Pozice hlavy v poli</param>
        /// <param name="heady">Pozice hlavy v poli</param>
        /// <param name="length">Pocatecni delka hada</param>
        /// <param name="direction">Smer pohybu hlavy hada</param>
        
        public Snake(bool isPlayer, int headx, int heady, int length, int direction)
        {
            this.isPlayer = isPlayer;
            this.direction = direction;

            int nextx = headx;
            int nexty = heady;

            for (int i = 0; i < length; ++i)
                body.Add(
                    new SnakePart(headx - directions[direction - 1, 0] * i,
                                  heady - directions[direction - 1, 1] * i, direction)
                    );
        }

        /// <summary>
        /// Posun hada (tj. vsech casti hada)
        /// Odebrani ocasu a pridani SnakePart na 0 index Snake.body 
        /// a nastaveni smeru jako byl u predchozi casti
        /// Pri grow true se neodebira ocas
        /// </summary>
        /// <param name="isGrow">Narazil-li had na jidlo</param>
        public void Move(bool isGrow)
        {
            if (!isGrow)
            {
                body.RemoveAt(body.Count - 1);

                SnakePart sp = body[body.Count - 1];
                sp.direction = body[body.Count - 2].direction;
                body[body.Count - 1] = sp;
            }
            else score += 15;
            SnakePart next = NextHeadPosition(body[0],direction);
            body.Insert(0, next);
        }

        public SnakePart NextHeadPosition(SnakePart head, int direction)
        {
            SnakePart next = head;
            next.x += directions[direction - 1, 0];
            next.y += directions[direction - 1, 1];
            next.direction = direction;

            return next;
        }

        public int GetScore() { return score; }
    }

    /// <summary>
    /// Jidlo, obsahuje souradnice na hraci plose a typ
    /// </summary>
    struct Food
    {
        public int x, y, type;

        public Food(int x, int y, int type)
        {
            this.x = x;
            this.y = y;
            this.type = type;
        }
    }

    /// <summary>
    /// Hlavni herni komponenta, obsahuje dva hady a ruzne druhy jidla
    /// </summary>
    class Board
    {
        public const int UP = 1, RIGHT = 2, DOWN = 3, LEFT = 4;
        public const int FOODNUM = 2;

        public int[,] field;
        public Snake snake1, snake2;
        public int width, height;
        public List<Food> foodArray = new List<Food>();
        private Random rnd = new Random();

        /// <summary>
        /// Inicializace plochy
        /// Prazdna policka jsou ohodnocena 0
        /// </summary>

        public Board(int width, int height)
        {
            this.width = width;
            this.height = height;
            field = new int[width, height];

            for (int j = 0; j < height; ++j)
                for (int i = 0; i < width; ++i)
                    field[i, j] = 0;
        }

        /// <summary>
        /// Inicializace herni plochy
        /// Pridani hadu a jidla
        /// </summary>
        /// <param name="isSnake1Player">Hrac (true) nebo pocitac (false)</param>
        /// <param name="isSnake2Player">Hrac (true) nebo pocitac (false)</param>
        /// <param name="difficulty">Hloubka prohledavani (SnakeAIMove),
        /// v pripade hry dvou hracu je defaultne 0 </param>

        public void AddSnake(ref Snake s, bool isPlayer, int headx, int heady, int direction)
        {
            s = new Snake(isPlayer, headx, heady, 3, direction);
            foreach (SnakePart sp in s.body)
                field[sp.x, sp.y] = 1;
        }

        /// <summary>
        /// Pri prekroceni width/height pole se nastavi spravna hodnota
        /// </summary>
        /// <param name="sp">Cast tela hada</param>
        
        public SnakePart FixBoardPosition(SnakePart sp)
        {
            if (sp.x < 0) sp.x = width - 1;
            else if (sp.x > width - 1) sp.x = 0;
            else if (sp.y < 0) sp.y = height - 1;
            else if (sp.y > height - 1) sp.y = 0;

            return sp;
        }

        /// <summary>
        /// Nahodne vytvoreni jidla
        /// Vyuziva se Random
        /// </summary>
        /// <returns>Vytvorene jidlo</returns>

        public Food CreateFood()
        {
            Food f;
            int x = rnd.Next(0, width - 1);
            int y = rnd.Next(0, height - 1);
            int type = rnd.Next(1, 5);

            while (field[x, y] != 0)
            {
                x = rnd.Next(0, width);
                y = rnd.Next(0, height);
            }

            f = new Food(x, y, type);

            field[x, y] = FOODNUM;

            return f;
        }
    }

    /// <summary>
    /// Zakladni herni logika, pohyb hada,
    /// kontrola prekroceni hranic pole (a nasledne Volani FixBoardPosition), 
    /// generovani noveho jidla, vyber smeru hada AI
    /// </summary>

    class GameLogic
    {
        public Board board;
        public int difficulty;

        public GameLogic(int widthBoard, int heightBoard)
        {
            board = new Board(widthBoard, heightBoard);
        }

        public void InitBoard(bool isSnake1Player, bool isSnake2Player, int difficulty)
        {
            this.difficulty = difficulty;

            board.AddSnake(ref board.snake1, isSnake1Player, 3, 1, Board.RIGHT);
            board.AddSnake(ref board.snake2, isSnake2Player,
                           board.width - 4, board.height - 2, Board.LEFT);

            for (int i = 0; i < 5; ++i)
                board.foodArray.Add(board.CreateFood());

            foreach (Food f in board.foodArray)
                board.field[f.x, f.y] = Board.FOODNUM;
        }

        /// <summary>
        /// Posun hadu a vyhodnoceni vyhry/prohry
        /// </summary>
        /// <returns>0 - nikdo neprohral, 1 - hrac1 prohral, 2 - hrac2 prohral</returns>

        public int MoveAndUpdate()
        {
            bool isGameOver1 = MoveSnake(ref board.snake1);
            bool isGameOver2 = MoveSnake(ref board.snake2);

            if (isGameOver1) return 1;
            else if (isGameOver2) return 2;
            else return 0;
        }

        /// <summary>
        /// Pohyb hada o jedno policko ve smeru hada
        /// Rozdeleni na pripady dle hodnoty policka
        /// (0 - prazdne, 1 - obsazene jednim z hadu, FOODNUM - jidlo)
        /// V pripade narazu na jidlo, prodlouzeni hada a pridani noveho jidla
        /// </summary>
        /// <param name="s">Had, ktery se ma posunout</param>
        /// <returns>False pokud narazil</returns>

        public bool MoveSnake(ref Snake s)
        {
            if (!s.isPlayer) SnakeAIMove(ref s, s.body[0], difficulty);

            SnakePart head = s.body[0];
            SnakePart tail = s.body[s.body.Count - 1];

            SnakePart nextHeadPos = board.FixBoardPosition(s.NextHeadPosition(s.body[0],s.direction));

            board.field[tail.x, tail.y] = 0;

            switch (board.field[nextHeadPos.x, nextHeadPos.y])
            {
                case 0:
                    board.field[nextHeadPos.x, nextHeadPos.y] = 1;
                    s.Move(false);
                    break;
                case 1:
                    return true;
                case Board.FOODNUM:
                    board.field[nextHeadPos.x, nextHeadPos.y] = 1;
                    board.field[tail.x, tail.y] = 1;
                    s.Move(true);
                    foreach (Food f in board.foodArray)
                        if ((f.x == nextHeadPos.x) && (f.y == nextHeadPos.y))
                        {
                            board.foodArray.Remove(f);
                            break;
                        }
                    board.foodArray.Add(board.CreateFood());
                    break;
            }

            s.body[0] = board.FixBoardPosition(s.body[0]);

            return false;
        }

        /// <summary>
        /// Zvoleni nejlepsiho smeru hada
        /// Vyber probiha rekurzivnim prohledanim do hloubky 
        /// vsech moznych smeru hada a naslednym ohodnocenim 
        /// a vyberem nejlepsiho mozneho smeru. 
        /// V pripade narazu na cast tela je prohledavani 
        /// dane vetve preruseno a je vracena dosavadni hodnota
        /// </summary>
        /// <param name="s">Had</param>
        /// <param name="head">Hlava hada</param>
        /// <param name="depth">Hloubka prohledavani</param>
        /// <returns>Predavani parametru v ramci rekurze</returns>

        private int SnakeAIMove(ref Snake s, SnakePart head, int depth)
        {
            int bestDir = s.direction;
            int bestVal = int.MinValue;
            int val;
            
            for (int i = 0; i < 4; ++i)
            {
                val = 0;

                SnakePart next = board.FixBoardPosition(s.NextHeadPosition(head,i+1));

                int fieldVal = board.field[next.x, next.y];

                if (fieldVal == Board.FOODNUM) val = 10;
                else if (fieldVal == 0) val = 0;
                else val = -10;

                if ((i + 1) == head.direction) val += 1;
                else if ((i + 1) % 2 == head.direction % 2) val = -10;

                if (depth > 0 && fieldVal != 1)
                    val += SnakeAIMove(ref s, next, depth - 1);

                if (bestVal < val)
                {
                    bestVal = val;
                    bestDir = i + 1;
                }
            }

            s.direction = bestDir;
            return bestVal;
        }
    }

}
