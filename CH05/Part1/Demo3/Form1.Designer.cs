namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnHeads = new Button();
            btnTails = new Button();
            btnNewGame = new Button();
            lblCoinResult = new Label();
            lblRoundResult = new Label();
            lblPlayerScore = new Label();
            lblComputerScore = new Label();
            lblRound = new Label();
            lblWinner = new Label();
            SuspendLayout();
            // 
            // btnHeads
            // 
            btnHeads.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHeads.ForeColor = Color.DarkBlue;
            btnHeads.Location = new Point(196, 49);
            btnHeads.Name = "btnHeads";
            btnHeads.Size = new Size(132, 48);
            btnHeads.TabIndex = 0;
            btnHeads.Text = "Heads";
            btnHeads.UseVisualStyleBackColor = true;
            btnHeads.Click += btnHeads_Click;
            // 
            // btnTails
            // 
            btnTails.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTails.ForeColor = Color.DarkGreen;
            btnTails.Location = new Point(410, 49);
            btnTails.Name = "btnTails";
            btnTails.Size = new Size(132, 48);
            btnTails.TabIndex = 1;
            btnTails.Text = "Tails";
            btnTails.UseVisualStyleBackColor = true;
            btnTails.Click += btnTails_Click;
            // 
            // btnNewGame
            // 
            btnNewGame.Enabled = false;
            btnNewGame.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewGame.Location = new Point(286, 330);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(163, 48);
            btnNewGame.TabIndex = 2;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // lblCoinResult
            // 
            lblCoinResult.Location = new Point(104, 109);
            lblCoinResult.Name = "lblCoinResult";
            lblCoinResult.Size = new Size(461, 23);
            lblCoinResult.TabIndex = 3;
            lblCoinResult.Text = "label1";
            // 
            // lblRoundResult
            // 
            lblRoundResult.Location = new Point(104, 141);
            lblRoundResult.Name = "lblRoundResult";
            lblRoundResult.Size = new Size(461, 23);
            lblRoundResult.TabIndex = 4;
            lblRoundResult.Text = "label1";
            // 
            // lblPlayerScore
            // 
            lblPlayerScore.Location = new Point(104, 177);
            lblPlayerScore.Name = "lblPlayerScore";
            lblPlayerScore.Size = new Size(461, 23);
            lblPlayerScore.TabIndex = 5;
            lblPlayerScore.Text = "label1";
            // 
            // lblComputerScore
            // 
            lblComputerScore.Location = new Point(104, 213);
            lblComputerScore.Name = "lblComputerScore";
            lblComputerScore.Size = new Size(461, 23);
            lblComputerScore.TabIndex = 6;
            lblComputerScore.Text = "label1";
            // 
            // lblRound
            // 
            lblRound.Location = new Point(104, 251);
            lblRound.Name = "lblRound";
            lblRound.Size = new Size(461, 23);
            lblRound.TabIndex = 7;
            lblRound.Text = "label1";
            // 
            // lblWinner
            // 
            lblWinner.Location = new Point(104, 287);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(461, 23);
            lblWinner.TabIndex = 8;
            lblWinner.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblWinner);
            Controls.Add(lblRound);
            Controls.Add(lblComputerScore);
            Controls.Add(lblPlayerScore);
            Controls.Add(lblRoundResult);
            Controls.Add(lblCoinResult);
            Controls.Add(btnNewGame);
            Controls.Add(btnTails);
            Controls.Add(btnHeads);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHeads;
        private Button btnTails;
        private Button btnNewGame;
        private Label lblCoinResult;
        private Label lblRoundResult;
        private Label lblPlayerScore;
        private Label lblComputerScore;
        private Label lblRound;
        private Label lblWinner;
    }
}
