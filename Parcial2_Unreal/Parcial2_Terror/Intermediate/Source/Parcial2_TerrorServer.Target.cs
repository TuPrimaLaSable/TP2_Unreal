using UnrealBuildTool;

public class Parcial2_TerrorServerTarget : TargetRules
{
	public Parcial2_TerrorServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Parcial2_Terror");
	}
}
