namespace NumberGuessUI
{
    partial class Form1
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
            this.lblNumberGuessGame = new System.Windows.Forms.Label();
            this.lblUpperLimit = new System.Windows.Forms.Label();
            this.lblLowerLimit = new System.Windows.Forms.Label();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.lblMakeGuess = new System.Windows.Forms.Label();
            this.lblTheNumberIs = new System.Windows.Forms.Label();
            this.txtUpperLimit = new System.Windows.Forms.TextBox();
            this.txtLowerLimit = new System.Windows.Forms.TextBox();
            this.txtMakeGuess = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumberGuessGame
            // 
            this.lblNumberGuessGame.AutoSize = true;
            this.lblNumberGuessGame.Location = new System.Drawing.Point(41, 53);
            this.lblNumberGuessGame.Name = "lblNumberGuessGame";
            this.lblNumberGuessGame.Size = new System.Drawing.Size(239, 16);
            this.lblNumberGuessGame.TabIndex = 0;
            this.lblNumberGuessGame.Text = "Welcome to Number Guessing Service";
            // 
            // lblUpperLimit
            // 
            this.lblUpperLimit.AutoSize = true;
            this.lblUpperLimit.Location = new System.Drawing.Point(175, 208);
            this.lblUpperLimit.Name = "lblUpperLimit";
            this.lblUpperLimit.Size = new System.Drawing.Size(75, 16);
            this.lblUpperLimit.TabIndex = 1;
            this.lblUpperLimit.Text = "Upper Limit";
            this.lblUpperLimit.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblLowerLimit
            // 
            this.lblLowerLimit.AutoSize = true;
            this.lblLowerLimit.Location = new System.Drawing.Point(336, 53);
            this.lblLowerLimit.Name = "lblLowerLimit";
            this.lblLowerLimit.Size = new System.Drawing.Size(73, 16);
            this.lblLowerLimit.TabIndex = 2;
            this.lblLowerLimit.Text = "Lower Limit";
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Location = new System.Drawing.Point(486, 77);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(69, 16);
            this.lblAttempts.TabIndex = 3;
            this.lblAttempts.Text = "Attempts - ";
            // 
            // lblMakeGuess
            // 
            this.lblMakeGuess.AutoSize = true;
            this.lblMakeGuess.Location = new System.Drawing.Point(160, 77);
            this.lblMakeGuess.Name = "lblMakeGuess";
            this.lblMakeGuess.Size = new System.Drawing.Size(95, 16);
            this.lblMakeGuess.TabIndex = 4;
            this.lblMakeGuess.Text = "Make A Guess";
            this.lblMakeGuess.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTheNumberIs
            // 
            this.lblTheNumberIs.AutoSize = true;
            this.lblTheNumberIs.Location = new System.Drawing.Point(474, 249);
            this.lblTheNumberIs.Name = "lblTheNumberIs";
            this.lblTheNumberIs.Size = new System.Drawing.Size(95, 16);
            this.lblTheNumberIs.TabIndex = 5;
            this.lblTheNumberIs.Text = "The Number Is";
            // 
            // txtUpperLimit
            // 
            this.txtUpperLimit.Location = new System.Drawing.Point(-2, 129);
            this.txtUpperLimit.Name = "txtUpperLimit";
            this.txtUpperLimit.Size = new System.Drawing.Size(100, 22);
            this.txtUpperLimit.TabIndex = 6;
            // 
            // txtLowerLimit
            // 
            this.txtLowerLimit.Location = new System.Drawing.Point(258, 96);
            this.txtLowerLimit.Name = "txtLowerLimit";
            this.txtLowerLimit.Size = new System.Drawing.Size(100, 22);
            this.txtLowerLimit.TabIndex = 7;
            // 
            // txtMakeGuess
            // 
            this.txtMakeGuess.Location = new System.Drawing.Point(355, 163);
            this.txtMakeGuess.Name = "txtMakeGuess";
            this.txtMakeGuess.Size = new System.Drawing.Size(100, 22);
            this.txtMakeGuess.TabIndex = 8;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(57, 332);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generate A secret Number";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(258, 371);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtMakeGuess);
            this.Controls.Add(this.txtLowerLimit);
            this.Controls.Add(this.txtUpperLimit);
            this.Controls.Add(this.lblTheNumberIs);
            this.Controls.Add(this.lblMakeGuess);
            this.Controls.Add(this.lblAttempts);
            this.Controls.Add(this.lblLowerLimit);
            this.Controls.Add(this.lblUpperLimit);
            this.Controls.Add(this.lblNumberGuessGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberGuessGame;
        private System.Windows.Forms.Label lblUpperLimit;
        private System.Windows.Forms.Label lblLowerLimit;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.Label lblMakeGuess;
        private System.Windows.Forms.Label lblTheNumberIs;
        private System.Windows.Forms.TextBox txtUpperLimit;
        private System.Windows.Forms.TextBox txtLowerLimit;
        private System.Windows.Forms.TextBox txtMakeGuess;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnPlay;
    }
}

