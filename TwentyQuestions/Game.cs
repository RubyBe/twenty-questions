﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            // get the game started by populating the first (root) node
            // with the base differentiating question and setting the child
            // nodes with two questions reflecting potential answers
            root = new Question("Can your pet fly?");
            root.yesNode = new Question("Is your pet a bird?");
            root.noNode = new Question("Is your pet a snake?");
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
