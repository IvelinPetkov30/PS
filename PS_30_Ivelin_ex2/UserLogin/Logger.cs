using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static class Logger
    {
        private static List<string> currentSessionActivities = new List<string>();

        public static void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";" + LoginValidation.currentUserUsername + ";" + LoginValidation.currentUserRole + ";" + activity;
            currentSessionActivities.Add(activityLine);
            string fileName = "test.txt";
            if (File.Exists(fileName))
            {

                File.AppendAllText(fileName, activityLine + "\n");
            }
        }

        public static string GetCurrentSessionActivity()
        {
            StringBuilder currentActivity = new StringBuilder();

            foreach (string str in currentSessionActivities)
            {
                currentActivity.Append(str + "\n");
            }
            return currentActivity.ToString();
        }

    }
}
