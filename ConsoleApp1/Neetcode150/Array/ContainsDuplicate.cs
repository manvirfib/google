public class Duplicate {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> hs = new HashSet<int>();
        foreach(int i in nums){
            if(!hs.Add(i)){
                return true;
            }
        }

        return false;
    }
}