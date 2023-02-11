public class MyStack
{
    Queue<int> queue;

    public MyStack()
    {
        queue = new Queue<int>();
    }

    public void Push(int x)
    {
        int c = queue.Count;
        queue.Enqueue(x);
        while (c-- > 0) queue.Enqueue(queue.Dequeue());
    }

    public int Pop()
    {
        return queue.Dequeue();
    }

    public int Top()
    {
        return queue.Peek();
    }

    public bool Empty()
    {
        return queue.Count == 0;
    }
}