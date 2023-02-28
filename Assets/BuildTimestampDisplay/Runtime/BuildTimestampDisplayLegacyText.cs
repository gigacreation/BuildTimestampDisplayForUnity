using System.Linq;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace GigaCreation.Tools.BuildTimestampDisplay
{
    [RequireComponent(typeof(Text))]
    [AddComponentMenu("GIGA CREATION/Build Timestamp Display Legacy Text")]
    public class BuildTimestampDisplayLegacyText : MonoBehaviour
    {
        [Header("Assets")]
        [SerializeField] private BuildTimestamp _buildTimestamp;

        [Header("References")]
        [SerializeField] private Text _label;

        [Header("Parameters")]
        [SerializeField] private string _format = "yyyy/MM/dd HH:mm:ss";
        [SerializeField] private float _utcOffsetHours;

        private Text Label
        {
            get
            {
                if (_label == null)
                {
                    _label = GetComponent<Text>();
                }

                return _label;
            }
        }

        private void Start()
        {
            string message = _buildTimestamp
                ? _buildTimestamp.ToString(_format, _utcOffsetHours)
                : "The BuildTimestamp asset is not set.";

            Label.text = message;
        }

        private void Reset()
        {
            _label = GetComponent<Text>();
        }

        public void SetBuildTimestampAsset()
        {
#if UNITY_EDITOR
            string guid = AssetDatabase.FindAssets("t:BuildTimestamp").FirstOrDefault();

            if (guid == null)
            {
                Debug.LogWarning(
                    "The BuildTimestamp asset could not be found. This asset is generated after you run the build."
                );

                return;
            }

            if (!EditorApplication.isPlaying)
            {
                Undo.RecordObject(this, "Set BuildTimestamp Asset");
            }

            _buildTimestamp = AssetDatabase.LoadAssetAtPath<BuildTimestamp>(AssetDatabase.GUIDToAssetPath(guid));

            if (!EditorApplication.isPlaying)
            {
                EditorUtility.SetDirty(this);
            }
#endif
        }
    }
}
