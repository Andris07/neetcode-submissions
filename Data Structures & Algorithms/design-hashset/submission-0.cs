public class MyHashSet {
    private const int bucketCount = 1009;
    private List<int>[] buckets;

    public MyHashSet()
    {
        buckets = new List<int>[bucketCount];

        for (int i = 0; i < bucketCount; i++)
        {
            buckets[i] = new List<int>();
        }
    }
    
    public void Add(int key) {
        int index = Hash(key);

        if (!buckets[index].Contains(key))
        {
            buckets[index].Add(key);
        }
    }
    
    public void Remove(int key) {
        int index = Hash(key);
        buckets[index].Remove(key);
    }
    
    public bool Contains(int key) {
        int index = Hash(key);
        return buckets[index].Contains(key);
    }

    private int Hash(int key)
    {
        return key % bucketCount;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */