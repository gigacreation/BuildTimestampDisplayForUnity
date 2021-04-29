using UnityEngine;
using UnityEngine.UI;

namespace BuildTimestampDisplay
{
    [RequireComponent(typeof(Text)), AddComponentMenu("Gigacee/Build Timestamp Display")]
    public class BuildTimestampDisplay : MonoBehaviour
    {
        [SerializeField] BuildTimestamp buildTimestamp;
        [SerializeField] string format = "yyyy/MM/dd HH:mm:ss";
        [SerializeField] float utcOffsetHours;

        void Start()
        {
            GetComponent<Text>().text = buildTimestamp
                ? buildTimestamp.ToString(format, utcOffsetHours)
                : "BuildTimestamp is missing";
        }
    }
}
