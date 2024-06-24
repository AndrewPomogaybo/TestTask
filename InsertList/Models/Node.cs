using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertList
{
    public class Node
    {
        public int Key { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }

        public Node(int key) 
        {
            Key = key;
            Next = null;
            Prev = null;
        }
    }

}
