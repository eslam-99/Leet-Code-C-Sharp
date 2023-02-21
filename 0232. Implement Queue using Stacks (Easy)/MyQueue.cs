public class MyQueue
{
    Stack<int> s1, s2;
    bool isS1;

    public MyQueue()
    {
        s1 = new();
        s2 = new();
        isS1 = true;
    }

    public void Push(int x)
    {
        if(isS1)
        {
            while (s1.Count > 0) s2.Push(s1.Pop());
            s1.Push(x);
            while (s2.Count > 0) s1.Push(s2.Pop());
        }
        else
        {
            while (s2.Count > 0) s1.Push(s2.Pop());
            s2.Push(x);
            while (s1.Count > 0) s2.Push(s1.Pop());
        }
    }

    public int Pop()
    {
        return isS1 ? s1.Pop() : s2.Pop();
    }

    public int Peek()
    {
        return isS1 ? s1.Peek() : s2.Peek();
    }

    public bool Empty()
    {
        return isS1 ? s1.Count == 0 : s2.Count == 0;
    }
}