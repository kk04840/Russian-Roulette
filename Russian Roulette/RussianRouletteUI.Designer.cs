namespace Russian_Roulette
{
    partial class RussianRouletteUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RussianRouletteUI));
            this.btnFire = new System.Windows.Forms.Button();
            this.lblShotsLeft = new System.Windows.Forms.Label();
            this.lblDucksLeft = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.tbxShotsLeftDisplay = new System.Windows.Forms.TextBox();
            this.tbxDucksLeftDisplay = new System.Windows.Forms.TextBox();
            this.tbxWinsDisplay = new System.Windows.Forms.TextBox();
            this.tbxLossesDisplay = new System.Windows.Forms.TextBox();
            this.rbtnPointAtHead = new System.Windows.Forms.RadioButton();
            this.rbtnDuck = new System.Windows.Forms.RadioButton();
            this.lblDisplayPlayerName = new System.Windows.Forms.Label();
            this.btnLoadBullet = new System.Windows.Forms.Button();
            this.btnSpinChambers = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.lblDispalyResults = new System.Windows.Forms.Label();
            this.pbxPlayerAvatar = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayerAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.Red;
            this.btnFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.Location = new System.Drawing.Point(509, 291);
            this.btnFire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(159, 95);
            this.btnFire.TabIndex = 0;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // lblShotsLeft
            // 
            this.lblShotsLeft.AutoSize = true;
            this.lblShotsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShotsLeft.ForeColor = System.Drawing.Color.Blue;
            this.lblShotsLeft.Location = new System.Drawing.Point(846, 306);
            this.lblShotsLeft.Name = "lblShotsLeft";
            this.lblShotsLeft.Size = new System.Drawing.Size(127, 26);
            this.lblShotsLeft.TabIndex = 1;
            this.lblShotsLeft.Text = "Shots Left:";
            // 
            // lblDucksLeft
            // 
            this.lblDucksLeft.AutoSize = true;
            this.lblDucksLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDucksLeft.ForeColor = System.Drawing.Color.Blue;
            this.lblDucksLeft.Location = new System.Drawing.Point(841, 340);
            this.lblDucksLeft.Name = "lblDucksLeft";
            this.lblDucksLeft.Size = new System.Drawing.Size(132, 26);
            this.lblDucksLeft.TabIndex = 3;
            this.lblDucksLeft.Text = "Ducks Left:";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.ForeColor = System.Drawing.Color.Green;
            this.lblWins.Location = new System.Drawing.Point(713, 75);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(72, 26);
            this.lblWins.TabIndex = 8;
            this.lblWins.Text = "Wins:";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLosses.ForeColor = System.Drawing.Color.Red;
            this.lblLosses.Location = new System.Drawing.Point(862, 75);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(94, 26);
            this.lblLosses.TabIndex = 6;
            this.lblLosses.Text = "Losses:";
            // 
            // tbxShotsLeftDisplay
            // 
            this.tbxShotsLeftDisplay.Enabled = false;
            this.tbxShotsLeftDisplay.Location = new System.Drawing.Point(979, 304);
            this.tbxShotsLeftDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxShotsLeftDisplay.Name = "tbxShotsLeftDisplay";
            this.tbxShotsLeftDisplay.Size = new System.Drawing.Size(57, 26);
            this.tbxShotsLeftDisplay.TabIndex = 9;
            this.tbxShotsLeftDisplay.Text = "0";
            // 
            // tbxDucksLeftDisplay
            // 
            this.tbxDucksLeftDisplay.Enabled = false;
            this.tbxDucksLeftDisplay.Location = new System.Drawing.Point(979, 340);
            this.tbxDucksLeftDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxDucksLeftDisplay.Name = "tbxDucksLeftDisplay";
            this.tbxDucksLeftDisplay.Size = new System.Drawing.Size(62, 26);
            this.tbxDucksLeftDisplay.TabIndex = 10;
            this.tbxDucksLeftDisplay.Text = "0";
            // 
            // tbxWinsDisplay
            // 
            this.tbxWinsDisplay.Enabled = false;
            this.tbxWinsDisplay.Location = new System.Drawing.Point(791, 75);
            this.tbxWinsDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxWinsDisplay.Name = "tbxWinsDisplay";
            this.tbxWinsDisplay.Size = new System.Drawing.Size(54, 26);
            this.tbxWinsDisplay.TabIndex = 11;
            this.tbxWinsDisplay.Text = "0";
            // 
            // tbxLossesDisplay
            // 
            this.tbxLossesDisplay.Enabled = false;
            this.tbxLossesDisplay.Location = new System.Drawing.Point(987, 77);
            this.tbxLossesDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxLossesDisplay.Name = "tbxLossesDisplay";
            this.tbxLossesDisplay.Size = new System.Drawing.Size(54, 26);
            this.tbxLossesDisplay.TabIndex = 12;
            this.tbxLossesDisplay.Text = "0";
            // 
            // rbtnPointAtHead
            // 
            this.rbtnPointAtHead.AutoSize = true;
            this.rbtnPointAtHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPointAtHead.ForeColor = System.Drawing.Color.Teal;
            this.rbtnPointAtHead.Location = new System.Drawing.Point(674, 307);
            this.rbtnPointAtHead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnPointAtHead.Name = "rbtnPointAtHead";
            this.rbtnPointAtHead.Size = new System.Drawing.Size(159, 26);
            this.rbtnPointAtHead.TabIndex = 13;
            this.rbtnPointAtHead.TabStop = true;
            this.rbtnPointAtHead.Text = "Point At Head";
            this.rbtnPointAtHead.UseVisualStyleBackColor = true;
            this.rbtnPointAtHead.CheckedChanged += new System.EventHandler(this.rbtnPointAtHead_CheckedChanged);
            // 
            // rbtnDuck
            // 
            this.rbtnDuck.AutoSize = true;
            this.rbtnDuck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDuck.ForeColor = System.Drawing.Color.Teal;
            this.rbtnDuck.Location = new System.Drawing.Point(674, 339);
            this.rbtnDuck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnDuck.Name = "rbtnDuck";
            this.rbtnDuck.Size = new System.Drawing.Size(80, 26);
            this.rbtnDuck.TabIndex = 14;
            this.rbtnDuck.TabStop = true;
            this.rbtnDuck.Text = "Duck";
            this.rbtnDuck.UseVisualStyleBackColor = true;
            this.rbtnDuck.CheckedChanged += new System.EventHandler(this.rbtnDuck_CheckedChanged);
            // 
            // lblDisplayPlayerName
            // 
            this.lblDisplayPlayerName.AutoSize = true;
            this.lblDisplayPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayPlayerName.Location = new System.Drawing.Point(21, 11);
            this.lblDisplayPlayerName.Name = "lblDisplayPlayerName";
            this.lblDisplayPlayerName.Size = new System.Drawing.Size(0, 25);
            this.lblDisplayPlayerName.TabIndex = 15;
            // 
            // btnLoadBullet
            // 
            this.btnLoadBullet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLoadBullet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadBullet.Location = new System.Drawing.Point(509, 75);
            this.btnLoadBullet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadBullet.Name = "btnLoadBullet";
            this.btnLoadBullet.Size = new System.Drawing.Size(159, 89);
            this.btnLoadBullet.TabIndex = 16;
            this.btnLoadBullet.Text = "Load Bullet";
            this.btnLoadBullet.UseVisualStyleBackColor = false;
            this.btnLoadBullet.Click += new System.EventHandler(this.btnLoadBullet_Click);
            // 
            // btnSpinChambers
            // 
            this.btnSpinChambers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSpinChambers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpinChambers.Location = new System.Drawing.Point(509, 182);
            this.btnSpinChambers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSpinChambers.Name = "btnSpinChambers";
            this.btnSpinChambers.Size = new System.Drawing.Size(159, 91);
            this.btnSpinChambers.TabIndex = 17;
            this.btnSpinChambers.Text = "Spin Chambers";
            this.btnSpinChambers.UseVisualStyleBackColor = false;
            this.btnSpinChambers.Click += new System.EventHandler(this.btnSpinChambers_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(509, 410);
            this.btnReload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(176, 90);
            this.btnReload.TabIndex = 18;
            this.btnReload.Text = "Reload the Game";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lblDispalyResults
            // 
            this.lblDispalyResults.AutoSize = true;
            this.lblDispalyResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispalyResults.ForeColor = System.Drawing.Color.Purple;
            this.lblDispalyResults.Location = new System.Drawing.Point(172, 583);
            this.lblDispalyResults.Name = "lblDispalyResults";
            this.lblDispalyResults.Size = new System.Drawing.Size(160, 46);
            this.lblDispalyResults.TabIndex = 19;
            this.lblDispalyResults.Text = "Results";
            // 
            // pbxPlayerAvatar
            // 
            this.pbxPlayerAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbxPlayerAvatar.Image")));
            this.pbxPlayerAvatar.Location = new System.Drawing.Point(12, 58);
            this.pbxPlayerAvatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxPlayerAvatar.Name = "pbxPlayerAvatar";
            this.pbxPlayerAvatar.Size = new System.Drawing.Size(486, 469);
            this.pbxPlayerAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPlayerAvatar.TabIndex = 20;
            this.pbxPlayerAvatar.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(141, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 28);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "is Playing the Game";
            // 
            // RussianRouletteUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1091, 712);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pbxPlayerAvatar);
            this.Controls.Add(this.lblDispalyResults);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSpinChambers);
            this.Controls.Add(this.btnLoadBullet);
            this.Controls.Add(this.lblDisplayPlayerName);
            this.Controls.Add(this.rbtnDuck);
            this.Controls.Add(this.rbtnPointAtHead);
            this.Controls.Add(this.tbxLossesDisplay);
            this.Controls.Add(this.tbxWinsDisplay);
            this.Controls.Add(this.tbxDucksLeftDisplay);
            this.Controls.Add(this.tbxShotsLeftDisplay);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.lblDucksLeft);
            this.Controls.Add(this.lblShotsLeft);
            this.Controls.Add(this.btnFire);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RussianRouletteUI";
            this.Text = "Russian Roulette";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RussianRoulette_FormClosing);
            this.Load += new System.EventHandler(this.RussianRoulette_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayerAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Label lblShotsLeft;
        private System.Windows.Forms.Label lblDucksLeft;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.TextBox tbxShotsLeftDisplay;
        private System.Windows.Forms.TextBox tbxDucksLeftDisplay;
        private System.Windows.Forms.TextBox tbxWinsDisplay;
        private System.Windows.Forms.TextBox tbxLossesDisplay;
        private System.Windows.Forms.RadioButton rbtnPointAtHead;
        private System.Windows.Forms.RadioButton rbtnDuck;
        private System.Windows.Forms.Label lblDisplayPlayerName;
        private System.Windows.Forms.Button btnLoadBullet;
        private System.Windows.Forms.Button btnSpinChambers;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label lblDispalyResults;
        private System.Windows.Forms.PictureBox pbxPlayerAvatar;
        private System.Windows.Forms.TextBox textBox1;
    }
}