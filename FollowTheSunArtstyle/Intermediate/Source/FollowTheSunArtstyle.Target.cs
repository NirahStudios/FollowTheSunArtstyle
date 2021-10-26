using UnrealBuildTool;

public class FollowTheSunArtstyleTarget : TargetRules
{
	public FollowTheSunArtstyleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("FollowTheSunArtstyle");
	}
}
