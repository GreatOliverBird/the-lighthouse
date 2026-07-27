namespace  LightHouse.Core.Interfaces;
using  LightHouse.Core.Models;
public interface IBlockchainAdapter
{
    string Name { get; }
    Task<NetworkSnapshot> GetSnapshotAsync();
}