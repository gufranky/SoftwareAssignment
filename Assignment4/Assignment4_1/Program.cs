namespace Assignment4_1
{
    public class Node<T>
    {
        public Node<T> next { get; set; }
        public T data { get; set; }
        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }
    }
    public class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public void GenericList()
        {
            head = tail = null;

        }
        public Node<T> Head
        {
            get { return head; }
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.next = n;
                tail = n;
            }
        }
        //定义一个foreach方法
        public void Foreach(Action<T>action)
            {
            if (action == null)
            {
                throw new ArgumentNullException();
            }
            Node<T> n = head;
            while (n != null)
            {
                action(n.data);
                n = n.next;
            }
        }
        
    }
    


    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            for (int x = 0; x < 10; x++)
            {
                list.Add(x);
            }
            list.Foreach((int x) => Console.WriteLine(x));
            //求最大值
            int Max = int.MinValue;
            list.Foreach((int x) => { if (x > Max) Max = x; });
            int Min = int.MaxValue;
            list.Foreach((int x) => { if (x < Min) Min = x; });
            int sum = 0;
            list.Foreach((int x) => sum += x);
            Console.WriteLine("Max:" + Max);
            Console.WriteLine("Min:" + Min);
            Console.WriteLine("Sum:" + sum);
        }
    }
}