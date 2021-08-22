using System;
using System.IO;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

namespace BuildTimestampDisplay.Editor
{
    public class BuildTimestampRecorder : IPreprocessBuildWithReport
    {
        private const string DestDirPath = "Assets/BuildTimestampDisplay";
        private const string DestFilename = "BuildTimestamp.asset";

        public int callbackOrder => 0;

        public void OnPreprocessBuild(BuildReport report)
        {
            if (!Directory.Exists(DestDirPath))
            {
                Directory.CreateDirectory(DestDirPath);
            }

            var buildTimestamp = AssetDatabase.LoadAssetAtPath<BuildTimestamp>($"{DestDirPath}/{DestFilename}");

            if (buildTimestamp == null)
            {
                buildTimestamp = ScriptableObject.CreateInstance<BuildTimestamp>();
                AssetDatabase.CreateAsset(buildTimestamp, $"{DestDirPath}/{DestFilename}");
            }

            DateTime dateTime = TimeZoneInfo.ConvertTimeFromUtc(report.summary.buildStartedAt, TimeZoneInfo.Utc);

            buildTimestamp.utcYear = dateTime.Year;
            buildTimestamp.utcMonth = dateTime.Month;
            buildTimestamp.utcDay = dateTime.Day;
            buildTimestamp.utcHour = dateTime.Hour;
            buildTimestamp.utcMinute = dateTime.Minute;
            buildTimestamp.utcSecond = dateTime.Second;

            EditorUtility.SetDirty(buildTimestamp);
            AssetDatabase.SaveAssets();
        }
    }
}
