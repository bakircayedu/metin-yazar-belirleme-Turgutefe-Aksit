using System;
using System.Collections.Generic;
using System.Text;

namespace Metin_Isleme
{
    public class MyLinkedList : LinkedListADT
    {
        //Sentence Insert
        public override void Insert(Node value)
        {
            var current = Head;
            //Node newNode = new Node(value);
            if (Head == null)
            {
                Head = value;
                Size++;
                return;
            }
            else
            {
                //Head.Next = value;
                //Head = value;
                value.Next = Head;
                Head = value;

            }
            //newNode.Next = Head;
            //Head = newNode;
            Size++;
        }

        //Unique Kelimeleri Insert için
        public override void Insert(string value)
        {
            var current = Head;
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
                Size++;
                return;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
                //Head.Next = newNode;
                //Head = newNode;
            }
            //newNode.Next = Head;
            //Head = newNode;
            Size++;
        }


        //Kelime insert etmek için
        public override void Insert(int which_word, int which_sentence,string value)
        {
            var current = Head;
            Node newNode = new Node(which_word, which_sentence, value);
            if (Head == null)
            {
                Head = newNode;
                Size++;
                return;
            }
            //else
            //{
            //    Head.Next = newNode;
            //    Head = newNode;

            //}
            newNode.Next = Head;
            Head = newNode;
            Size++;
        }
        public override Node Delete()
        {
            if (Head == null) throw new Exception("Silinecek veri bulunamadi...");
            if (Head.Value == null) throw new ArgumentNullException();
            var deleteValue = Head;
            Head = Head.Next;
            return deleteValue;

        }
        public override List<Node> DisplayElements()
        {
            var clone = new List<Node>();
            var temp = Head;
            while (temp != null)
            {
                clone.Add(temp);
                temp = temp.Next;

            }
            return clone; 
        }


        



        public void InsertLast(string value)
        {
            Node NewLast = new Node(value);
            Node OldLast = new Node(null);
            if (Head == null)
            {
                Head = NewLast;
                return;
            }

            OldLast = Head;
            while (OldLast.Next != null)
            {
                OldLast = OldLast.Next;
            }

            OldLast.Next = NewLast; 

        }
        

    }
}
