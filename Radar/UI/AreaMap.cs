using System;
using System.Numerics;
using Dalamud.Interface.Utility;
using FFXIVClientStructs.FFXIV.Component.GUI;
using FFXIVClientStructs.STD;

namespace Radar.UI;

internal static class AreaMap
{
	public static unsafe AtkUnitBase* AreaMapAddon => (AtkUnitBase*)Plugin.Gui.GetAddonByName("AreaMap");

	public static unsafe bool HasMap => AreaMapAddon != (AtkUnitBase*)IntPtr.Zero;

    public static unsafe bool MapVisible => HasMap && AreaMapAddon->IsVisible;

	public static unsafe ref float MapScale => ref *(float*)((byte*)AreaMapAddon + 972);
}
