using TMPro;
using UnityEngine;

namespace BuildTimestampDisplay.Sample2
{
    [RequireComponent(typeof(TextMeshProUGUI)), AddComponentMenu("Gigacee/Build Timestamp Display TextMesh Pro")]
    public class BuildTimestampDisplayTextMeshPro : BuildTimestampDisplay
    {
        protected override void Start()
        {
            GetComponent<TextMeshProUGUI>().SetText(GetTimestampString());
        }
    }
}
