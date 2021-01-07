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
        const string DEST_DIR_PATH = "Assets/BuildTimestampDisplay";
        const string DEST_FILENAME = "BuildTimestamp.asset";

        public int callbackOrder => 0;

        public void OnPreprocessBuild(BuildReport report)
        {
            if (!Directory.Exists(DEST_DIR_PATH))
            {
                Directory.CreateDirectory(DEST_DIR_PATH);
            }

            var buildTimestamp = AssetDatabase.LoadAssetAtPath<BuildTimestamp>($"{DEST_DIR_PATH}/{DEST_FILENAME}");

            if (buildTimestamp == null)
            {
                buildTimestamp = ScriptableObject.CreateInstance<BuildTimestamp>();
                AssetDatabase.CreateAsset(buildTimestamp, $"{DEST_DIR_PATH}/{DEST_FILENAME}");
            }

            var dateTime = TimeZoneInfo.ConvertTimeFromUtc(report.summary.buildStartedAt, TimeZoneInfo.Utc);

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
