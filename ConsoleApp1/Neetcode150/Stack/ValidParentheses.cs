public class ValidParentheses {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        foreach(var c in s){
            switch(c){
                case '{':
                case '(':
                case '[': stack.Push(c);
                        break;
                case ')': if(stack.Count <= 0 || stack.Pop() != '(') return false;
                            break;
                case '}': if(stack.Count <= 0 || stack.Pop() != '{') return false;
                            break;
                case ']': if(stack.Count <= 0 || stack.Pop() != '[') return false;
                            break;
                default: return false;
            }
        }

        return stack.Count == 0;
    }
}
