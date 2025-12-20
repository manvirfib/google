public class LemonadeChangeSolution {
    public bool LemonadeChange(int[] bills) {
        int a5 = 0;
        int a10 = 0;
        int a20 = 0;

        foreach(var bill in bills){
            if(bill == 5){
                a5++;
            }
            else if(bill == 10){
                if(a5 == 0) return false;
                a10++;
                a5--;
            }
            else{
                if(a10 > 0 && a5 > 0){
                    a10--;
                    a5--;
                    a20++;
                }
                else if(a5 > 2){
                    a5 = a5 - 3;
                }
                else{
                    return false;
                }
            }
        }

        return true;
    }
}