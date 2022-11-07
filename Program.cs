

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
            rollNo = Convert.ToInt32(Console.Readline());
            Console.Write("\nEnter the roll number of the student:");
            nm = Console.Readline();
            Node newnode = new Node();
            newnode.rollnumber = rollNo;
            newnode.name = nm;
            if (START == null || rollNo <= START.rollnumber)
            {
                if ((START != null) && (rollNo == START.rollnumber))
                {
                    Console.Writeline();
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
                    Console.Writeline();
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
    }


    class program
    {
        static void Main(string[] args)
        {

        }
    }
}
