using System;
using System.Collections.Generic;
using System.Text;

namespace Metin_Isleme
{
    public class Stack 
    {
        MyLinkedList myLinkedList= new MyLinkedList();

        public Node Head => myLinkedList.Head;
        public int Count { get; set; }

        //Cümle Pushlamak için
        public void Push(Node value)
        {
            myLinkedList.Insert(value);
            Count = myLinkedList.Size;
        }

        //Kelime Pushlamak için
        public void Push(int word,int sentence,string value)
        {
            myLinkedList.Insert(value);
            Count = myLinkedList.Size;
        }


        public Node Pop()
        {
            return myLinkedList.Delete();
            Count = myLinkedList.Size;
        }

        public List<Node> DispElement()
        {
            return myLinkedList.DisplayElements();
        }


        internal void Push(string[] vs)
        {
            throw new NotImplementedException();
        }
    }
}
