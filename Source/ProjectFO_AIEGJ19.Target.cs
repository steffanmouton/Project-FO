// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class ProjectFO_AIEGJ19Target : TargetRules
{
	public ProjectFO_AIEGJ19Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "ProjectFO_AIEGJ19" } );
	}
}
