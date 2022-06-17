// The NiTiS-Dev licenses this file to you under the MIT license.
using Microsoft.Xna.Framework;
using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace WingsAndHookStatsPlusPlus.Common.Configs;
public class WaHSppConfig : ModConfig
{
	public override ConfigScope Mode => ConfigScope.ClientSide;

	[Header("$Mods.WaHSpp.Config.Hooks")]
	[Label("$Mods.WaHSpp.Config.GenericEnable.Label")]
	[Tooltip("$Mods.WaHSpp.Config.GenericEnable.Tooltip")]
	[DefaultValue(true)]
	public bool EnableHookStats;

	[Label("$Mods.WaHSpp.Config.GenericColor.Label")]
	[Tooltip("$Mods.WaHSpp.Config.GenericColor.Tooltip")]
	[DefaultValue(typeof(Color), "255, 165, 0, 255")]
	public Color HookStatsHeaderColor;

	[Header("$Mods.WaHSpp.Config.Wings")]
	[Label("$Mods.WaHSpp.Config.GenericEnable.Label")]
	[Tooltip("$Mods.WaHSpp.Config.GenericEnable.Tooltip")]
	[DefaultValue(true)]
	public bool EnableWingsStats;

	[Label("$Mods.WaHSpp.Config.GenericColor.Label")]
	[Tooltip("$Mods.WaHSpp.Config.GenericColor.Tooltip")]
	[DefaultValue(typeof(Color), "165, 255, 0, 255")]
	public Color WingsStatsHeaderColor;
}
