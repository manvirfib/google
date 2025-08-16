namespace HelloWorld
{
    public class Element
    {
        public decimal profit { get; set; }
        public int weight { get; set; }
    }

    public class KnapSack
    {
        Element[] arr;
        int weight;
        public KnapSack(Element[] arr, int totalWeight)
        {
            this.arr = arr;
            weight = totalWeight;
        }

        public decimal CalculateProfit()
        {
            decimal profit = 0;

            Array.Sort(arr, (obj1, obj2) =>
            {
                decimal r1 = (decimal)obj1.profit / obj1.weight;
                decimal r2 = (decimal)obj2.profit / obj2.weight;

                return r2.CompareTo(r1);
            });

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].weight <= weight)
                {
                    weight -= arr[i].weight;
                    profit += arr[i].profit;
                }
                else
                {
                    profit += ((decimal)weight / arr[i].weight) * arr[i].profit;
                    weight = 0;

                    break;
                }
            }

            return profit;
        }
    }
}