public static class ComplexStack
{

    
    public static bool DoSomethingComplicated(string line)
    {
        var stack = new Stack<char>();
        foreach (var item in line)
        {
            if (item is '(' or '[' or '{')
            {
                stack.Push(item);
            }
            else if (item is ')')
            {
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
            }
            else if (item is ']')
            {
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }
            else if (item is '}')
            {
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }

        return stack.Count == 0;
    }
}

// The code is not going to do anhything. Since the function is check the data type
// of boolean, array and object. But since the length is == 0 and the data is is popped out
// there is nothing to return.