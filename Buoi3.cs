public class Node
{
    public Node next;
    public object data;
}
public class MyStack
{
    Node top;
    public bool IsEmpty()
    {
        return top == null;
    }
    public void Push(object ele)
    {
        Node n = new Node();
        n.data = ele;
        n.next = top;
        top = n;
    }
    public Node Pop()
    {
        if (top == null)
            return null;
        Node d = top;
        top = top.next;
        return d;
    }
    public int Sum(){
        int sum = 0;
        MyStack temp = new MyStack();
        while(!this.IsEmpty()){
            object n = this.Pop().data;
            temp.Push(n);
            sum += (int)n;
        }
        while(!temp.IsEmpty()){
            object n = temp.Pop().data;
            this.Push(n);
        }
        return sum;
    }
    public void Swap(int i, int j){//chỉ số tính từ top
        int t = Math.Max(i, j);
        List<int> list = new List<int>();
        int count = 0;
        while(count<=t){
            int d  = (int)this.Pop().data;
            count++;
            list.Add(d);
        }
        for(int k = 0; k<list.Count; k++){
            if(k==0)
                this.Push(list[list.Count-1]);
            else if (k==list.Count-1)
                this.Push(list[0]);
            else
                this.Push(list[k]);
        }
    }
    //Bổ sung hàm sắp xếp lại stack theo thứ tự tăng dần: return
    public void SortStack()
    {
    MyStack list = new MyStack();
    while (!this.IsEmpty())
    {
        int numc = (int)this.Pop().data;
        while (!list.IsEmpty() && (int)list.Peek().data > numc)
        {
            this.Push(list.Pop().data);
        }
        list.Push(numc);
    }
    while (!list.IsEmpty())
    {
        this.Push(list.Pop().data);
    }
    //Bổ sung hàm đảo ngược stack: return
     public void ReverseStack()
     {
     MyStack list = new MyStack();

     while (!this.IsEmpty())
     {
         list.Push(this.Pop().data);
     }

     this.top = list.top;
     }
}

public class Node2
{
    public Node2 prev, next;
    public object data;
}
public class MyQueue
{
    Node2 rear, front; public bool IsEmpty()
    {
        return rear == null || front == null;
    }
    public void Enqueue(object ele)
    {
        Node2 n = new Node2();
        n.data = ele;
        if (rear == null)
        {
            rear = n; front = n;
        }
        else
        {
            rear.prev = n;
            n.next = rear; rear = n;
        }
    }
    public Node2 Dequeue()
    {
        if (front == null) return null;
        Node2 d = front;
        front = front.prev;
        if (front == null)
            rear = null;
        else
            front.next = null;
        return d;
    }
    public int Sum(){
        int sum = 0;
        MyQueue temp = new MyQueue();
        while(!this.IsEmpty()){
            int n = (int)this.Dequeue().data;
            temp.Enqueue(n);
            sum += n;
        }
        while(!temp.IsEmpty())
            this.Enqueue((int)temp.Dequeue().data);
        return sum;
    }
    //Bổ sung hàm swap để hoán đổi 2 phần tử trong queue
    public void Swap(int i, int j)
    {
        List<object> list = new List<object>();
        while (!this.IsEmpty())
        {
            list.Add(this.Dequeue().data);
        }

        object temp = list[i];
        list[i] = list[j];
        list[j] = temp;

        foreach (var item in list)
        {
            this.Enqueue(item);
        }
    }
    //Bổ sung hàm sắp xếp lại queue theo thứ tự tăng dần: return
    public void SortQueue()
    {
        List<int> list = new List<int>();
        while (!this.IsEmpty())
        {
            list.Add((int)this.Dequeue().data);
        }

        list.Sort();

        foreach (var item in list)
        {
            this.Enqueue(item);
        }
    }
    //Bổ sung hàm đảo ngược queue: return
     public void ReverseQueue()
    {
        Stack<object> stack = new Stack<object>();
        while (!this.IsEmpty())
        {
            stack.Push(this.Dequeue().data);
        }

        while (stack.Count > 0)
        {
            this.Enqueue(stack.Pop());
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        /*MyStack stack = new MyStack();
        System.Console.WriteLine(stack.IsEmpty());
        stack.Push(1);
        System.Console.WriteLine(stack.IsEmpty());
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
        ;
        stack.Swap(2, 4);
        ;*/
        /*System.Console.WriteLine(stack.IsEmpty());
        System.Console.WriteLine("Sum: " + stack.Sum());
        System.Console.WriteLine(stack.IsEmpty());*/

        MyQueue queue = new MyQueue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        ;
        System.Console.WriteLine(queue.Sum());
        ;
    }
}
