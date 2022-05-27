using System;
using System.Collections.Generic;
using System.Text;

namespace Metin_Isleme
{
    public abstract class LinkedListADT
    {
        public Node Head;
        public int Size = 0;
        public abstract void Insert(Node value);
        public abstract void Insert(string value);
        public abstract void Insert(int which_word, int which_sentence, string value);
        public abstract Node Delete();
        public abstract List<Node> DisplayElements();
    }
}
