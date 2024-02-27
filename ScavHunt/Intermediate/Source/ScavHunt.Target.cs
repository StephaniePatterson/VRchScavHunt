using UnrealBuildTool;

public class ScavHuntTarget : TargetRules
{
	public ScavHuntTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ScavHunt");
	}
}
