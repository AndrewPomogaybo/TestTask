using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertList
{
    public class ListCommands
    {
        private Node _head;
        private Node _tail;

        public ListCommands()
        {
            _head = null;
            _tail = null;
        }

        public void Insert(Node x)
        {
            if (x == null)
                return;

            if (IsEmpty())
                _head = _tail = x;
            else
            {
                x.Next = _head;
                _head.Prev = x;
                _head = x;
            }
        }


        private bool IsEmpty()
        {
            return _head == null;
        }

        public Node GetHead()
        {
            return _head;
        }
    }

}
