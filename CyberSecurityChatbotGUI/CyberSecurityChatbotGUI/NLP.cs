public class NLP
{
    public string ProcessInput(string input)
    {
        input = input.ToLower();
        if (input.Contains("task")) return "Would you like to add a task?";
        if (input.Contains("quiz")) return "Starting cybersecurity quiz...";
        if (input.Contains("remind")) return "Setting a reminder...";
        return "I didn’t quite understand that. Could you rephrase?";
    }
}
