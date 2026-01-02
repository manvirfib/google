using System.Text;
public class MultiplySolution {
    public string Multiply(string num1, string num2) {
        if(num1 == "0" || num2 == "0") return "0";

        int n1 = num1.Length;
        int n2 = num2.Length;
        num1 = new string(num1.Reverse().ToArray());
        num2 = new string(num2.Reverse().ToArray());
        int[] res = new int[n1 + n2];

        for(int i = 0; i < n1; i++){
            for(int j = 0; j < n2; j++){
                int temp = (num1[i] - '0') * (num2[j] - '0') + res[i + j];
                res[i + j] = temp % 10;
                res[i + j + 1] = res[i + j + 1] + (temp / 10);
            }
        }

        Array.Reverse(res);
        StringBuilder sb = new();
        int k = 0;
        while(res[k] == 0) k++;
        while(k < res.Length){
            sb.Append(res[k]);
            k++;
        }
        return sb.ToString();
    }
}