using TMPro;
using UnityEngine;

namespace BuildTimestampDisplay.Sample2
{
    [RequireComponent(typeof(TextMeshProUGUI)), AddComponentMenu("Gigacee/Build Timestamp Display TextMesh Pro")]
    public class BuildTimestampDisplayTextMeshPro : MonoBehaviour
    {
        [SerializeField] BuildTimestamp buildTimestamp;
        [SerializeField] string format = "yyyy/MM/dd hh:mm:ss";
        [SerializeField] float utcOffsetHours;

        void Start()
        {
            GetComponent<TextMeshProUGUI>().SetText(
                buildTimestamp
                    ? buildTimestamp.ToString(format, utcOffsetHours)
                    : "BuildTimestamp is missing"
            );
        }
    }
}
