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

            var buildInfo = AssetDatabase.LoadAssetAtPath<BuildTimestamp>($"{DEST_DIR_PATH}/{DEST_FILENAME}");

            if (buildInfo == null)
            {
                buildInfo = ScriptableObject.CreateInstance<BuildTimestamp>();
                AssetDatabase.CreateAsset(buildInfo, $"{DEST_DIR_PATH}/{DEST_FILENAME}");
            }

            var localTime = TimeZoneInfo.ConvertTimeFromUtc(report.summary.buildStartedAt, TimeZoneInfo.Local);
            buildInfo.timestamp = ConvertDateTimeIntoText(localTime);

            EditorUtility.SetDirty(buildInfo);
            AssetDatabase.SaveAssets();
        }

        static string ConvertDateTimeIntoText(DateTime dateTime)
        {
            var year = $"{dateTime.Year:D4}";
            var month = $"{dateTime.Month:D2}";
            var day = $"{dateTime.Day:D2}";
            var hour = $"{dateTime.Hour:D2}";
            var minute = $"{dateTime.Minute:D2}";
            var second = $"{dateTime.Second:D2}";

            return year + "/" + month + "/" + day + " " + hour + ":" + minute + ":" + second;
        }
    }
}
