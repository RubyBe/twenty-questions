﻿using System;
using System.Windows.Forms;

namespace TwentyQuestions
{
    public partial class GameForm : Form
    {
        // a question that will be the root node
        public Question root;
        // a question that will be the current node
        public Question current;
        // a result
        string result = "Doc Gonzo";

        public GameForm()
        {
            InitializeComponent();
        }

        // I have a pet - what is my pet?
        private void GameForm_Load(object sender, EventArgs e)
        {
            root = new Question("Can your pet fly?");
            root.yesNode = new Question("Does your pet have feathers?");
            root.noNode = new Question("Does your pet have scales?");
            current = root; // set the current node to point to the same node as the root
            QuestionLabel.Text = current.question;
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            // there may not be a next question
            // call IsLeaf
            if (current.IsLeaf())
            {
                //   is a leaf - game over, you won, play again?
                if (MessageBox.Show($"Then it's {result}! Play again?", "Twenty Questions", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    this.Close();
                }
                current = root;
                QuestionLabel.Text = current.question;
            }
            else
            {
                // is not a leaf - ask next question
                QuestionLabel.Text = current.yesNode.question;
                current = current.yesNode;
            }        
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            // there may not be a next question
            // call IsLeaf
            // is a leaf - game over, you lost, ask to learn or quit
            if (current.IsLeaf())
            {
                //  if doesn't want to teach -
                if (MessageBox.Show("Sorry, I can't guess - teach me?", "Twenty Questions", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    this.Close();
                }
                // if wants to teach, launch the learn form
                LearnForm learn = new LearnForm(this);
                learn.ShowDialog();
                QuestionLabel.Text = current.question;
            }
            else
            {
                // is not a leaf - ask next question
                QuestionLabel.Text = current.noNode.question;
                current = current.noNode;
            }
        }
    }
}
