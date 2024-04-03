using UnityEditor;
using UnityEngine;

namespace Assets.Script
{
    public class Script : ScriptableObject
    {
        [MenuItem("Tools/MyTool/Do It in C#")]
        static void DoIt()
        {
            EditorUtility.DisplayDialog("MyTool", "Do It in C# !", "OK", "");
        }
    }
}