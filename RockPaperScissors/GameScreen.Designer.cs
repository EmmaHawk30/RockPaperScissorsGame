namespace RockPaperScissors
{
    partial class GameScreen
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
            this.pbxRock = new System.Windows.Forms.PictureBox();
            this.pbxPaper = new System.Windows.Forms.PictureBox();
            this.pbxScissors = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pbxComputerChoice = new System.Windows.Forms.PictureBox();
            this.rdbRock = new System.Windows.Forms.RadioButton();
            this.rdbPaper = new System.Windows.Forms.RadioButton();
            this.rdbScissors = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComputerChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxRock
            // 
            this.pbxRock.Location = new System.Drawing.Point(48, 304);
            this.pbxRock.Name = "pbxRock";
            this.pbxRock.Size = new System.Drawing.Size(200, 187);
            this.pbxRock.TabIndex = 0;
            this.pbxRock.TabStop = false;
            // 
            // pbxPaper
            // 
            this.pbxPaper.Location = new System.Drawing.Point(295, 304);
            this.pbxPaper.Name = "pbxPaper";
            this.pbxPaper.Size = new System.Drawing.Size(200, 187);
            this.pbxPaper.TabIndex = 1;
            this.pbxPaper.TabStop = false;
            // 
            // pbxScissors
            // 
            this.pbxScissors.Location = new System.Drawing.Point(550, 304);
            this.pbxScissors.Name = "pbxScissors";
            this.pbxScissors.Size = new System.Drawing.Size(200, 189);
            this.pbxScissors.TabIndex = 2;
            this.pbxScissors.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(276, 566);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(200, 42);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbxComputerChoice
            // 
            this.pbxComputerChoice.Location = new System.Drawing.Point(295, 49);
            this.pbxComputerChoice.Name = "pbxComputerChoice";
            this.pbxComputerChoice.Size = new System.Drawing.Size(200, 208);
            this.pbxComputerChoice.TabIndex = 4;
            this.pbxComputerChoice.TabStop = false;
            // 
            // rdbRock
            // 
            this.rdbRock.AutoSize = true;
            this.rdbRock.Location = new System.Drawing.Point(87, 516);
            this.rdbRock.Name = "rdbRock";
            this.rdbRock.Size = new System.Drawing.Size(71, 24);
            this.rdbRock.TabIndex = 5;
            this.rdbRock.TabStop = true;
            this.rdbRock.Text = "Rock";
            this.rdbRock.UseVisualStyleBackColor = true;
            // 
            // rdbPaper
            // 
            this.rdbPaper.AutoSize = true;
            this.rdbPaper.Location = new System.Drawing.Point(352, 516);
            this.rdbPaper.Name = "rdbPaper";
            this.rdbPaper.Size = new System.Drawing.Size(76, 24);
            this.rdbPaper.TabIndex = 6;
            this.rdbPaper.TabStop = true;
            this.rdbPaper.Text = "Paper";
            this.rdbPaper.UseVisualStyleBackColor = true;
            // 
            // rdbScissors
            // 
            this.rdbScissors.AutoSize = true;
            this.rdbScissors.Location = new System.Drawing.Point(595, 516);
            this.rdbScissors.Name = "rdbScissors";
            this.rdbScissors.Size = new System.Drawing.Size(94, 24);
            this.rdbScissors.TabIndex = 7;
            this.rdbScissors.TabStop = true;
            this.rdbScissors.Text = "Scissors";
            this.rdbScissors.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(109, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Player:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Computer:";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(182, 93);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(18, 20);
            this.lblPlayer.TabIndex = 11;
            this.lblPlayer.Text = "0";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Location = new System.Drawing.Point(182, 144);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(18, 20);
            this.lblComputer.TabIndex = 12;
            this.lblComputer.Text = "0";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(608, 125);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 20);
            this.lblWinner.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 59);
            this.button1.TabIndex = 14;
            this.button1.Text = "Play again!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 666);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbScissors);
            this.Controls.Add(this.rdbPaper);
            this.Controls.Add(this.rdbRock);
            this.Controls.Add(this.pbxComputerChoice);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pbxScissors);
            this.Controls.Add(this.pbxPaper);
            this.Controls.Add(this.pbxRock);
            this.Name = "GameScreen";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComputerChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxRock;
        private System.Windows.Forms.PictureBox pbxPaper;
        private System.Windows.Forms.PictureBox pbxScissors;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox pbxComputerChoice;
        private System.Windows.Forms.RadioButton rdbRock;
        private System.Windows.Forms.RadioButton rdbPaper;
        private System.Windows.Forms.RadioButton rdbScissors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button button1;
    }
}

