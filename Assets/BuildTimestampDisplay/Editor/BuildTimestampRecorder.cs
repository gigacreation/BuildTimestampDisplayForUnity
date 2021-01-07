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
            buildInfo.timestamp = ConvertDateTimeIntoString(localTime);

            EditorUtility.SetDirty(buildInfo);
            AssetDatabase.SaveAssets();
        }

        static string ConvertDateTimeIntoString(DateTime dateTime)
        {
            var year = dateTime.Year;
            var month = dateTime.Month;
            var day = dateTime.Day;
            var hour = dateTime.Hour;
            var minute = dateTime.Minute;
            var second = dateTime.Second;

            return $"{year:D4}/{month:D2}/{day:D2} {hour:D2}:{minute:D2}:{second:D2}";
        }
    }
}
