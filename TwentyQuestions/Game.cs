using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyQuestions
{
    class Game
    {
        // a question that will be the root node
        public Question root;

        // I have a pet - what is my pet?
        public Question CreateRoot()
        {
            root = new Question("Can your pet fly?");
            root.yesNode = new Question("Is your pet a bird?");
            root.noNode = new Question("Is your pet a snake?");
            return root;

        }
    }
}
