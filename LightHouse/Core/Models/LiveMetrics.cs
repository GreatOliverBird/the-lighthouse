namespace LightHouse.Core.Models;

public class LiveMetrics
{
    public decimal GasFee { get; set; }

    public string GasUnit { get; set; } = "Gwei";

    public int LatestBlock { get; set; }

    public int TransactionsPerSecond { get; set; }

    public double AverageBlockTime { get; set; }

    public double NodeLatency { get; set; }

    public DateTime LastUpdated { get; set; }
}