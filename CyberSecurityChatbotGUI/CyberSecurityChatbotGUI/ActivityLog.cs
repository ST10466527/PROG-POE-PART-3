public static class ActivityLog
{
    private static List<string> log = new List<string>();

    public static void Add(string action)
    {
        log.Add($"{DateTime.Now}: {action}");
        if (log.Count > 10) log.RemoveAt(0); // keep last 10
    }

    public static string ShowLog() => string.Join("\n", log);
}
