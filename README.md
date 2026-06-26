# CyberSecurity Awareness Chatbot – PROG POE Part 3 (2026)

##  Project Overview
The CyberSecurity Awareness Chatbot – Part 3 is a **WPF-based application** developed in C# using .NET 8.0.  
This version builds on the Part 2 console chatbot by introducing a graphical interface, task management, and activity logging.  
The application continues to promote cybersecurity awareness while adding practical features for user interaction and organization.

---

##  Objectives of Part 3
The main objectives of this project were to:
- Upgrade the chatbot from a console app to a WPF GUI.
- Improve user interaction with buttons and input fields.
- Implement task management alongside the quiz feature.
- Record user actions in an activity log with timestamps.
- Demonstrate object-oriented programming in a GUI environment.

---

##  Features Implemented in Part 3
- **Graphical User Interface (GUI)**: Chat window, input boxes, and buttons for interaction.
- **QuizMiniGame**: Asks cybersecurity questions and checks answers with instant feedback.
- **TaskManager**: Allows adding tasks, viewing tasks, and logging activities.
- **Activity Log**: Records all actions (quiz started, tasks added, tasks viewed) with timestamps.
- **Interactive Buttons**:
  - **Send** → Submit quiz/chat answers  
  - **Add Task** → Add a new task  
  - **View Tasks** → Show all tasks  
  - **Start Quiz** → Begin a cybersecurity quiz  
  - **Show Log** → Display activity history  

---

##  Technologies Used
| Technology | Purpose |
|------------|---------|
| **C#** | Main programming language |
| **.NET 8.0** | Application framework |
| **WPF (Windows Presentation Foundation)** | GUI development |
| **Visual Studio 2022** | Development environment |
| **GitHub** | Version control and repository hosting |
| **GitHub Actions** | Continuous Integration (CI) |

---

##  Project Structure
```
PROG-POE-PART-3-2026/
│── ChatbotGUI.xaml        # Interface layout
│── ChatbotGUI.xaml.cs     # Code-behind for GUI
│── QuizMiniGame.cs        # Quiz logic
│── TaskManager.cs         # Task management and logging
│── ActivityLog.cs         # Stores log entries
│── PROG-POE-PART-3.csproj # Project file
│── README.md              # Documentation
```

---

##  Installation and Setup
1. Clone the Repository  
   ```bash
   git clone https://github.com/ST10466527/PROG-POE-PART-3-2026.git
   ```
2. Open the Project in Visual Studio 2022.
3. Build the solution.
4. Run the application.

---

##  Outcomes When Running
- The bot welcomes the user in the chat window.  
- Quiz answers are checked instantly, with feedback showing if the choice is safe or unsafe.  
- Tasks can be added and displayed in the chat window.  
- The activity log shows everything the user has done, with timestamps.  
- Overall, the chatbot teaches **cybersecurity awareness** while also helping the user stay **organized**.

---

##  Challenges Experienced
- Linking multiple input boxes for different features.
- Ensuring quiz logic and task management don’t conflict.
- Handling WPF layout errors and unsupported properties.
- Keeping the GUI simple but functional.

---

##  Skills Developed
- Object-oriented programming in a GUI environment.
- WPF interface design and event handling.
- Task management and logging features.
- Debugging and troubleshooting in Visual Studio.
- GitHub version control and CI/CD workflows.

---

##  Future Improvements
- Add multiple quiz questions with scoring.
- Allow tasks to include descriptions and due dates.
- Save tasks and logs to a file or database.
- Improve the interface with labels or watermarks for input boxes.
- Add user login and personalized task lists.

---

##  License
This project is intended for educational purposes only.  
You are free to study and adapt it for learning.
