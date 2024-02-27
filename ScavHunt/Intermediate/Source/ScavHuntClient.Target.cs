using UnrealBuildTool;

public class ScavHuntClientTarget : TargetRules
{
	public ScavHuntClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("ScavHunt");
	}
}
