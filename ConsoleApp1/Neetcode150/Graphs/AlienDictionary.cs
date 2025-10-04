using System.Text;

public class AlienDictionary {
    public string foreignDictionary(string[] words) {
        Dictionary<char, HashSet<char>> adj = new();
        Dictionary<char, int> degree = new();
        StringBuilder sb = new();

        foreach(var word in words){
            foreach(var cr in word){
                if(!adj.ContainsKey(cr)){
                    adj[cr] = new HashSet<char>();
                }
                if(!degree.ContainsKey(cr)){
                    degree[cr] = 0;
                }
            }
        }

        for(int i = 0; i < (words.Length - 1); i++){
            var wd1 = words[i];
            var wd2 = words[i + 1];

            int len = Math.Min(wd1.Length, wd2.Length);
            int j = 0;
            if (wd1.Length > wd2.Length && wd1.StartsWith(wd2)) {
                return "";
            }
            while(j < len){
                if(wd1[j] != wd2[j]){
                    if(adj[wd1[j]].Add(wd2[j]))
                    degree[wd2[j]]++; //increase degree only if new edge.
                    break;
                }
                j++;
            }
        }
        Queue<char> queue = new();

        foreach(var key in adj.Keys){
            if(degree[key] == 0){
                queue.Enqueue(key);
            }
        }

        while(queue.Count > 0){
            var value = queue.Dequeue();
            sb.Append(value);
            foreach(var cr in adj[value]){
                degree[cr]--;
                if(degree[cr] == 0){
                    queue.Enqueue(cr);
                }
            }
        }

        if(sb.Length != degree.Count)
        return "";

        return sb.ToString();
    }
}
