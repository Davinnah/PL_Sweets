// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class UR_SolitaireSweetsTarget : TargetRules
{
	public UR_SolitaireSweetsTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "UR_SolitaireSweets" } );
	}
}
