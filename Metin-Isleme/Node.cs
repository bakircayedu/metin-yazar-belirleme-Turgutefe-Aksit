using System;
using System.Collections.Generic;
using System.Text;

namespace Metin_Isleme
{
    public class Node : WordFunctions
    {
        public string Value { get; set; }
        public Node Next { get; set; }
        public Node(string value)
        {
            Value = value;
        }

        //Sentence
        public int WordQuantity { get; set; }
        

        //Word
        public int Which_sentence { get; set; }
        public int Which_word { get; set; }
        public string Processed_word { get; set; }

        public Node(int which_word, int which_sentence, string processed_word)
        {
            this.Which_word = which_word;
            this.Which_sentence = which_sentence;
            this.Processed_word = WordProcess(processed_word);
        }

        //UniqueWord
        public int frekans = 1;

        //HashNode

    }

}

