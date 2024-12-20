using System.Numerics;
using Dalamud.Game.ClientState.Objects.Types;

namespace Radar.CustomObject;

public static class DeepDungeonObjectExtension
{
    public static bool IsTrap(IGameObject obj)
    {
        return obj switch
        {
            { DataId: 6388, Position: var p } when p != Vector3.Zero => true,
            { DataId: >= 2007182 and <= 2007186 } => true,
            { DataId: 2009504 } => true,
            _ => false
        };
    }

    public static bool IsAccursedHoard(IGameObject obj) => obj.DataId == 2007542 || obj.DataId == 2007543;

    public static bool IsSilverCoffer(IGameObject obj) => obj.DataId == 2007357;
}
