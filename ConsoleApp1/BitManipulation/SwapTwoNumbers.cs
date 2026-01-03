class SwapNumbers
{
    public void Swap(ref int a, ref int b)
    {
        a = a ^ b;
        b = a ^ b; // since a = a ^ b :: b = a ^ b ^ b :: here b ^ b = 0, hence a remains
        a = a ^ b;
    }
}