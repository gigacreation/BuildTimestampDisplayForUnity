// ReSharper disable UseNegatedPatternInIsExpression

using UnityEditor;
using UnityEngine;

namespace GigaCreation.Tools.BuildTimestampDisplay.Editor
{
    [CustomEditor(typeof(BuildTimestampDisplayLegacyText))]
    public class BuildTimestampDisplayLegacyTextEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (!(target is BuildTimestampDisplayLegacyText buildTimestampDisplay))
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
