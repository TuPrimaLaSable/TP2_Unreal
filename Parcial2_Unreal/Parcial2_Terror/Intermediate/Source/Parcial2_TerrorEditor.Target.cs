using UnrealBuildTool;

public class Parcial2_TerrorEditorTarget : TargetRules
{
	public Parcial2_TerrorEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Parcial2_Terror");
	}
}
