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
        static private ICollection<string> logFileLines;
        public static void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";" + LoginValidation.currentUserUsername + ";" + LoginValidation.currentUserRole + ";" + activity;
            currentSessionActivities.Add(activityLine);
            string fileName = "Log.txt";
            if (File.Exists(fileName))
            {

                File.AppendAllText(fileName, activityLine + "\n");
            }
        }

        public static IEnumerable<string> GetCurrentSessionActivities(string filter)
        {
            List<string> filteredActivities = (from activity 
                                               in currentSessionActivities
                                               where activity.Contains(filter)
                                               select activity).ToList();

            return filteredActivities;
        }

        public static IEnumerable<string> GetLogsFromFile()
        {
            List<string> result = new List<string>();

            StreamReader sr = new StreamReader("Logs.txt");
            string line = String.Empty;

            while ((line = sr.ReadLine()) != null)
            {
                result.Add(line);
                line = String.Empty;
            }

            sr.Close();

            return result;
        }
    }
}
