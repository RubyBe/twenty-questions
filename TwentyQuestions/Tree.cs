using System;
using System.Windows.Forms;

namespace TwentyQuestions
{
    public partial class Tree : Form
    {
        public GameForm _gameForm { get; set; }
        public Tree(GameForm gameForm)
        {
            InitializeComponent();
            _gameForm = gameForm;
        }

        private void Tree_Load(object sender, EventArgs e)
        {
            TreeListView.Columns.Add("Key", 60);
            TreeListView.Columns.Add("Value", 200);
            foreach (var question in _gameForm.treeList)
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