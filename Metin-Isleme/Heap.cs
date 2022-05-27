using System;
using System.Collections.Generic;
using System.Text;

namespace Metin_Isleme
{
    class Heap
    {
            // ders notları
            //Kelime sayısına göre heap ağacına atılacak şekilde kodu düzenledim
            private int currentSize;
            private int maxSize;
            public HeapNode[] heapArray;
            
            
            public Heap(int _maxSize)
            {
                currentSize = 0;
                maxSize = _maxSize;
                heapArray = new HeapNode[maxSize];
                for (int i = 0; i < heapArray.Length; i++)
                {
                    heapArray[i] = new HeapNode(null);
                }
            }

            public bool Insert(Node value)
            {
                if (currentSize == maxSize)
                {
                    return false;
                }

                HeapNode newHeap = new HeapNode(value);
                heapArray[currentSize] = newHeap;
                MoveToUp(currentSize++);
                return true;
            }

            private void MoveToUp(int index)
            {
                int parent = GetParent(index);
                HeapNode bottom = heapArray[index];

                while (index > 0 && bottom.Data.frekans > heapArray[parent].Data.frekans)
                {
                    heapArray[index] = heapArray[parent];
                    index = parent;
                    parent = GetParent(parent);
                }

                heapArray[index] = bottom;
            }

            public HeapNode RemoveMax()
            {
                HeapNode value = heapArray[0];
                heapArray[0] = heapArray[--currentSize];
                MoveToDown(0);
                return value;
            }

            private void MoveToDown(int index)
            {
                int largerChild;
                HeapNode top = heapArray[index];

                while (index < currentSize / 2)
                {
                    int leftChild = GetLeftChild(index);
                    int rightChild = GetRightChild(index);

                    if (rightChild < currentSize && heapArray[leftChild].Data.frekans < heapArray[rightChild].Data.frekans)
                    {
                        largerChild = rightChild;
                    }
                    else
                    {
                        largerChild = leftChild;
                    }

                    if (top.Data.frekans >= heapArray[largerChild].Data.frekans)
                    {
                        break;
                    }

                    heapArray[index] = heapArray[largerChild];
                    index = largerChild;
                }

                heapArray[index] = top;
            }
            
            //Heaptan verileri çıkarırken sıralı bir şekilde çıkmasını sağlar.
            public HeapNode[] Sort()
            {
                Heap copy = new Heap(heapArray.Length);
                HeapNode[] sorted = new HeapNode[heapArray.Length];

                for (int i = 0; i < heapArray.Length; i++)
                {
                    copy.Insert(heapArray[i].Data);
                }



                int j = 0;
                //for (int i = 0; i < heapArray.Length; i++)
                //{
                //    sorted[j++] = copy.RemoveMax();
                //}
                while (!copy.IsEmpty())
                {
                    sorted[j++] = copy.RemoveMax();
                }
                return sorted;
            }

        private bool IsEmpty()
        {
            if (currentSize == 0)
            {
                return true;
            }
            return false;
        }



        private int GetParent(int index) => (index - 1) / 2;
            private int GetLeftChild(int index) => 2 * index + 1;
            private int GetRightChild(int index) => 2 * index + 2;
    }
}
