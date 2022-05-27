using System;
using System.Collections.Generic;
using System.Text;

namespace Metin_Isleme
{
    public class HashTable
    {
        public MyLinkedList[] Table { get; set; }
        public int Size { get; set; }

        public HashTable(int size)
        {
            Table = new MyLinkedList[size];
            this.Size = size;
            //EmptyTable(size);
            for (int i = 0; i < Table.Length; i++)
            {
                Table[i] = new MyLinkedList(); 
            }
        }

        //private void EmptyTable(int size)
        //{
        //    for (int i = 0; i < size; i++)
        //    {
        //        HashNode temp = new HashNode(null,false); 
        //        Table[i] = temp; 
        //    }
        //}


        //string değeri ascıı değerine göre hashler
        public int Hashing(string value)
        {
            int hashedValue = 0;
            foreach (var item in value)
            {
                hashedValue += item;
            }

            return hashedValue % Size;
            
        }

        public void InsertHashedValue(string value)
        {
            int Index = Hashing(value);
            Table[Index].InsertLast(value);


        }

    }
}
