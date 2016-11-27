using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TwentyQuestions
{
    public class Game
    {
        // The game: You have a pet - what the game guess the pet?
        // a class that controls a game by tracking the contents of tree
        // a question that will be the root node
        public Question root;
        // a question that will be the current node
        public Question current;
        // a counter that will be used to track the depth of the tree
        public int depth;
        // a temp question to hold values while building the new node
        public Question temp;
        // a flag to indicate branch type; 1 = yes, 0 = no
        public string nodeFlag;
        // List to hold questions for output purposes
        public Dictionary<string, Question> treeList = new Dictionary<string, Question> { };
        public int listIndex; // index to track # of nodes - first = root

        public Question CreateRoot()
        {
            // first try to load an existing tree by reading the questions.txt file
            Question root = new Question();
            root = LoadTree();
            // get the game started by populating the first (root) node
            // with the base differentiating question and setting the child
            // nodes with two questions reflecting potential answers
            //root = new Question("Can your pet fly?");
            //root.yesNode = new Question("Is your pet a bird?");
            //root.noNode = new Question("Is your pet a snake?");
            return root;
        }

        // Attempt to read a tree from a file
        string filename = @"C:\repos\twenty-questions\questions.txt";
        char[] tree;
        StringBuilder builder = new StringBuilder();

        public Question LoadTree()
        {
            Question root = new Question();
            using (StreamReader reader = File.OpenText(filename))
            {
                tree = new char[reader.BaseStream.Length];
                reader.Read(tree, 0, (int)reader.BaseStream.Length);
            }
            foreach (char c in tree)
            {
                if (char.IsLetterOrDigit(c))
                {
                    builder.Append(c);
                    root.question = builder.ToString();
                }
            }
            return root;
        }

        public Question HandleYes(Question current)
        {
            // function to manage a yes answer to a question
            // is not a leaf - ask next question
            Question question;
            question = current.yesNode;
            /*temp = current;*/
            nodeFlag = "Yes";
            return question;
        }
        public Question HandleNo(Question current)
        {
            // function to manage a no answer to a question
            // is not a leaf - ask next question
            Question question;
            question = current.noNode;
            //temp = current;
            nodeFlag = "No";
            return question;
        }
    }
}
