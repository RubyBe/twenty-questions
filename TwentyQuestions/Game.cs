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
            Question root = new Question();
            // first try to load an existing tree by reading the questions.txt file
            // check to see whether or not tree contains content
            int counter = CountTree();
            if (counter < 1)
            {
                // file is empty; get the game started by populating the first (root) node
                // with the base differentiating question and setting the child
                // nodes with two questions reflecting potential answers
                root = new Question("Can your pet fly?");
                root.yesNode = new Question("Is your pet a bird?");
                root.noNode = new Question("Is your pet a snake?");
            }
            else
            {
                // file is not empty; load the tree
                root = LoadTree();
            }
            return root;
        }

        // Attempt to read a tree from a file
        string filename = @"C:\repos\twenty-questions\questions.txt";
        string line;
        int count;

        // return the number of nodes stored in the tree file
        public int CountTree()
        {
            StreamReader reader = File.OpenText(filename);
            while((line = reader.ReadLine()) != null)
            {
                count++;
            }
            if (count == 0)
            {
                return count;
            }
            else
            {
                int nodes = count / 3;
                return nodes;
            }
        }

        public Question LoadTree()
        {
            // lists to hold nodes
            Question savedRoot = new Question();
            List<string> roots = new List<string>();
            List<string> yeses = new List<string>();
            List<string> nos = new List<string>();

            int counter = CountTree();
            StreamReader reader = File.OpenText(filename);
            for (int i = 0; i < counter; i++)
            {
                line = reader.ReadLine();
                roots.Add(line);
                line = reader.ReadLine();
                yeses.Add(line);
                line = reader.ReadLine();
                nos.Add(line);
            }
            // build the tree
            //Question yesNode = new Question();
            //Question noNode = new Question();
            return savedRoot;
        }

        public Question HandleYes(Question current)
        {
            // function to manage a yes answer to a question
            // is not a leaf - ask next question
            Question question;
            question = current.yesNode;
            nodeFlag = "Yes";
            return question;
        }
        public Question HandleNo(Question current)
        {
            // function to manage a no answer to a question
            // is not a leaf - ask next question
            Question question;
            question = current.noNode;
            nodeFlag = "No";
            return question;
        }
    }
}
