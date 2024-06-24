using System;

namespace InsertList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListCommands _listCommands = new ListCommands();

            Node _newNode = new Node(10);

            _listCommands.Insert(_newNode);
            DisplayCommands.Display(_listCommands.GetHead());

            _listCommands.Insert(new Node(20));

            DisplayCommands.Display(_listCommands.GetHead());

            Console.ReadKey();
        }
    }
}
