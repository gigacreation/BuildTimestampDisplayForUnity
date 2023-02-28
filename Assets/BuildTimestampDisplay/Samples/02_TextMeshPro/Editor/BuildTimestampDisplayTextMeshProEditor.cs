// ReSharper disable UseNegatedPatternInIsExpression

using UnityEditor;
using UnityEngine;

namespace GigaCreation.Tools.BuildTimestampDisplay.Sample02.Editor
{
    [CustomEditor(typeof(BuildTimestampDisplayTextMeshPro))]
    public class BuildTimestampDisplayTextMeshProEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (!(target is BuildTimestampDisplayTextMeshPro buildTimestampDisplay))
            {
                return;
            }

            EditorGUILayout.Space();

            if (EditorApplication.isPlaying)
            {
                GUI.enabled = false;
            }

            if (GUILayout.Button("Set BuildTimestamp Asset", GUILayout.Height(24f)))
            {
                buildTimestampDisplay.SetBuildTimestampAsset();
            }
        }
    }
}
