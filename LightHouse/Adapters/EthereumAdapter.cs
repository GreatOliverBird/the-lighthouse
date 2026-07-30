using LightHouse.Core.Models;
using LightHouse.Core.Interfaces;

namespace LightHouse.Adapters;

public class EthereumAdapter : IBlockchainAdapter
{
    public string Name { get; } = "Ethereum";

    public Task<NetworkSnapshot> GetSnapshotAsync()
    {
        // Placeholder until live RPC wiring is ready.
        var snapshot = new NetworkSnapshot
        {
            Info = new NetworkInfo
            {
                Name = Name,
                Symbol = "ETH",
                ChainId = 1,
                IsEvm = true
            },
            Live = new LiveMetrics
            {
                LastUpdated = DateTime.UtcNow
            },
            Analytics = new AnalyticsMetrics
            {
                Status = NetworkStatus.Healthy,
                Congestion = CongestionLevel.Low
            }
        };

        return Task.FromResult(snapshot);
    }
}
