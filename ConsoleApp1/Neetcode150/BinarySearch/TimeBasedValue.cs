public class TimeMap {
    Dictionary<string, List<(int, string)>> dict;
    public TimeMap() {
        dict = new Dictionary<string, List<(int, string)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!dict.ContainsKey(key)){
            dict[key] = new List<(int, string)>();
        }
        dict[key].Add((timestamp, value));
    }
    
    public string Get(string key, int timestamp) {
        if(!dict.ContainsKey(key))
        return "";

        var values = dict[key];

        int low = 0;
        int high = values.Count - 1;
        string result = "";

        while(low <= high){
            int mid = low + (high - low)/2;
            if(values[mid].Item1 <= timestamp){
                result = values[mid].Item2;
                low = mid + 1;
            }
            else{
                high = mid - 1;
            }
        }

        return result;
    }
}
