public class KokoEatingBananas {
    public int MinEatingSpeed(int[] piles, int h) {
        int maxValue = 0, minHours = int.MaxValue;
        foreach(var pile in piles){
            maxValue = Math.Max(pile, maxValue);
        }
        int i = 1, j = maxValue;
        while(i <= j){
            int mid = (i + j)/2;
            int CurTotalHours = 0;
            foreach(var pile in piles){
                CurTotalHours += (int)Math.Ceiling((double)pile/mid);
            }
            if(CurTotalHours <= h){
                minHours = Math.Min(minHours, mid);
                j = mid - 1;
            }
            else{
                i = mid + 1;
            }
        }

        return minHours;
    }
}
