class PowerOf2
{
    public bool Power2(int num)
    {
        return (num & (num - 1)) == 0;
    }
}
// Every number which is a power of 2 has only 1 set bit, example
// 2 - 10 {Binary}
// 4 - 100 {Binary}
// 8 - 1000 {Binary}

// 5 - 110 {binary} :: Not power of 2 because of 2 set bits

// Hence if we remove the last set bit of a number, we can say whether that is a power of 2 or not