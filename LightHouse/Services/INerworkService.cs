using LightHouse.Core.Models;

public interface INetworkService
{
    Task<List<Network>> GetNetworksAsync();
}

