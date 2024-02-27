using UnrealBuildTool;

public class ScavHuntServerTarget : TargetRules
{
	public ScavHuntServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("ScavHunt");
	}
}
