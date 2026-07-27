public class RawNetworkData
{
    public decimal GasPrice { get; set; }

    public long LatestBlock { get; set; }

    public TimeSpan ResponseTime { get; set; }

    public DateTime RetrievedAt { get; set; }
}