using TMPro;
using UnityEngine;

namespace BuildTimestampDisplay.Sample2
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    [AddComponentMenu("Gigacee/Build Timestamp Display TextMesh Pro")]
    public class BuildTimestampDisplayTextMeshPro : MonoBehaviour
    {
        [SerializeField] private BuildTimestamp _buildTimestamp;
        [SerializeField] private string _format = "yyyy/MM/dd hh:mm:ss";
        [SerializeField] private float _utcOffsetHours;

        private void Start()
        {
            GetComponent<TextMeshProUGUI>().SetText(
                _buildTimestamp
                    ? _buildTimestamp.ToString(_format, _utcOffsetHours)
                    : "BuildTimestamp is missing"
            );
        }
    }
}
