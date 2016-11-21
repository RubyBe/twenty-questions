using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TwentyQuestions
{
    public partial class GameForm : Form
    {
        public Game _game { get; set; }
        public GameForm()
        {
            InitializeComponent();
        }

        // I have a pet - what is my pet?
        private void GameForm_Load(object sender, EventArgs e)
        {
            _game = new Game();
            _game.root = _game.CreateRoot();
            _game.current = _game.root; // set the current node to point to the same node as the root
            _game.temp = _game.current; // temporary question to hold contents of current for creating new node
            QuestionLabel.Text = _game.current.question;
            // add note to list for tracking
            _game.treeList.Add("Node1: ", _game.root);
        }

        // checks to see whether current node is a leaf, and if so prints out success
        // if not, passes control back to the game
        private void YesButton_Click(object sender, EventArgs e)
        {          
            if (_game.current.IsLeaf())
            {
                // is a leaf - game over, you won, play again?
                if (MessageBox.Show($"I've guessed correctly! Play again?", "Twenty Questions", MessageBoxButtons.YesNo) == DialogResult.No)
                    // TODO - make it display the type of pet
                    if (MessageBox.Show($"Pet has been guessed! Play again?", "Twenty Questions", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    this.Close();
                }
                _game.current = _game.root;
                QuestionLabel.Text = _game.current.question;
            }
            else
            {
                _game.current = _game.HandleYes(_game.current);
                QuestionLabel.Text = _game.current.question;
            }
        }

        // the No functionality checks to see whether current node is a leaf, and if so asks to learn
        //  if so, passes control to the Learn functionality
        //  if not, ends the game
        // if not a leaf, passes control to game to ask next question
        private void NoButton_Click(object sender, EventArgs e)
        {

            if (_game.current.IsLeaf())
            {
                //  if doesn't want to teach -
                if (MessageBox.Show("Ooops, wrong! Teach me?", "Twenty Questions", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    this.Close();
                }
                // if wants to teach, launch the learn form
                LearnForm learn = new LearnForm(_game, this);
                learn.ShowDialog();
            }
            else
            {
                _game.current = _game.HandleNo(_game.current);
                QuestionLabel.Text = _game.current.question;
            }
        }

        private void PrintInGame(object sender, EventArgs e)
        {
            // if wants to print, launch the tree form
            Tree tree = new Tree(_game);
            tree.ShowDialog();
        }
    }
}
