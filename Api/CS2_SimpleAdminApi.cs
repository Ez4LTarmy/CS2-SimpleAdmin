using CS2_SimpleAdminApi;

namespace CS2_SimpleAdmin.Api;

public class CS2_SimpleAdminApi : ICS2_SimpleAdminApi
{
    public event Action<PlayerInfo, PlayerInfo?, PenaltyType, string, int, int?>? OnPlayerPenaltied;
    
    public void OnPlayerPenaltiedEvent(PlayerInfo player, PlayerInfo? admin, PenaltyType penaltyType, string reason,
        int duration)
    {
        OnPlayerPenaltied?.Invoke(player, admin, penaltyType, reason, duration, CS2_SimpleAdmin.ServerId);
    }

}