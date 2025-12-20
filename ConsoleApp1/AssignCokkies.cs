public class FindContentChildrenSolution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        int n1 = g.Length, i = 0;
        int n2 = s.Length, j = 0;

        while(i < n1 && j < n2){
            if(s[j] >= g[i]) i++;
            j++;
        }

        return i;
    }
}