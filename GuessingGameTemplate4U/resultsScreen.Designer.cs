namespace GuessingGameTemplate4U
{
    partial class resultsScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.totalGuesses = new System.Windows.Forms.Label();
            this.Guesses = new System.Windows.Forms.Label();
            this.guessesInOrder = new System.Windows.Forms.Label();
            this.totalGuessesOutput = new System.Windows.Forms.Label();
            this.GuessesOutput = new System.Windows.Forms.Label();
            this.guessesInOrderOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalGuesses
            // 
            this.totalGuesses.AutoSize = true;
            this.totalGuesses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalGuesses.Location = new System.Drawing.Point(58, 57);
            this.totalGuesses.Name = "totalGuesses";
            this.totalGuesses.Size = new System.Drawing.Size(75, 13);
            this.totalGuesses.TabIndex = 0;
            this.totalGuesses.Text = "Total Guesses";
            // 
            // Guesses
            // 
            this.Guesses.AutoSize = true;
            this.Guesses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guesses.Location = new System.Drawing.Point(58, 124);
            this.Guesses.Name = "Guesses";
            this.Guesses.Size = new System.Drawing.Size(48, 13);
            this.Guesses.TabIndex = 1;
            this.Guesses.Text = "Guesses";
            // 
            // guessesInOrder
            // 
            this.guessesInOrder.AutoSize = true;
            this.guessesInOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guessesInOrder.Location = new System.Drawing.Point(58, 204);
            this.guessesInOrder.Name = "guessesInOrder";
            this.guessesInOrder.Size = new System.Drawing.Size(89, 13);
            this.guessesInOrder.TabIndex = 2;
            this.guessesInOrder.Text = "Guesses In Order";
            // 
            // totalGuessesOutput
            // 
            this.totalGuessesOutput.AutoSize = true;
            this.totalGuessesOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalGuessesOutput.Location = new System.Drawing.Point(58, 89);
            this.totalGuessesOutput.Name = "totalGuessesOutput";
            this.totalGuessesOutput.Size = new System.Drawing.Size(0, 13);
            this.totalGuessesOutput.TabIndex = 3;
            // 
            // GuessesOutput
            // 
            this.GuessesOutput.AutoSize = true;
            this.GuessesOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GuessesOutput.Location = new System.Drawing.Point(58, 164);
            this.GuessesOutput.Name = "GuessesOutput";
            this.GuessesOutput.Size = new System.Drawing.Size(0, 13);
            this.GuessesOutput.TabIndex = 4;
            // 
            // guessesInOrderOutput
            // 
            this.guessesInOrderOutput.AutoSize = true;
            this.guessesInOrderOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guessesInOrderOutput.Location = new System.Drawing.Point(58, 240);
            this.guessesInOrderOutput.Name = "guessesInOrderOutput";
            this.guessesInOrderOutput.Size = new System.Drawing.Size(0, 13);
            this.guessesInOrderOutput.TabIndex = 5;
            // 
            // resultsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.guessesInOrderOutput);
            this.Controls.Add(this.GuessesOutput);
            this.Controls.Add(this.totalGuessesOutput);
            this.Controls.Add(this.guessesInOrder);
            this.Controls.Add(this.Guesses);
            this.Controls.Add(this.totalGuesses);
            this.Name = "resultsScreen";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalGuesses;
        private System.Windows.Forms.Label Guesses;
        private System.Windows.Forms.Label guessesInOrder;
        private System.Windows.Forms.Label totalGuessesOutput;
        private System.Windows.Forms.Label GuessesOutput;
        private System.Windows.Forms.Label guessesInOrderOutput;
    }
}
