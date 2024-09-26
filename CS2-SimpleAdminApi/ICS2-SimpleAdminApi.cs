using CounterStrikeSharp.API.Core.Capabilities;

namespace CS2_SimpleAdminApi;

public interface ICS2_SimpleAdminApi
{
    public static readonly PluginCapability<ICS2_SimpleAdminApi?> PluginCapability = new("simpleadmin:api");
    
    public event Action<PlayerInfo, PlayerInfo?, PenaltyType, string, int, int?>? OnPlayerPenaltied;
}