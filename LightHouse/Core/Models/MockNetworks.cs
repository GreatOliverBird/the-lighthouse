namespace LightHouse.Core.Models;

public class MockNetworkService : INetworkService
{
    private static readonly List<Network> Networks =
    [
        new()
        {
            Name = "Ethereum",
            Symbol = "ETH",
            LogoUrl = "/Pictures/Networks/ethereum.svg",
            Description = "The largest smart-contract platform. High security, broad liquidity, and the reference layer for L2 networks.",
            ChainId = 1,
            IsEvm = true,
            ExplorerUrl = "https://etherscan.io",
            Status = NetworkStatus.Healthy,
            GasFee = 2.31m,
            GasUnit = "Gwei",
            TransactionsPerSecond = 15,
            Congestion = CongestionLevel.Low,
            FinalitySeconds = 12,
            ReliabilityScore = 96,
            LastUpdated = DateTime.UtcNow
        },
        new()
        {
            Name = "Base",
            Symbol = "ETH",
            LogoUrl = "/Pictures/Networks/base.svg",
            Description = "An Optimism-based L2 focused on low fees and consumer apps, with strong Coinbase ecosystem support.",
            ChainId = 8453,
            IsEvm = true,
            ExplorerUrl = "https://basescan.org",
            Status = NetworkStatus.Healthy,
            GasFee = 0.05m,
            GasUnit = "Gwei",
            TransactionsPerSecond = 180,
            Congestion = CongestionLevel.Low,
            FinalitySeconds = 2,
            ReliabilityScore = 93,
            LastUpdated = DateTime.UtcNow
        },
        new()
        {
            Name = "Arbitrum",
            Symbol = "ETH",
            LogoUrl = "/Pictures/Networks/arbitrum.svg",
            Description = "A leading optimistic rollup for Ethereum — fast confirmation and deep DeFi activity.",
            ChainId = 42161,
            IsEvm = true,
            ExplorerUrl = "https://arbiscan.io",
            Status = NetworkStatus.Degraded,
            GasFee = 0.18m,
            GasUnit = "Gwei",
            TransactionsPerSecond = 95,
            Congestion = CongestionLevel.High,
            FinalitySeconds = 2,
            ReliabilityScore = 78,
            LastUpdated = DateTime.UtcNow
        },
        new()
        {
            Name = "Polygon",
            Symbol = "POL",
            LogoUrl = "/Pictures/Networks/polygon.svg",
            Description = "A high-throughput EVM sidechain used widely for gaming, NFTs, and payments.",
            ChainId = 137,
            IsEvm = true,
            ExplorerUrl = "https://polygonscan.com",
            Status = NetworkStatus.Maintenance,
            GasFee = 42m,
            GasUnit = "Gwei",
            TransactionsPerSecond = 120,
            Congestion = CongestionLevel.Medium,
            FinalitySeconds = 2,
            ReliabilityScore = 71,
            LastUpdated = DateTime.UtcNow
        },
        new()
        {
            Name = "Solana",
            Symbol = "SOL",
            LogoUrl = "/Pictures/Networks/solana.svg",
            Description = "A high-performance L1 optimized for throughput. Ideal when speed and low fees matter most.",
            ChainId = 101,
            IsEvm = false,
            ExplorerUrl = "https://solscan.io",
            Status = NetworkStatus.Offline,
            GasFee = 0.00001m,
            GasUnit = "SOL",
            TransactionsPerSecond = 0,
            Congestion = CongestionLevel.High,
            FinalitySeconds = 1,
            ReliabilityScore = 40,
            LastUpdated = DateTime.UtcNow
        }
    ];

    public Task<List<Network>> GetNetworksAsync()
        => Task.FromResult(Networks.Select(Clone).ToList());

    public Task<Network?> GetNetworkBySlugAsync(string slug)
    {
        var match = Networks.FirstOrDefault(n =>
            n.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));

        return Task.FromResult(match is null ? null : Clone(match));
    }

    private static Network Clone(Network source) => new()
    {
        Name = source.Name,
        Symbol = source.Symbol,
        LogoUrl = source.LogoUrl,
        Description = source.Description,
        ChainId = source.ChainId,
        IsEvm = source.IsEvm,
        ExplorerUrl = source.ExplorerUrl,
        Status = source.Status,
        GasFee = source.GasFee,
        GasUnit = source.GasUnit,
        TransactionsPerSecond = source.TransactionsPerSecond,
        Congestion = source.Congestion,
        FinalitySeconds = source.FinalitySeconds,
        ReliabilityScore = source.ReliabilityScore,
        LastUpdated = DateTime.UtcNow
    };
}
