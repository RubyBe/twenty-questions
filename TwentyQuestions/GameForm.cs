using System;
using System.Windows.Forms;

namespace TwentyQuestions
{
    public partial class GameForm : Form
    {
        // a question that will be the root node
        public Question root;
        // a question that will be the current node
        public Question current;
        // a temp question
        public Question temp; // a temp question to hold values while building the new node
        // a flag to indicate branch type; 1 = yes, 0 = no
        public int nodeFlag;

        public GameForm()
        {
            InitializeComponent();
        }

        // I have a pet - what is my pet?
        private void GameForm_Load(object sender, EventArgs e)
        {
            Game game = new Game();
            root = game.CreateRoot();
            current = root; // set the current node to point to the same node as the root
            temp = current;
            QuestionLabel.Text = current.question;
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            // there may not be a next question
            // call IsLeaf
            if (current.IsLeaf())
            {
                // is a leaf - game over, you won, play again?
                // if (MessageBox.Show($"Then it's {result}! Play again?", "Twenty Questions", MessageBoxButtons.YesNo) == DialogResult.No)
                // TODO - make it display the type of pet
                if (MessageBox.Show($"Pet has been guessed! Play again?", "Twenty Questions", MessageBoxButtons.YesNo) == DialogResult.No)
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
                nodeFlag = 1;
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
                if (MessageBox.Show("Ooops, wrong! Teach me?", "Twenty Questions", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    this.Close();
                }
                // if wants to teach, launch the learn form
                LearnForm learn = new LearnForm(this);
                learn.ShowDialog();
                //QuestionLabel.Text = current.question;
            }
            else
            {
                // is not a leaf - ask next question
                QuestionLabel.Text = current.noNode.question;
                current = current.noNode;
                nodeFlag = 0;
            }
        }

        private void PrintInGame(object sender, EventArgs e)
        {

        }
    }
}
