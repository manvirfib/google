using System.Text;

public class EncodeDecode {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(var word in strs){
            sb.Append(word.Length+ "#" +word);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        int i = 0;
        List<string> result = new List<string>();
        while(i < s.Length){
            int j = i;
            while(s[j] != '#') { j++; }
            int num = int.Parse(s.Substring(i, j - i));
            result.Add(s.Substring(j + 1, num));
            i = num + j + 1;
        }

        return result;
   }
}
