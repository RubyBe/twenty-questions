using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyQuestions
{
    // a class that represents a binary tree node
    public class Question
    {
        // properties include a yes Question node/leaf and a no question node/leaf
        public string question; // holds the user question - or if a leaf node, then an object
        public Question yesNode;
        public Question noNode;

        // constructor for a question which accepts a single string
        public Question(string nodeQuestion)
        {
            question = nodeQuestion;
            yesNode = null;
            noNode = null;
        }

        public bool IsLeaf()
        {
            return yesNode == null && noNode == null;
        }

    }
}
