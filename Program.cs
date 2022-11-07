using System;

namespace singly_linked_list
{
    //each node consist of the information part and link to the next node
    class Node
    {
        public int rollnumber;
        public string name;
        public Node next;
    }

    class list
    {
        Node START;

        public list()
        {
            START = null;
        }
        public void addNote() // add a node in the list
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll number of the student:");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the roll number of the student:");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollnumber = rollNo;
            newnode.name = nm;
            if (START == null || rollNo <= START.rollnumber)
            {
                if ((START != null) && (rollNo == START.rollnumber))
                {
                    Console.WriteLine();
                    return;
                }
                newnode.next = START;
                START = newnode;
                return;
            }

            Node previous, current;
            previous = START;
            current = START;

            while ((current != null) && (rollNo == current.rollnumber))
            {
                if (rollNo == current.rollnumber)
                {
                    Console.WriteLine();
                    return;
                }
                previous.next = current;
                previous.next = newnode;
            }
            newnode.next = current;
            previous.next = newnode;
        }
        public bool delNode(int rollNo)
        {
            Node previous, current;
            previous = current = null;
            if (Search(rollNo, ref previous, ref current) == false)
                return false;
            previous.next = current.next;
            if (current == START)
                START = START.next;
            return true;
        }
        public bool Search(int rollNO, ref Node previous, ref Node current)
        {
            previous = START;
            current = START;
            while ((current != null)&& (rollNO != current.rollnumber))
            {
                previous = current;
                current = current.next;
            }
            if (current == null)
                return false;
            else
                return true;
        }
        public void Traverse()
        {
            if (listEmpty())
                Console.WriteLine();
            else
            {
                Console.WriteLine();
                Node currentNode;
                for (currentNode = START; currentNode != null; currentNode = currentNode.next)
                    Console.Write(currentNode.rollnumber + " " + currentNode.name + "\n");
                Console.WriteLine();
            }
        }

        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }
    }


    class program
    {
        static void Main(string[] args)
        {
            list obj = new list();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMENU");
                    Console.WriteLine("1. Add a record to the list");
                    Console.WriteLine("2. Delete a record from the list");
                    Console.WriteLine("3. View all the records in the list");
                    Console.WriteLine("4. Search for a record in the list");
                    Console.WriteLine("5. EXIT");
                    Console.Write("\nEnter your choice (1-5) : ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch(ch)
                    {
                        case '1':
                            {
                                obj.addNote();
                            }
                            break;

                        case '2':
                            {
                                if (obj.listEmpty())
                                {
                                    Console.WriteLine("\nList is empty");
                                    break;
                                }
                                Console.WriteLine("Enter the roll number of" + "the student whose record is to be deleted");
                                int rollNo = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (obj.delNode(rollNo) == false)
                                    Console.WriteLine("\n Record not found.");
                                else
                                    Console.WriteLine("\n Record with roll number " + + rollNo + " Deleted");
                            }
                            break;
                        case '3':
                            {
                                obj.Traverse();
                            }
                            break;
                        case '4':
                            {
                                if(obj.listEmpty() == true)
                                {
                                    Console.WriteLine("\nList is empty");
                                    break;
                                }
                                Node previous, current;
                                previous = current = null;
                                Console.Write("\nEnter the roll number of the " + "Student whole record is to be searched: ");
                                if (obj.Search(num, ref previous, ref current) == false)
                                    Console.WriteLine
                            }
                    }
                }
            }    
        }
    }
}
