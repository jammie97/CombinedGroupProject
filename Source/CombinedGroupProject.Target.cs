// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class CombinedGroupProjectTarget : TargetRules
{
	public CombinedGroupProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("CombinedGroupProject");

        bUsesSteam = true;
        //UEBuildConfiguration.bCompileSteamOSS = true;
    }
}
