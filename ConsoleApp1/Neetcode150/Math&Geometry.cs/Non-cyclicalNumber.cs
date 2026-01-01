public class IsHappySolution {
    int GetNum(int n){
        int sum = 0;
        while(n != 0){
            sum += (n % 10) * (n % 10);
            n = n / 10;
        }
        return sum;
    }
    public bool IsHappy(int n) {
        HashSet<int> hset = new();

        while(n != 1){
            if(hset.Contains(n)) return false;
            hset.Add(n);
            n = GetNum(n);
        }

        return true;
    }
}
