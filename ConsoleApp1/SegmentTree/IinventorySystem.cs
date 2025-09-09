namespace SegmentTree
{
    interface IinventorySystem
    {
        void AddSupply(int bucket, float delta);
        void AddDemand(int bucket, float delta);
        float GetInventory(int bucket);
    }
}
