using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;
using System.Reflection;

namespace arcade_paradise_unbreakable_plugin
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInProcess("ArcadeParadise.exe")]
    public class Plugin : BasePlugin
    {
        public override void Load()
        {
            var harmony = new Harmony(PluginInfo.PLUGIN_GUID);
            var assembly = Assembly.GetExecutingAssembly();
            harmony.PatchAll(assembly);
            harmony.PatchAll();
        }

        // 壊れたゲーム機を修理するパッチ
        [HarmonyPatch(typeof(RAT.Scriptables.Objects.ArcadeMachine), nameof(RAT.Scriptables.Objects.ArcadeMachine.IsBroken), MethodType.Getter)]
        public class RAT_Scriptables_Objects_ArcadeMachine_get_IsBroken_Patch
        {
            static void Postfix(ref bool __result, RAT.Scriptables.Objects.ArcadeMachine __instance)
            {
                if (__result)
                {
                    // 壊れている場合は修理する。
                    RAT.Arcade.ArcadeMachine broken_arcade_machine = RAT.Managers.ArcadeMachineManager.GetMachineByDataID(__instance.ID);
                    if (broken_arcade_machine != null)
                    {
                        broken_arcade_machine.MachineFixed();
                        __result = false;
                    }
                }
            }
        }
    }
}
