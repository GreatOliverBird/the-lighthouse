namespace LightHouse.Core.Models;

public class NetworkInfo
{
    public string Name { get; set; } = string.Empty;

    public string Symbol { get; set; } = string.Empty;

    public int ChainId { get; set; }

    public string LogoUrl { get; set; } = string.Empty;

    public string ExplorerUrl { get; set; } = string.Empty;

    public string RpcUrl { get; set; } = string.Empty;

    public bool IsEvm { get; set; }
}