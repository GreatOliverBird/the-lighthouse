using LightHouse.Models;
public interface INetworkService
{
    Task<List<Network>> GetNetworksAsync();
}

