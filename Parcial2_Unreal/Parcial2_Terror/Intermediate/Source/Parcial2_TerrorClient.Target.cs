using UnrealBuildTool;

public class Parcial2_TerrorClientTarget : TargetRules
{
	public Parcial2_TerrorClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Parcial2_Terror");
	}
}
