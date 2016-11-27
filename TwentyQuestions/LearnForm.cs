using System;
using System.IO;
using System.Windows.Forms;

namespace TwentyQuestions
{
    public partial class LearnForm : Form
    {
        // learning a new answer/question is adding a new node to the tree
        public GameForm _gameForm    { get; set; }
        public Game _game { get; set;  }

        // pass in the instance of the game form so that you can access its variables
        public LearnForm(Game game, GameForm gameForm)
        {
            InitializeComponent();
            // hide the play again button until a new question is submitted
            ButtonPlayAgain.Hide();
            _gameForm = gameForm;
            _game = game;
            // if this is the root node, we want to format the print list differently
            if(_game.listIndex == 0)
            {
                _game.listIndex = 1;
            }
        }

        private void LearnForm_Load(object sender, EventArgs e)
        {
            Question userQuestion = new Question(NewClue.Text);
            string userResult = NewObject.Text;
        }

        private void ButtonNewQuestion_Click(object sender, EventArgs e)
        {
            // build a new question node
            Question newQuestion = new Question(NewClue.Text);
            if (_game.nodeFlag == "Yes")
            {
                newQuestion.noNode = _game.temp.yesNode;
                newQuestion.yesNode =  new Question("Is your pet a " + NewObject.Text + "?");
                _game.current.yesNode = newQuestion;
            }
            else if (_game.nodeFlag == "No")
            {
                newQuestion.yesNode = new Question("Is your pet a " + NewObject.Text + "?");
                newQuestion.noNode = _game.temp.noNode;
                _game.temp.noNode = newQuestion;
            }          
            _game.current = _game.temp;
            // add node to list for printing after increasing count
            _game.listIndex++;
            if(_game.listIndex != 1)
            {
                _game.treeList.Add($"Node{_game.listIndex}: ", newQuestion);
            }
            // check the tree structure - if it is unbalanced, then rebalance
            // TODO

            // save the tree to a file 
            try
            {
                using (StreamWriter stream = File.AppendText(@"c:\repos\twenty-questions\questions.txt"))
                {
                    stream.WriteLine(newQuestion.question);
                    stream.WriteLine("\t" + newQuestion.yesNode.question);
                    stream.WriteLine("\t" + newQuestion.noNode.question);
                    stream.Close();
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found");
            }


            // make the play again button visible
            ButtonPlayAgain.Show();
        }

        private void ButtonPlayAgain_Click(object sender, EventArgs e)
        {
            // TODO
            // fine tune the traversal here
            _game.current = _game.root;
            _gameForm.QuestionLabel.Text = _game.current.question;
            this.Close();
        }

        private void PrintTree_Click(object sender, EventArgs e)
        {
            // if wants to print, launch the tree form
            Tree tree = new Tree(_game);
            tree.ShowDialog();
        }
    }
}
