namespace TwentyQuestions
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
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.LabelInstruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(65, 49);
            this.QuestionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(35, 13);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "label1";
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(68, 115);
            this.YesButton.Margin = new System.Windows.Forms.Padding(2);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(51, 25);
            this.YesButton.TabIndex = 1;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(146, 114);
            this.NoButton.Margin = new System.Windows.Forms.Padding(2);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(51, 25);
            this.NoButton.TabIndex = 2;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // LabelInstruction
            // 
            this.LabelInstruction.AutoSize = true;
            this.LabelInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInstruction.Location = new System.Drawing.Point(13, 2);
            this.LabelInstruction.Name = "LabelInstruction";
            this.LabelInstruction.Size = new System.Drawing.Size(302, 20);
            this.LabelInstruction.TabIndex = 3;
            this.LabelInstruction.Text = "You have a pet? Let me quess what it is...";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 270);
            this.Controls.Add(this.LabelInstruction);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.QuestionLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameForm";
            this.Text = "TwentyQuestions";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Label LabelInstruction;
        public System.Windows.Forms.Label QuestionLabel;
    }
}

