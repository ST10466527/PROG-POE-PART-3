using System;
using System.Collections.Generic;

namespace CyberSecurityChatbotGUI.Features
{
    public class TaskManager
    {
        private List<string> tasks;
        private List<string> activityLog;

        public TaskManager()
        {
            tasks = new List<string>();
            activityLog = new List<string>();
        }

        // Add a task (only needs a name for now)
        public void AddTask(string taskName)
        {
            tasks.Add(taskName);
        }

        // Get all tasks
        public List<string> GetTasks()
        {
            return tasks;
        }

        // Log an activity with timestamp
        public void LogActivity(string activity)
        {
            string logEntry = $"{DateTime.Now:yyyy/MM/dd HH:mm:ss}: {activity}";
            activityLog.Add(logEntry);
        }

        // Get all activity logs
        public List<string> GetActivityLog()
        {
            return activityLog;
        }
    }
}
