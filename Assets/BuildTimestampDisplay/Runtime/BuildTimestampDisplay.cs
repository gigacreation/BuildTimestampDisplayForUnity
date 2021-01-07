using System;
using UnityEngine;
using UnityEngine.UI;

namespace BuildTimestampDisplay
{
    [RequireComponent(typeof(Text)), AddComponentMenu("Gigacee/Build Timestamp Display")]
    public class BuildTimestampDisplay : MonoBehaviour
    {
        [SerializeField] BuildTimestamp buildTimestamp;
        [SerializeField] string format = "yyyy/MM/dd hh:mm:ss";
        [SerializeField] float utcOffsetHours;

        protected virtual void Start()
        {
            GetComponent<Text>().text = GetTimestampString();
        }

        protected string GetTimestampString()
        {
            if (!buildTimestamp)
            {
                return "BuildTimestamp is missing";
            }

            return new DateTime(
                    buildTimestamp.utcYear,
                    buildTimestamp.utcMonth,
                    buildTimestamp.utcDay,
                    buildTimestamp.utcHour,
                    buildTimestamp.utcMinute,
                    buildTimestamp.utcSecond
                )
                .AddMinutes(Mathf.RoundToInt(utcOffsetHours * 60f))
                .ToString(format);
        }
    }
}
