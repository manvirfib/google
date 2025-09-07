//Inventory System
class FenwickTree
{
    int[] nums;
    int[] bit;
    int size;
    public FenwickTree(int len)
    {
        this.size = len + 1;
        bit = new int[size];
    }

    public void Update(int idx, int delta)
    {
        idx++;
        while (idx < size)
        {
            bit[idx] += delta;
            idx += idx & (-idx);
        }
    }

    public void AddSupply(int idx, int delta)
    {
        Update(idx, delta);
    }

    public void AddDemand(int idx, int delta)
    {
        Update(idx, -delta);
    }

    public int Query(int idx)
    {
        int result = 0;
        idx++;
        while (idx > 0)
        {
            result += bit[idx];
            idx -= idx & (-idx);
        }

        return result;
    }
}