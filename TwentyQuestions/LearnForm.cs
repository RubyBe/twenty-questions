﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwentyQuestions
{
    public partial class LearnForm : Form
    {
        public GameForm _gameForm    { get; set; }

        // pass in the instance of the game form so that you can access its variables
        public LearnForm(GameForm gameForm)
        {
            InitializeComponent();
            ButtonPlayAgain.Hide();
            _gameForm = gameForm;
            if(_gameForm.listIndex == 0)
            {
                _gameForm.listIndex = 1;
            }

        }

        private void LearnForm_Load(object sender, EventArgs e)
        {
            Question userQuestion = new Question(NewClue.Text);
            string userResult = NewObject.Text;
        }

        private void ButtonNewQuestion_Click(object sender, EventArgs e)
        {
            Question newQuestion = new Question(NewClue.Text);
            if (_gameForm.nodeFlag == 1)
            {
                newQuestion.noNode = _gameForm.temp.yesNode;
                newQuestion.yesNode =  new Question("Is your pet a " + NewObject.Text + "?");
            }
            else
            {
                newQuestion.yesNode = new Question("Is your pet a " + NewObject.Text + "?");
                newQuestion.noNode = _gameForm.temp.noNode;
            }
            
            _gameForm.temp.yesNode = newQuestion;
            _gameForm.current = _gameForm.temp;
            // Add node to list for printing after increasing count
            _gameForm.listIndex++;
            if(_gameForm.listIndex != 1)
            {
                _gameForm.treeList.Add($"Node{_gameForm.listIndex}: ", newQuestion);
            }           
            ButtonPlayAgain.Show();
        }

        private void ButtonPlayAgain_Click(object sender, EventArgs e)
        {
            _gameForm.current = _gameForm.root;
            _gameForm.QuestionLabel.Text = _gameForm.current.question;
            this.Close();
        }

        private void PrintTree_Click(object sender, EventArgs e)
        {
            // if wants to print, launch the tree form
            Tree tree = new Tree(_gameForm);
            tree.ShowDialog();
        }
    }
}
