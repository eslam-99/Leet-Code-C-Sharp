internal class Program
{
    private static void Main(string[] args)
    {
        MyStack obj = new MyStack();
        obj.Push(4);
        int param_2 = obj.Pop();
        int param_3 = obj.Top();
        bool param_4 = obj.Empty();
    }
}
