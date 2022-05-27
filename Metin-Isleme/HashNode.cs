using System;
using System.Collections.Generic;
using System.Text;

namespace Metin_Isleme
{
    public class HashNode
    {
        public Node Data { get; set; } 
        public HashNode Next { get; set; }

        public bool IsDeleted { get; set; }
        public HashNode(Node data, bool isDeleted)
        {
            this.Next = null;
            this.Data = data;
            this.IsDeleted = isDeleted;
        }
    }
}
