using System;
using System.Collections.Generic;
using System.Text;

namespace Metin_Isleme
{
    public class WordFunctions
    {
        //Kelimeyi eklerden arındırır
        public string WordProcess(string value)
        {
            string newWord = "";
            foreach (var item in value)
            {
                if (!Char.IsPunctuation(item))
                {
                    newWord += item;
                }
                else
                {
                    break;
                }
            }
            return newWord;
        }

        //Unique kelimelerin üst üste yazılmasını önler
        public bool DuplicateControl(Stack UniqueStack,string value)
        {   
            foreach (var item in UniqueStack.DispElement())
            {
                
                if (string.Equals(item.Value,value))
                {
                    item.frekans++;
                    return true;
                }
            }
            return false;
        }
    }

    
}
