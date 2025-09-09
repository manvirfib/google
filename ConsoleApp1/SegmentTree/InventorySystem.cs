namespace SegmentTree
{
    class InventorySystem : IinventorySystem
    {
        float[] seg;
        int size;
        public InventorySystem(int size)
        {
            seg = new float[4 * size];
            this.size = size;
        }

        void Update(int idx, float delta, int start, int end, int bucket)
        {
            if (start == end)
            {
                if (bucket == start)
                {
                    seg[idx] += delta;
                }

                return;
            }

            int mid = start + (end - start) / 2;

            Update(2 * idx + 1, delta, start, mid, bucket);
            Update(2 * idx + 2, delta, mid + 1, end, bucket);

            seg[idx] = seg[2 * idx + 1] + seg[2 * idx + 2];
        }

        float Query(int left, int right, int start, int end, int idx)
        {
            if (left > end || right < start)
                return 0;
            if (left <= start && right >= end)
            {
                return seg[idx];
            }

            int mid = start + (end - start) / 2;

            return Query(left, right, start, mid, 2 * idx + 1) + Query(left, right, mid + 1, end, 2 * idx + 2);
        }

        public void AddDemand(int bucket, float delta)
        {
            Update(0, -delta, 0, size - 1, bucket);
        }

        public void AddSupply(int bucket, float delta)
        {
            Update(0, delta, 0, size - 1, bucket);
        }

        public float GetInventory(int bucket)
        {
            return Query(0, bucket, 0, size - 1, 0);
        }
    }
}