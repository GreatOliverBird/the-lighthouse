namespace LightHouse.Models;

public class Network
{
    public string Name { get; set; } = string.Empty;
    
    public string Symbol {get; set;} = string.Empty;
    
    public string LogoUrl {get; set;} = string.Empty;
    
    public NetworkStatus Status { get; set; }
    
    public decimal GasFee { get; set; }
    
    public CongestionLevel CongestionLevel { get; set; }
    
    public string GasUnit { get; set; } = string.Empty;
    

    public int TransactionsPerSecond { get; set; }

    public CongestionLevel Congestion { get; set; }

    public double FinalitySeconds { get; set; }

    public DateTime LastUpdated { get; set; }
    
}