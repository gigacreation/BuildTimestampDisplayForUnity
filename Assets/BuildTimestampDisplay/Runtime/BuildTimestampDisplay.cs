﻿using UnityEngine;
using UnityEngine.UI;

namespace GigaCreation.Tools.BuildTimestampDisplay
{
    [RequireComponent(typeof(Text))]
    [AddComponentMenu("GIGA CREATION/Build Timestamp Display Legacy Text")]
    public class BuildTimestampDisplay : MonoBehaviour
    {
        [Header("Assets")]
        [SerializeField] private BuildTimestamp _buildTimestamp;

        [Header("References")]
        [SerializeField] private Text _label;

        [Header("Parameters")]
        [SerializeField] private string _format = "yyyy/MM/dd HH:mm:ss";
        [SerializeField] private float _utcOffsetHours;

        private void Start()
        {
            string message = _buildTimestamp
                ? _buildTimestamp.ToString(_format, _utcOffsetHours)
                : "The BuildTimestamp asset is missing.";

            _label.text = message;
        }

        private void Reset()
        {
            _label = GetComponent<Text>();
        }
    }
}
