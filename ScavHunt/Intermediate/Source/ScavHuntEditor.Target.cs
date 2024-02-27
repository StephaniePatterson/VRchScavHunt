using UnrealBuildTool;

public class ScavHuntEditorTarget : TargetRules
{
	public ScavHuntEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ScavHunt");
	}
}
