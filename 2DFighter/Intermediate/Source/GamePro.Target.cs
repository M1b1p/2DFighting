using UnrealBuildTool;

public class GameProTarget : TargetRules
{
	public GameProTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("GamePro");
	}
}
