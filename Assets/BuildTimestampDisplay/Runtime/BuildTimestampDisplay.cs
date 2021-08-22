using UnityEngine;
using UnityEngine.UI;

namespace BuildTimestampDisplay
{
    [RequireComponent(typeof(Text))]
    [AddComponentMenu("Gigacee/Build Timestamp Display")]
    public class BuildTimestampDisplay : MonoBehaviour
    {
        [SerializeField] private BuildTimestamp buildTimestamp;
        [SerializeField] private string format = "yyyy/MM/dd HH:mm:ss";
        [SerializeField] private float utcOffsetHours;

        private void Start()
        {
            GetComponent<Text>().text = buildTimestamp
                ? buildTimestamp.ToString(format, utcOffsetHours)
                : "BuildTimestamp is missing";
        }
    }
}
