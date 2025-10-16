﻿using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Memory.DynamicFunctions;

namespace ChaseMod.Utils.Memory;

public static class GrenadeFunctions
{
    // search 'smokegrenade_projectile', xref to function with string used at top
    public static MemoryFunctionWithReturn<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, CSmokeGrenadeProjectile> CSmokeGrenadeProjectile_CreateFunc =
        new(
            ChaseModUtils.IsLinux
                ? "55 4C 89 C1 48 89 E5 41 57 45 89 CF 41 56 49 89 FE"
                : "48 8B C4 48 89 58 ? 48 89 68 ? 48 89 70 ? 57 41 56 41 57 48 81 EC ? ? ? ? 48 8B B4 24 ? ? ? ? 4D 8B F8"
        );
}
