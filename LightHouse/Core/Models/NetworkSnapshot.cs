namespace LightHouse.Core.Models;

public class NetworkSnapshot
{
    public NetworkInfo Info { get; set; } = new();

    public LiveMetrics Live { get; set; } = new();

    public AnalyticsMetrics Analytics { get; set; } = new();
}