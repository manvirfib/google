using System.Text;
public class LetterCombinationsProblem
{
    void dfs(int cur, Dictionary<int, List<char>> dict, string digits, List<string> result, StringBuilder sb)
    {
        if (cur == digits.Length)
        {
            result.Add(sb.ToString());
            return;
        }
        int digit = digits[cur] - '0';
        var refList = dict[digit];
        for (int i = 0; i < refList.Count; i++)
        {
            sb.Append(refList[i]);
            dfs(cur + 1, dict, digits, result, sb);
            sb.Length--;
        }
    }
    public List<string> LetterCombinations(string digits)
    {
        if (digits.Length == 0)
            return new List<string>();
        Dictionary<int, List<char>> dict = new Dictionary<int, List<char>>();
        List<string> result = new List<string>();

        dict[2] = new List<char>() { 'a', 'b', 'c' };
        dict[3] = new List<char>() { 'd', 'e', 'f' };
        dict[4] = new List<char>() { 'g', 'h', 'i' };
        dict[5] = new List<char>() { 'j', 'k', 'l' };
        dict[6] = new List<char>() { 'm', 'n', 'o' };
        dict[7] = new List<char>() { 'p', 'q', 'r', 's' };
        dict[8] = new List<char>() { 't', 'u', 'v' };
        dict[9] = new List<char>() { 'w', 'x', 'y', 'z' };

        dfs(0, dict, digits, result, new StringBuilder());

        return result;
    }
}
