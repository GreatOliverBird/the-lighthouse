namespace LightHouse.Core.Models;

public class MockNetworkService : INetworkService
{
    public Task<List<Network>> GetNetworksAsync()
    {
        var networks = new List<Network>
        {
            new()
            {
                Name = "Ethereum",
                Symbol = "ETH",
                LogoUrl = "/Pictures/Networks/ethereum.png",
                Status = NetworkStatus.Healthy,
                GasFee = 2.31m,
                GasUnit = "Gwei",
                TransactionsPerSecond = 15,
                Congestion = CongestionLevel.Low,
                FinalitySeconds = 12,
                LastUpdated = DateTime.UtcNow
            },

            new()
            {
                Name = "Base",
                Symbol = "ETH",
                LogoUrl = "/Pictures/Networks/base.png",
                Status = NetworkStatus.Healthy,
                GasFee = 0.05m,
                GasUnit = "Gwei",
                TransactionsPerSecond = 180,
                Congestion = CongestionLevel.Low,
                FinalitySeconds = 2,
                LastUpdated = DateTime.UtcNow
            },

            new()
            {
                Name = "Arbitrum",
                Symbol = "ETH",
                LogoUrl = "/Pictures/Networks/arbitrum.png",
                Status = NetworkStatus.Healthy,
                GasFee = 0.08m,
                GasUnit = "Gwei",
                TransactionsPerSecond = 150,
                Congestion = CongestionLevel.Low,
                FinalitySeconds = 2,
                LastUpdated = DateTime.UtcNow
            },

            new()
            {
                Name = "Polygon",
                Symbol = "POL",
                LogoUrl = "/Pictures/Networks/polygon.png",
                Status = NetworkStatus.Healthy,
                GasFee = 35m,
                GasUnit = "Gwei",
                TransactionsPerSecond = 250,
                Congestion = CongestionLevel.Medium,
                FinalitySeconds = 2,
                LastUpdated = DateTime.UtcNow
            },

            new()
            {
                Name = "Solana",
                Symbol = "SOL",
                LogoUrl = "/Pictures/Networks/solana.png",
                Status = NetworkStatus.Healthy,
                GasFee = 0.00001m,
                GasUnit = "SOL",
                TransactionsPerSecond = 3000,
                Congestion = CongestionLevel.Low,
                FinalitySeconds = 1,
                LastUpdated = DateTime.UtcNow
            }
        };

        return Task.FromResult(networks);
    }
}