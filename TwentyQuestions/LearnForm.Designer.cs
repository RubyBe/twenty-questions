namespace TwentyQuestions
{
    partial class LearnForm
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
            this.NewObjectLabel = new System.Windows.Forms.Label();
            this.NewObject = new System.Windows.Forms.TextBox();
            this.NewClueLabel = new System.Windows.Forms.Label();
            this.NewClue = new System.Windows.Forms.TextBox();
            this.ButtonNewClue = new System.Windows.Forms.Button();
            this.ButtonPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewObjectLabel
            // 
            this.NewObjectLabel.AutoSize = true;
            this.NewObjectLabel.Location = new System.Drawing.Point(14, 22);
            this.NewObjectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewObjectLabel.Name = "NewObjectLabel";
            this.NewObjectLabel.Size = new System.Drawing.Size(130, 13);
            this.NewObjectLabel.TabIndex = 0;
            this.NewObjectLabel.Text = "Please enter your pet type";
            // 
            // NewObject
            // 
            this.NewObject.Location = new System.Drawing.Point(16, 45);
            this.NewObject.Margin = new System.Windows.Forms.Padding(2);
            this.NewObject.Name = "NewObject";
            this.NewObject.Size = new System.Drawing.Size(416, 20);
            this.NewObject.TabIndex = 1;
            // 
            // NewClueLabel
            // 
            this.NewClueLabel.AutoSize = true;
            this.NewClueLabel.Location = new System.Drawing.Point(16, 84);
            this.NewClueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewClueLabel.Name = "NewClueLabel";
            this.NewClueLabel.Size = new System.Drawing.Size(280, 13);
            this.NewClueLabel.TabIndex = 2;
            this.NewClueLabel.Text = "Please enter a question that would have helped me guess";
            // 
            // NewClue
            // 
            this.NewClue.Location = new System.Drawing.Point(16, 116);
            this.NewClue.Margin = new System.Windows.Forms.Padding(2);
            this.NewClue.Name = "NewClue";
            this.NewClue.Size = new System.Drawing.Size(416, 20);
            this.NewClue.TabIndex = 3;
            // 
            // ButtonNewClue
            // 
            this.ButtonNewClue.Location = new System.Drawing.Point(81, 159);
            this.ButtonNewClue.Name = "ButtonNewClue";
            this.ButtonNewClue.Size = new System.Drawing.Size(75, 23);
            this.ButtonNewClue.TabIndex = 4;
            this.ButtonNewClue.Text = "Submit";
            this.ButtonNewClue.UseVisualStyleBackColor = true;
            this.ButtonNewClue.Click += new System.EventHandler(this.ButtonNewClue_Click);
            // 
            // ButtonPlayAgain
            // 
            this.ButtonPlayAgain.Location = new System.Drawing.Point(284, 159);
            this.ButtonPlayAgain.Name = "ButtonPlayAgain";
            this.ButtonPlayAgain.Size = new System.Drawing.Size(75, 23);
            this.ButtonPlayAgain.TabIndex = 5;
            this.ButtonPlayAgain.Text = "Play Again";
            this.ButtonPlayAgain.UseVisualStyleBackColor = true;
            this.ButtonPlayAgain.Click += new System.EventHandler(this.ButtonPlayAgain_Click);
            // 
            // LearnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 208);
            this.Controls.Add(this.ButtonPlayAgain);
            this.Controls.Add(this.ButtonNewClue);
            this.Controls.Add(this.NewClue);
            this.Controls.Add(this.NewClueLabel);
            this.Controls.Add(this.NewObject);
            this.Controls.Add(this.NewObjectLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LearnForm";
            this.Text = "LearnForm";
            this.Load += new System.EventHandler(this.LearnForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewObjectLabel;
        private System.Windows.Forms.TextBox NewObject;
        private System.Windows.Forms.Label NewClueLabel;
        private System.Windows.Forms.TextBox NewClue;
        private System.Windows.Forms.Button ButtonNewClue;
        private System.Windows.Forms.Button ButtonPlayAgain;
    }
}