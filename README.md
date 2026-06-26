# PROG-POE-PART-3
# Cybersecurity Awareness Chatbot (Part 3)

## Project Overview
This project is a **Cybersecurity Awareness Chatbot** built in **C# with WPF**.  
It was developed as part of the Part 3 assignment to extend the console chatbot from Part 2 into a graphical application.  

The chatbot teaches safe online habits through a quiz, while also letting the user manage tasks and view an activity log.  
It combines **learning** and **organization** in one interactive tool.

---

## Features
- **Chat Window**: Displays conversation between the bot and the user.
- **QuizMiniGame**: Asks cybersecurity questions and checks answers.
- **TaskManager**: Allows adding tasks, viewing tasks, and logging activities.
- **Activity Log**: Records all actions (quiz started, tasks added, tasks viewed) with timestamps.
- **Buttons**:  
  - Send → Submit quiz/chat answers  
  - Add Task → Add a new task  
  - View Tasks → Show all tasks  
  - Start Quiz → Begin a cybersecurity quiz  
  - Show Log → Display activity history  

---

## Setup Instructions
1. Install **Visual Studio 2022** or later.
2. Make sure you have **.NET 6.0 SDK** or newer installed.
3. Clone or download this repository.
4. Open the solution in Visual Studio.
5. Build and run the project.

---

## How to Run
1. Launch the application.
2. The bot will greet you in the chat window.
3. Use the **Send** button to answer quiz questions.
4. Use the **Add Task** box and button to add tasks.
5. Use **View Tasks** to see your list of tasks.
6. Use **Show Log** to see all recorded actions.

---

## Outcomes When Running
- The bot welcomes the user and starts a conversation.  
- Quiz answers are checked instantly, with feedback showing if the choice is safe or unsafe.  
- Tasks can be added and displayed in the chat window.  
- The activity log shows everything the user has done, with timestamps.  
- Overall, the chatbot teaches **cybersecurity awareness** while also helping the user stay **organized**.

---

## Project Structure
- `ChatbotGUI.xaml` → Defines the interface layout.
- `ChatbotGUI.xaml.cs` → Handles button clicks and connects features.
- `QuizMiniGame.cs` → Quiz logic and answer checking.
- `TaskManager.cs` → Task management and activity logging.
- `ActivityLog.cs` → Stores log entries.

---

## Future Improvements
- Add multiple quiz questions with scoring.
- Allow tasks to include descriptions and due dates.
- Improve the interface with labels or watermarks for input boxes.
- Save tasks and logs to a file or database.

---

## License
This project was created for academic purposes.  
You are free to study and adapt it for learning.
