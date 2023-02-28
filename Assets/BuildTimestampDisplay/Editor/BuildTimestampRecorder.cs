using System;
using System.IO;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

namespace GigaCreation.Tools.BuildTimestampDisplay.Editor
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

            buildTimestamp.UtcYear = dateTime.Year;
            buildTimestamp.UtcMonth = dateTime.Month;
            buildTimestamp.UtcDay = dateTime.Day;
            buildTimestamp.UtcHour = dateTime.Hour;
            buildTimestamp.UtcMinute = dateTime.Minute;
            buildTimestamp.UtcSecond = dateTime.Second;

            EditorUtility.SetDirty(buildTimestamp);
            AssetDatabase.SaveAssets();
        }
    }
}
