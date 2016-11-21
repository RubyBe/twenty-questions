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
        public string question; // holds the user question - or if a leaf node, then a question which represents a guess
        public Question yesNode;
        public Question noNode;
        // a property which will be used to track the depth of the tree
        public int depth;


        // constructor with no parameters required
        public Question()
        {
            depth = 1;
        }

        // constructor for a question which accepts a single string
        public Question(string nodeQuestion)
        {
            question = nodeQuestion;
            yesNode = null;
            noNode = null;
            depth = 1;
        }

        public bool IsLeaf()
        {
            return yesNode == null || noNode == null; // neither can be null -
        }

        public bool IsDeep()
        {
            return (yesNode != null && yesNode.yesNode != null); // depth is greater than 1
        }

    }
}
