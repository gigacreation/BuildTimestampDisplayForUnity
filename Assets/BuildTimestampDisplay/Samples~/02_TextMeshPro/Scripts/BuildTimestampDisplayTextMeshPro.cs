using TMPro;
using UnityEngine;

namespace GigaCreation.Tools.BuildTimestampDisplay.Sample02
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    [AddComponentMenu("GIGA CREATION/Build Timestamp Display TextMesh Pro")]
    public class BuildTimestampDisplayTextMeshPro : MonoBehaviour
    {
        [Header("Assets")]
        [SerializeField] private BuildTimestamp _buildTimestamp;

        [Header("References")]
        [SerializeField] private TextMeshProUGUI _label;

        [Header("Parameters")]
        [SerializeField] private string _format = "yyyy/MM/dd HH:mm:ss";
        [SerializeField] private float _utcOffsetHours;

        private void Start()
        {
            string message = _buildTimestamp
                ? _buildTimestamp.ToString(_format, _utcOffsetHours)
                : "The BuildTimestamp asset is missing.";

            _label.SetText(message);
        }

        private void Reset()
        {
            _label = GetComponent<TextMeshProUGUI>();
        }
    }
}
