using TMPro;
using UnityEngine;

namespace BuildTimestampDisplay.Sample2
{
    [RequireComponent(typeof(TextMeshProUGUI)), AddComponentMenu("Gigacee/Build Timestamp Display TextMesh Pro")]
    public class BuildTimestampDisplayTextMeshPro : MonoBehaviour
    {
        [SerializeField] BuildTimestamp buildTimestamp;

        void Start()
        {
            GetComponent<TextMeshProUGUI>().SetText(buildTimestamp.timestamp);
        }
    }
}
