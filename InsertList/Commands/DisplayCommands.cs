using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertList
{
    public class DisplayCommands
    {
        
        public static void Display(Node head)
        {
            Node _current = head;
            while (_current != null)
            {
                Console.WriteLine(_current.Key + "");
                _current = _current.Next;
            }
            Console.WriteLine();
        }
    }
}
