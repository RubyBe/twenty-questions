using System;
using System.Windows.Forms;

namespace TwentyQuestions
{
    public partial class Tree : Form
    {
        // a class to build and display a tree list for printing to screen or a file
        public Game _game { get; set; }
        public Tree(Game game)
        {
            InitializeComponent();
            _game = game;
        }

        private void Tree_Load(object sender, EventArgs e)
        {
            TreeListView.Columns.Add("Key", 60);
            TreeListView.Columns.Add("Value", 200);
            foreach (var question in  
                
                _game.treeList)
            {
                TreeListView.Items.Add(question.Key);
                TreeListView.Items.Add(question.Value.question);
                TreeListView.Items.Add(question.Value.yesNode.question);
                TreeListView.Items.Add(question.Value.noNode.question);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}