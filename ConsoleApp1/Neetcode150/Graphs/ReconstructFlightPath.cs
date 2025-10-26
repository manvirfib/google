public class FindItinerarySolution {
    public List<string> FindItinerary(List<List<string>> tickets) {
        int req = tickets.Count;
        Dictionary<string, List<(string, bool)>> adj = new();

        foreach(var ticket in tickets){
            if(!adj.ContainsKey(ticket[0])){
                adj[ticket[0]] = new List<(string, bool)>();
            }
            adj[ticket[0]].Add((ticket[1], false));
            if(!adj.ContainsKey(ticket[1])){
                adj[ticket[1]] = new List<(string, bool)>();
            }
        }

        foreach(var key in adj.Keys){
            adj[key].Sort((a, b) => StringComparer.Ordinal.Compare(a.Item1, b.Item1));
        }

        List<string> res = new();
        res.Add("JFK");

        dfs("JFK", adj, res, req + 1);

        return res;
    }
    bool dfs(string node, Dictionary<string, List<(string, bool)>> adj, List<string> res, int req){
        if(res.Count == req) return true;
        var list = adj[node];
        for(int i = 0; i < list.Count; i++){
            if(list[i].Item2) continue;
            list[i] = (list[i].Item1, true);
            res.Add(list[i].Item1);
            if(dfs(list[i].Item1, adj, res, req))
            return true;
            list[i] = (list[i].Item1, false);
            res.RemoveAt(res.Count - 1);
        }
        return false;
    }
}
