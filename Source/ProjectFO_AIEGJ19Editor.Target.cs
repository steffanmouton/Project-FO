// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class ProjectFO_AIEGJ19EditorTarget : TargetRules
{
	public ProjectFO_AIEGJ19EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "ProjectFO_AIEGJ19" } );
	}
}
