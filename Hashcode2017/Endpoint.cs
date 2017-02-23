namespace Hashcode2017
{
    class Endpoint
    {
        public int DataCenterLatency;
        public int[] CacheLatencies { get; }

        public Endpoint(int caches) { CacheLatencies = new int[caches]; }
    }
}
