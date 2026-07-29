using UnrealBuildTool;

public class Parcial2_TerrorTarget : TargetRules
{
	public Parcial2_TerrorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Parcial2_Terror");
	}
}
