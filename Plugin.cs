using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;
using System.Numerics;
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
                // FileLog.Log($"{__instance.name} = {__instance.m_Reliability.x},{__instance.m_Reliability.y}");

                RAT.Arcade.ArcadeMachine arcade_machine = RAT.Managers.ArcadeMachineManager.GetMachineByDataID(__instance.ID);
                if (arcade_machine == null)
                {
                    return;
                }
                
                if (__result)
                {
                    // FileLog.Log("Break!!!!!!!!!!!!!!!!!!!!!!");

                    // 壊れている場合は修理する。
                    arcade_machine.MachineFixed();

                    // カメラをリセットしないとカメラの位置がおかしくなる。
                    RAT.Managers.CameraManager.ResetCamera();

                    __result = false;
                } else
                {
                    // 信頼性(HP?)が減っていたら修理する。
                    // 信頼性が0になると故障するっぽい。
                    // __instance.m_Reliability.x = 現在のHP
                    // __instance.m_Reliability.y = MAX HP
                    if (__instance.m_Reliability.x != __instance.m_Reliability.y)
                    {
                        // FileLog.Log("回復！");

                        // 壊れていなくてもこのメソッドを呼ぶと信頼性がMAXまで回復するっぽい。
                        arcade_machine.MachineFixed();
                    }
                }
            }
        }

        // 信頼性チェックをスキップするパッチ
        // このメソッドをPrefixで実行されないようにすると信頼性が減らなくなる。
        // おそらくこのメソッドの中で信頼性の計算を行っていると思われる。
        [HarmonyPatch(typeof(RAT.Managers.ArcadeMachineManager), nameof(RAT.Managers.ArcadeMachineManager.Reliability), MethodType.Normal)]
        public class RAT_Managers_ArcadeMachineManager_Reliability_Patch
        {
            static bool Prefix(RAT.Managers.ArcadeMachineManager __instance)
            {
                // FileLog.Log($"call RAT_Managers_ArcadeMachineManager_Reliability_Patch");
                return false;
            }
        }
    }
}
