namespace LightHouse.Core.Models;

public class AnalyticsMetrics
{
    public NetworkStatus Status { get; set; }

    public CongestionLevel Congestion { get; set; }

    public int ReliabilityScore { get; set; }

    public int RecommendationScore { get; set; }

    public int FinalitySeconds { get; set; }

    public string RecommendationReason { get; set; } = string.Empty;
}