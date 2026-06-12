public class MyHashMap {
    private const int bucketCount = 1009;
    private List<Entry>[] buckets;

    public MyHashMap()
    {
        buckets = new List<Entry>[bucketCount];

        for (int i = 0; i < bucketCount; i++)
        {
            buckets[i] = new List<Entry>();
        }
    }

    public void Put(int key, int value)
    {
        int index = Hash(key);

        foreach (var entry in buckets[index])
        {
            if (entry.Key == key)
            {
                entry.Value = value;
                return;
            }
        }

        buckets[index].Add(new Entry(key, value));
    }

    public int Get(int key)
    {
        int index = Hash(key);

        foreach (var entry in buckets[index])
        {
            if (entry.Key == key)
            {
                return entry.Value;
            }
        }

        return -1;
    }

    public void Remove(int key)
    {
        int index = Hash(key);

        for (int i = 0; i < buckets[index].Count; i++)
        {
            if (buckets[index][i].Key == key)
            {
                buckets[index].RemoveAt(i);
                return;
            }
        }
    }

    private int Hash(int key)
    {
        return key % bucketCount;
    }

    private class Entry
    {
        public int Key;
        public int Value;

        public Entry(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */