using System.Collections.Generic;

namespace CyberSecurityChatbotGUI.Features
{
    public class QuizeMiniGame
    {
        public string CheckQuizAnswer(string input)
        {
            string userAnswer = input.Trim().ToLower();

            List<string> validAnswers = new List<string>
            {
                "reply",
                "delete",
                "report as phishing",
                "ignore"
            };

            if (validAnswers.Contains(userAnswer))
            {
                switch (userAnswer)
                {
                    case "reply":
                        return "❌ Incorrect. Never reply to suspicious emails.";
                    case "delete":
                        return "⚠️ Not the best option. Deleting hides the problem but doesn’t report it.";
                    case "report as phishing":
                        return "✅ Correct! Always report suspicious emails to protect yourself and others.";
                    case "ignore":
                        return "⚠️ Ignoring isn’t safe. Better to report it.";
                }
            }

            return "I didn’t quite understand that. Please choose one of the options: Reply, Delete, Report as phishing, Ignore.";
        }
    }
}
