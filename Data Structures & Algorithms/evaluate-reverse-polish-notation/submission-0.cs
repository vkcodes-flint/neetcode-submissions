public class Solution {
    public int EvalRPN(string[] tokens) {
        
        Stack<int> stack = new();

        foreach (string token in tokens)
        {
            if (token == "+" ||
                token == "-" ||
                token == "*" ||
                token == "/")
            {
                int b = stack.Pop();
                int a = stack.Pop();

                int result = 0;

                switch (token)
                {
                    case "+":
                        result = a + b;
                        break;

                    case "-":
                        result = a - b;
                        break;

                    case "*":
                        result = a * b;
                        break;

                    case "/":
                        result = a / b;
                        break;
                }

                stack.Push(result);
            }
            else
            {
                stack.Push(int.Parse(token));
            }
        }

        return stack.Pop();
        
    }
}
