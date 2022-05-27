using System;
using System.Collections.Generic;
using System.Text;

namespace Metin_Isleme
{
    // Datasını Node tipinde alsa bile heap üzerinde sıralanması kelime sayısı'na (WordQuantity) göre olacak.
    public class HeapNode
    {
        public Node Data { get; set; }
        public HeapNode(Node data)
        {
            this.Data = data;
        }
    }
}
