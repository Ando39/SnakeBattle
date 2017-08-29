namespace SnakeBattle
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pressKey = new System.Windows.Forms.Label();
            this.length2 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.scoreLabel2 = new System.Windows.Forms.Label();
            this.lengthLabel2 = new System.Windows.Forms.Label();
            this.length1 = new System.Windows.Forms.Label();
            this.lengthLabel1 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.scoreLabel1 = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.PictureBox();
            this.grass = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameEnd = new System.Windows.Forms.GroupBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.replay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infoPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass)).BeginInit();
            this.gameEnd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // pressKey
            // 
            this.pressKey.AutoSize = true;
            this.pressKey.BackColor = System.Drawing.Color.Transparent;
            this.pressKey.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressKey.ForeColor = System.Drawing.Color.White;
            this.pressKey.Location = new System.Drawing.Point(290, 150);
            this.pressKey.Name = "pressKey";
            this.pressKey.Size = new System.Drawing.Size(266, 26);
            this.pressKey.TabIndex = 22;
            this.pressKey.Text = "Press \'Q\' key to continue...";
            // 
            // length2
            // 
            this.length2.AutoSize = true;
            this.length2.BackColor = System.Drawing.Color.Transparent;
            this.length2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.length2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(65)))), ((int)(((byte)(148)))));
            this.length2.Location = new System.Drawing.Point(764, 5);
            this.length2.Name = "length2";
            this.length2.Size = new System.Drawing.Size(22, 26);
            this.length2.TabIndex = 21;
            this.length2.Text = "3";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.BackColor = System.Drawing.Color.Transparent;
            this.score2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(65)))), ((int)(((byte)(148)))));
            this.score2.Location = new System.Drawing.Point(562, 5);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(46, 26);
            this.score2.TabIndex = 20;
            this.score2.Text = "100";
            // 
            // scoreLabel2
            // 
            this.scoreLabel2.AutoSize = true;
            this.scoreLabel2.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(65)))), ((int)(((byte)(148)))));
            this.scoreLabel2.Location = new System.Drawing.Point(489, 5);
            this.scoreLabel2.Name = "scoreLabel2";
            this.scoreLabel2.Size = new System.Drawing.Size(67, 26);
            this.scoreLabel2.TabIndex = 19;
            this.scoreLabel2.Text = "Score:";
            // 
            // lengthLabel2
            // 
            this.lengthLabel2.AutoSize = true;
            this.lengthLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lengthLabel2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(65)))), ((int)(((byte)(148)))));
            this.lengthLabel2.Location = new System.Drawing.Point(668, 5);
            this.lengthLabel2.Name = "lengthLabel2";
            this.lengthLabel2.Size = new System.Drawing.Size(90, 26);
            this.lengthLabel2.TabIndex = 18;
            this.lengthLabel2.Text = "Length: ";
            // 
            // length1
            // 
            this.length1.AutoSize = true;
            this.length1.BackColor = System.Drawing.Color.Transparent;
            this.length1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.length1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.length1.Location = new System.Drawing.Point(333, 5);
            this.length1.Name = "length1";
            this.length1.Size = new System.Drawing.Size(22, 26);
            this.length1.TabIndex = 17;
            this.length1.Text = "3";
            // 
            // lengthLabel1
            // 
            this.lengthLabel1.AutoSize = true;
            this.lengthLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lengthLabel1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.lengthLabel1.Location = new System.Drawing.Point(237, 5);
            this.lengthLabel1.Name = "lengthLabel1";
            this.lengthLabel1.Size = new System.Drawing.Size(90, 26);
            this.lengthLabel1.TabIndex = 16;
            this.lengthLabel1.Text = "Length: ";
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.BackColor = System.Drawing.Color.Transparent;
            this.score1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.score1.Location = new System.Drawing.Point(128, 5);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(46, 26);
            this.score1.TabIndex = 15;
            this.score1.Text = "100";
            // 
            // scoreLabel1
            // 
            this.scoreLabel1.AutoSize = true;
            this.scoreLabel1.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.scoreLabel1.Location = new System.Drawing.Point(50, 5);
            this.scoreLabel1.Name = "scoreLabel1";
            this.scoreLabel1.Size = new System.Drawing.Size(72, 26);
            this.scoreLabel1.TabIndex = 14;
            this.scoreLabel1.Text = "Score: ";
            // 
            // infoPanel
            // 
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Image = ((System.Drawing.Image)(resources.GetObject("infoPanel.Image")));
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(845, 38);
            this.infoPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoPanel.TabIndex = 13;
            this.infoPanel.TabStop = false;
            // 
            // grass
            // 
            this.grass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grass.Image = ((System.Drawing.Image)(resources.GetObject("grass.Image")));
            this.grass.Location = new System.Drawing.Point(0, 38);
            this.grass.Name = "grass";
            this.grass.Size = new System.Drawing.Size(845, 370);
            this.grass.TabIndex = 12;
            this.grass.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameEnd
            // 
            this.gameEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.gameEnd.Controls.Add(this.closeButton);
            this.gameEnd.Controls.Add(this.replay);
            this.gameEnd.Controls.Add(this.label1);
            this.gameEnd.Font = new System.Drawing.Font("Rosewood Std Regular", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.gameEnd.Location = new System.Drawing.Point(225, 81);
            this.gameEnd.Name = "gameEnd";
            this.gameEnd.Size = new System.Drawing.Size(383, 218);
            this.gameEnd.TabIndex = 24;
            this.gameEnd.TabStop = false;
            this.gameEnd.Text = "Game over";
            this.gameEnd.Visible = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(188)))), ((int)(((byte)(60)))));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.closeButton.FlatAppearance.BorderSize = 2;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Rosewood Std Regular", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.closeButton.Location = new System.Drawing.Point(17, 156);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(340, 52);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close game";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // replay
            // 
            this.replay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.replay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(188)))), ((int)(((byte)(60)))));
            this.replay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.replay.FlatAppearance.BorderSize = 2;
            this.replay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replay.Font = new System.Drawing.Font("Rosewood Std Regular", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.replay.Location = new System.Drawing.Point(17, 98);
            this.replay.Name = "replay";
            this.replay.Size = new System.Drawing.Size(340, 52);
            this.replay.TabIndex = 1;
            this.replay.Text = "Play again";
            this.replay.UseVisualStyleBackColor = false;
            this.replay.Click += new System.EventHandler(this.replay_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 408);
            this.Controls.Add(this.gameEnd);
            this.Controls.Add(this.pressKey);
            this.Controls.Add(this.length2);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.scoreLabel2);
            this.Controls.Add(this.lengthLabel2);
            this.Controls.Add(this.length1);
            this.Controls.Add(this.lengthLabel1);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.scoreLabel1);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.grass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.Text = "Snake Battle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.infoPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass)).EndInit();
            this.gameEnd.ResumeLayout(false);
            this.gameEnd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pressKey;
        private System.Windows.Forms.Label length2;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label scoreLabel2;
        private System.Windows.Forms.Label lengthLabel2;
        private System.Windows.Forms.Label length1;
        private System.Windows.Forms.Label lengthLabel1;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label scoreLabel1;
        private System.Windows.Forms.PictureBox infoPanel;
        private System.Windows.Forms.PictureBox grass;
        private System.Windows.Forms.GroupBox gameEnd;
        private System.Windows.Forms.Button replay;
        private System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Timer timer1;
    }
}