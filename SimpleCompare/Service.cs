﻿using Dalamud.Game;
using Dalamud.Game.ClientState.Objects;
using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;

namespace SimpleCompare
{
    public class Service
    {
        [PluginService] public static IDalamudPluginInterface PluginInterface { get; private set; }
        [PluginService] public static IChatGui Chat { get; private set; }
        [PluginService] public static IClientState ClientState { get; private set; }
        [PluginService] public static ICommandManager Commands { get; private set; }
        [PluginService] public static ICondition Condition { get; private set; }
        [PluginService] public static IDataManager Data { get; private set; }
        [PluginService] public static IFramework Framework { get; private set; }
        [PluginService] public static IGameGui GameGui { get; private set; }
        [PluginService] public static IKeyState KeyState { get; private set; }
        [PluginService] public static IObjectTable Objects { get; private set; }
        [PluginService] public static ISigScanner SigScanner { get; private set; }
        [PluginService] public static ITargetManager Targets { get; private set; }
        [PluginService] public static IToastGui Toasts { get; private set; }
        [PluginService] public static IPluginLog PluginLog { get; private set; }
    }
}
