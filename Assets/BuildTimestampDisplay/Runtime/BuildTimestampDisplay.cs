using UnityEngine;
using UnityEngine.UI;

namespace BuildTimestampDisplay
{
    [RequireComponent(typeof(Text))]
    [AddComponentMenu("Gigacee/Build Timestamp Display")]
    public class BuildTimestampDisplay : MonoBehaviour
    {
        [SerializeField] private BuildTimestamp _buildTimestamp;
        [SerializeField] private string _format = "yyyy/MM/dd HH:mm:ss";
        [SerializeField] private float _utcOffsetHours;

        private void Start()
        {
            GetComponent<Text>().text = _buildTimestamp
                ? _buildTimestamp.ToString(_format, _utcOffsetHours)
                : "BuildTimestamp is missing";
        }
    }
}
