namespace SnakeBattle
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.background = new System.Windows.Forms.PictureBox();
            this.playPVC = new System.Windows.Forms.Button();
            this.playCVC = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.howtoButton = new System.Windows.Forms.Button();
            this.playPVP = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.howToBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.howToBox)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(822, 473);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 1;
            this.background.TabStop = false;
            // 
            // playPVC
            // 
            this.playPVC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playPVC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(188)))), ((int)(((byte)(60)))));
            this.playPVC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.playPVC.FlatAppearance.BorderSize = 2;
            this.playPVC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playPVC.Font = new System.Drawing.Font("Rosewood Std Regular", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playPVC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.playPVC.Location = new System.Drawing.Point(322, 195);
            this.playPVC.Name = "playPVC";
            this.playPVC.Size = new System.Drawing.Size(340, 52);
            this.playPVC.TabIndex = 2;
            this.playPVC.Text = "Play PVC";
            this.playPVC.UseVisualStyleBackColor = false;
            this.playPVC.Click += new System.EventHandler(this.playButton_Click);
            // 
            // playCVC
            // 
            this.playCVC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playCVC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(188)))), ((int)(((byte)(60)))));
            this.playCVC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.playCVC.FlatAppearance.BorderSize = 2;
            this.playCVC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playCVC.Font = new System.Drawing.Font("Rosewood Std Regular", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playCVC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.playCVC.Location = new System.Drawing.Point(322, 253);
            this.playCVC.Name = "playCVC";
            this.playCVC.Size = new System.Drawing.Size(340, 52);
            this.playCVC.TabIndex = 3;
            this.playCVC.Text = "Watch CVC (Beta)";
            this.playCVC.UseVisualStyleBackColor = false;
            this.playCVC.Click += new System.EventHandler(this.playButton_Click);
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
            this.closeButton.Location = new System.Drawing.Point(322, 369);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(340, 52);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close game";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeGame);
            // 
            // howtoButton
            // 
            this.howtoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.howtoButton.AutoSize = true;
            this.howtoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(188)))), ((int)(((byte)(60)))));
            this.howtoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.howtoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.howtoButton.FlatAppearance.BorderSize = 2;
            this.howtoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.howtoButton.Font = new System.Drawing.Font("Rosewood Std Regular", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howtoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.howtoButton.Location = new System.Drawing.Point(322, 311);
            this.howtoButton.Name = "howtoButton";
            this.howtoButton.Size = new System.Drawing.Size(340, 52);
            this.howtoButton.TabIndex = 4;
            this.howtoButton.Text = "How to play";
            this.howtoButton.UseVisualStyleBackColor = false;
            this.howtoButton.Click += new System.EventHandler(this.howtoButton_Click);
            // 
            // playPVP
            // 
            this.playPVP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playPVP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(188)))), ((int)(((byte)(60)))));
            this.playPVP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.playPVP.FlatAppearance.BorderSize = 2;
            this.playPVP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playPVP.Font = new System.Drawing.Font("Rosewood Std Regular", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playPVP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.playPVP.Location = new System.Drawing.Point(322, 137);
            this.playPVP.Name = "playPVP";
            this.playPVP.Size = new System.Drawing.Size(340, 52);
            this.playPVP.TabIndex = 1;
            this.playPVP.Text = "Play PVP";
            this.playPVP.UseVisualStyleBackColor = false;
            this.playPVP.Click += new System.EventHandler(this.playButton_Click);
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(188)))), ((int)(((byte)(60)))));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.backButton.FlatAppearance.BorderSize = 2;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Rosewood Std Regular", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.backButton.Location = new System.Drawing.Point(239, 369);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(340, 52);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // howToBox
            // 
            this.howToBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.howToBox.Image = ((System.Drawing.Image)(resources.GetObject("howToBox.Image")));
            this.howToBox.Location = new System.Drawing.Point(0, 0);
            this.howToBox.Name = "howToBox";
            this.howToBox.Size = new System.Drawing.Size(822, 473);
            this.howToBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.howToBox.TabIndex = 12;
            this.howToBox.TabStop = false;
            this.howToBox.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(14)))));
            this.titleLabel.Location = new System.Drawing.Point(223, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(544, 94);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Snake Battle";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 473);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.playPVC);
            this.Controls.Add(this.playCVC);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.howtoButton);
            this.Controls.Add(this.playPVP);
            this.Controls.Add(this.background);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.howToBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.Text = "Snake Battle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.howToBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Button playPVC;
        private System.Windows.Forms.Button playCVC;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button howtoButton;
        private System.Windows.Forms.Button playPVP;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox howToBox;
        private System.Windows.Forms.Label titleLabel;
    }
}

