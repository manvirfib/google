class BitCheck
{
    public bool IsSetBit(int num, int i)
    {
        return ((num >> i) & 1) != 0;
    }
}
// num >> i states you are left shifting num i times.
// Clear the ith bit: num & ~(1 << i)
// toggle ith bit: num ^ (1 << i)
// Remove the last bit: n & (n - 1)