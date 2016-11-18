using System;
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
        public GameForm _parent { get; set; }

        // pass in the instance of the game form so that you can access its variables
        public LearnForm(GameForm parent)
        {
            InitializeComponent();
            ButtonPlayAgain.Hide();
            _parent = parent;
        }

        private void LearnForm_Load(object sender, EventArgs e)
        {
            Question userQuestion = new Question(NewClue.Text);
            string userResult = NewObject.Text;
        }

        private void ButtonNewClue_Click(object sender, EventArgs e)
        {
            _parent.current.noNode = new Question("Is your pet a " + NewObject.Text + "?");
            _parent.current.yesNode = new Question(NewClue.Text);
            _parent.current.question = NewClue.Text;
            ButtonPlayAgain.Show();
        }

        private void ButtonPlayAgain_Click(object sender, EventArgs e)
        {
            _parent.current = _parent.root;
            this.Close();
        }
    }
}
