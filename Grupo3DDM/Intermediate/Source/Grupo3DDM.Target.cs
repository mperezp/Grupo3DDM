using UnrealBuildTool;

public class Grupo3DDMTarget : TargetRules
{
	public Grupo3DDMTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Grupo3DDM");
	}
}
