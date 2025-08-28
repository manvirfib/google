public class EvalRPNSolution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        HashSet<string> set = new HashSet<string>();
        set.Add("+");
        set.Add("-");
        set.Add("*");
        set.Add("/");
        foreach(var token in tokens){
            if(set.Contains(token)){
                int num2 = stack.Pop();
                int num1 = stack.Pop();
                switch(token){
                    case "*": stack.Push(num1 * num2);
                    break;
                    case "/": stack.Push(num1 / num2);
                    break;
                    case "+": stack.Push(num1 + num2);
                    break;
                    case "-": stack.Push(num1 - num2);
                    break;
                    default: stack.Push(0);
                    break;
                }
            }
            else{
                stack.Push(int.Parse(token));
            }
        }

        return stack.Pop();
    }
}
