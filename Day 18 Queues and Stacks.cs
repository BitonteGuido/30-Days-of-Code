class Solution {
    Stack<char> stack;
    Queue<char> queue;

    public Solution()
    {
        stack = new Stack<char>();
        queue = new Queue<char>();
    }

    char popCharacter()
    {
        return stack.Pop();
    }

    void pushCharacter(char c)
    {
        stack.Push(c);
    }

    char dequeueCharacter()
    {
        return queue.Dequeue();
    }

    void enqueueCharacter(char c)
    {
        queue.Enqueue(c);
    }
}