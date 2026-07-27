using LightHouse.Core.Models;

namespace LightHouse.Adapters;
using LightHouse.Core.Interfaces;

public class EthereumAdapter : IBlockchainAdapter
{
    public string Name { get; }
    public Task<NetworkSnapshot> GetSnapshotAsync()
    {
        
    }
}