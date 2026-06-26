using System;
using System.Windows;
using CyberSecurityChatbotGUI.Features;

namespace PROG_POE_PART_3
{
    public partial class ChatbotGUI : Window
    {
        private TaskManager taskManager;
        private QuizeMiniGame quiz;

        public ChatbotGUI()
        {
            InitializeComponent();
            taskManager = new TaskManager();
            quiz = new QuizeMiniGame();

            ChatBox.AppendText("Bot: Welcome to the Cybersecurity Awareness Chatbot!\n");
        }

        // Quiz/chat answers
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string userInput = UserInput.Text;
            ChatBox.AppendText("You: " + userInput + "\n");

            string response = quiz.CheckQuizAnswer(userInput);
            ChatBox.AppendText("Bot: " + response + "\n");

            UserInput.Clear();
        }

        // Add task
        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            string taskName = TaskInput.Text;
            if (!string.IsNullOrWhiteSpace(taskName))
            {
                taskManager.AddTask(taskName);
                ChatBox.AppendText($"Bot: Task added: {taskName}\n");
                taskManager.LogActivity($"Task added: {taskName}");
                TaskInput.Clear();
            }
            else
            {
                ChatBox.AppendText("Bot: Please enter a task name.\n");
            }
        }

        // View tasks
        private void ViewTasks_Click(object sender, RoutedEventArgs e)
        {
            var tasks = taskManager.GetTasks();
            ChatBox.AppendText("Bot: Your tasks:\n");
            foreach (var task in tasks)
            {
                ChatBox.AppendText("- " + task + "\n");
            }
            taskManager.LogActivity("Viewed tasks");
        }

        // Start quiz
        private void StartQuiz_Click(object sender, RoutedEventArgs e)
        {
            ChatBox.AppendText("Bot: Starting quiz...\n");
            ChatBox.AppendText("Bot: What should you do if an email asks for your password?\n");
            ChatBox.AppendText("Options: Reply, Delete, Report as phishing, Ignore\n");
            taskManager.LogActivity("Quiz started");
        }

        // Show log
        private void ShowLog_Click(object sender, RoutedEventArgs e)
        {
            var logs = taskManager.GetActivityLog();
            ChatBox.AppendText("Bot: Activity Log:\n");
            foreach (var log in logs)
            {
                ChatBox.AppendText(log + "\n");
            }
        }
    }
}

