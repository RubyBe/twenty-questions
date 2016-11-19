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
            this.PrintTree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewObjectLabel
            // 
            this.NewObjectLabel.AutoSize = true;
            this.NewObjectLabel.Location = new System.Drawing.Point(26, 41);
            this.NewObjectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NewObjectLabel.Name = "NewObjectLabel";
            this.NewObjectLabel.Size = new System.Drawing.Size(238, 25);
            this.NewObjectLabel.TabIndex = 0;
            this.NewObjectLabel.Text = "Please enter your pet type";
            // 
            // NewObject
            // 
            this.NewObject.Location = new System.Drawing.Point(29, 83);
            this.NewObject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewObject.Name = "NewObject";
            this.NewObject.Size = new System.Drawing.Size(759, 29);
            this.NewObject.TabIndex = 1;
            // 
            // NewClueLabel
            // 
            this.NewClueLabel.AutoSize = true;
            this.NewClueLabel.Location = new System.Drawing.Point(29, 155);
            this.NewClueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NewClueLabel.Name = "NewClueLabel";
            this.NewClueLabel.Size = new System.Drawing.Size(511, 25);
            this.NewClueLabel.TabIndex = 2;
            this.NewClueLabel.Text = "Please enter a question that would have helped me guess";
            // 
            // NewClue
            // 
            this.NewClue.Location = new System.Drawing.Point(29, 214);
            this.NewClue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewClue.Name = "NewClue";
            this.NewClue.Size = new System.Drawing.Size(759, 29);
            this.NewClue.TabIndex = 3;
            // 
            // ButtonNewClue
            // 
            this.ButtonNewClue.Location = new System.Drawing.Point(149, 294);
            this.ButtonNewClue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonNewClue.Name = "ButtonNewClue";
            this.ButtonNewClue.Size = new System.Drawing.Size(138, 42);
            this.ButtonNewClue.TabIndex = 4;
            this.ButtonNewClue.Text = "Submit";
            this.ButtonNewClue.UseVisualStyleBackColor = true;
            this.ButtonNewClue.Click += new System.EventHandler(this.ButtonNewQuestion_Click);
            // 
            // ButtonPlayAgain
            // 
            this.ButtonPlayAgain.Location = new System.Drawing.Point(342, 294);
            this.ButtonPlayAgain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonPlayAgain.Name = "ButtonPlayAgain";
            this.ButtonPlayAgain.Size = new System.Drawing.Size(138, 42);
            this.ButtonPlayAgain.TabIndex = 5;
            this.ButtonPlayAgain.Text = "Play Again";
            this.ButtonPlayAgain.UseVisualStyleBackColor = true;
            this.ButtonPlayAgain.Click += new System.EventHandler(this.ButtonPlayAgain_Click);
            // 
            // PrintTree
            // 
            this.PrintTree.Location = new System.Drawing.Point(577, 294);
            this.PrintTree.Name = "PrintTree";
            this.PrintTree.Size = new System.Drawing.Size(114, 41);
            this.PrintTree.TabIndex = 6;
            this.PrintTree.Text = "View Tree";
            this.PrintTree.UseVisualStyleBackColor = true;
            this.PrintTree.Click += new System.EventHandler(this.PrintTree_Click);
            // 
            // LearnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 384);
            this.Controls.Add(this.PrintTree);
            this.Controls.Add(this.ButtonPlayAgain);
            this.Controls.Add(this.ButtonNewClue);
            this.Controls.Add(this.NewClue);
            this.Controls.Add(this.NewClueLabel);
            this.Controls.Add(this.NewObject);
            this.Controls.Add(this.NewObjectLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button PrintTree;
    }
}