using System.Collections.Specialized;

public class Node
{
    public object element;
    public Node link;
    public Node()
    {
        element = null;
        link = null;
    }
    public Node(object element)
    {
        this.element = element;
        link = null;
    }
}
public class LinkedList
{
    public Node header;
    public LinkedList()
    {
        header = new Node("Header");
    }
    private Node Find(object element)
    {
        Node current = new Node();
        current = header;
        while (current.element != element)
            current = current.link;
        return current;
    }
    public void Insert(object newelement, object afterelement)
    {
        Node current = new Node();
        Node newnode = new Node(newelement);
        current = Find(afterelement);
        newnode.link = current.link;
        current.link = newnode;
    }
    public Node FindPrev(object element)
    {
        Node current = header;
        while (current.link != null && current.link.element != element)
            current = current.link;
        return current;
    }
    public void Remove(object element)
    {
        Node current = FindPrev(element);
        if (current.link != null)
            current.link = current.link.link;
    }
    public void Print()
    {
        Node current = new Node();
        current = header;
        while (current.link != null)
        {
            Console.WriteLine(current.link.element);
            current = current.link;
        }
    }
    public int FindMax()
    {
        Node current = header.link;
        int max = int.Parse(current.element.ToString());
        while (current.link != null)
        {
            current = current.link;
            int value = int.Parse(current.element.ToString());
            if (value > max) max = value;
        } 
        return max;
    }
    public int Sum()
    {
        int sum = 0;
        Node current = header.link;
        while (current != null)
        {
            sum += int.Parse(current.element.ToString());
            current = current.link; 
        }
        return sum;
    }
    public int Sum2()
    {
        Node current = header.link;
        int sum = int.Parse(current.element.ToString());
        while (current.link != null)
        {
            current = current.link;
            sum += int.Parse(current.element.ToString());
        }
        return sum;
    }
    public int Count()
    {
        int count = 0;
        Node current = header.link;
        while (current != null)
        {
            count++;
            current = current.link;
        }
        return count;
    }
}
// bổ sung thêm danh sách liên kết kép và thêm cá hàm giống danh sách liên kết đơn
public class Node2
{
    public object element;
    public Node2 prev;
    public Node2 next;

    public Node2()
    {
        element = null;
        prev = null;
        next = null;
    }

    public Node2(object element)
    {
        this.element = element;
        prev = null;
        next = null;
    }
}
public class DoublyLinkedList
{
    public Node2 header;

    public DoublyLinkedList()
    {
        header = new Node2("Header");
    }

    private Node2 Find(object element)
    {
        Node2 current = header;
        while (current != null && current.element != element)
            current = current.next;
        return current;
    }

    public void Insert(object newElement, object afterElement)
    {
        Node2 newNode = new Node2(newElement);
        Node2 current = Find(afterElement);

        if (current != null)
        {
            newNode.next = current.next;
            newNode.prev = current;
            if (current.next != null)
                current.next.prev = newNode;
            current.next = newNode;
        }
    }

    public void Remove(object element)
    {
        Node2 current = Find(element);

        if (current != null)
        {
            if (current.prev != null)
                current.prev.next = current.next;
            if (current.next != null)
                current.next.prev = current.prev;
        }
    }

    public void Print()
    {
        Node2 current = header.next;
        while (current != null)
        {
            Console.WriteLine(current.element);
            current = current.next;
        }
    }

    public int FindMax()
    {
        Node2 current = header.next;
        int max = int.Parse(current.element.ToString());
        while (current != null)
        {
            int value = int.Parse(current.element.ToString());
            if (value > max)
                max = value;
            current = current.next;
        }
        return max;
    }

    public int Sum()
    {
        int sum = 0;
        Node2 current = header.next;
        while (current != null)
        {
            sum += int.Parse(current.element.ToString());
            current = current.next;
        }
        return sum;
    }

    public int Count()
    {
        int count = 0;
        Node2 current = header.next;
        while (current != null)
        {
            count++;
            current = current.next;
        }
        return count;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        LinkedList list = new LinkedList();
        //list.Insert("First", "Header");
        //list.Insert("Second", "First");
        //list.Insert("Third", "Second");
        //list.Print();
        //Console.WriteLine("===");
        //list.Remove("Second");
        //list.Print();
        list.Insert("1", "Header");
        list.Insert("20", "1");
        list.Insert("3", "20");
        list.Insert("9", "3");
        list.Insert("5", "9");
        list.Insert("27", "5");
        list.Insert("7", "27");
        list.Print();
        Console.WriteLine("Max: " + list.Count());

        DoublyLinkedList doubleList = new DoublyLinkedList();
        doubleList.Insert("1", "Header");
        doubleList.Insert("20", "1");
        doubleList.Insert("3", "20");
        doubleList.Insert("9", "3");
        doubleList.Insert("5", "9");
        doubleList.Insert("27", "5");
        doubleList.Insert("7", "27");

        doubleList.Print();
        Console.WriteLine("Max: " + doubleList.FindMax());
        Console.WriteLine("Sum: " + doubleList.Sum());
        Console.WriteLine("Count: " + doubleList.Count());
    }
}
