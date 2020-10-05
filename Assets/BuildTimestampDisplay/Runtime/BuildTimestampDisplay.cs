using UnityEngine;
using UnityEngine.UI;

namespace BuildTimestampDisplay
{
    [RequireComponent(typeof(Text)), AddComponentMenu("Gigacee/Build Timestamp Display")]
    public class BuildTimestampDisplay : MonoBehaviour
    {
        [SerializeField] BuildTimestamp buildTimestamp;

        void Start()
        {
            GetComponent<Text>().text = buildTimestamp.timestamp;
        }
    }
}
