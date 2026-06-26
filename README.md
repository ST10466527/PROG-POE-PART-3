# CyberSecurity Awareness Chatbot – PROG POE Part 3 (2026)

## Project Overview

The **CyberSecurity Awareness Chatbot – Part 3** is a WPF-based application developed in **C# using .NET 8.0**.  
This version builds on the Part 2 console chatbot by introducing a graphical interface, task management, and activity logging.  

The application continues to promote cybersecurity awareness while adding practical features for user interaction and organization.

---

## Objectives of Part 3

The main objectives of this project were to:

* Upgrade the chatbot from a console app to a WPF GUI
* Improve user interaction with buttons and input fields
* Implement task management alongside the quiz feature
* Record user actions in an activity log with timestamps
* Demonstrate object-oriented programming in a GUI environment

---

## Features Implemented in Part 3

### Graphical User Interface (GUI)

The chatbot now runs in a WPF window with a chat display, input boxes, and interactive buttons.

### QuizMiniGame

The bot asks cybersecurity questions and checks answers with instant feedback, teaching safe online habits.

### TaskManager

Users can add tasks, view them later, and log activities. Each action is recorded with a timestamp.

### Activity Log

Shows all actions taken by the user, including quiz starts and task management events.

### Interactive Buttons

* **Send** → Submit quiz/chat answers  
* **Add Task** → Add a new task  
* **View Tasks** → Show all tasks  
* **Start Quiz** → Begin a cybersecurity quiz  
* **Show Log** → Display activity history  

---

## Technologies Used

| Technology | Purpose |
|------------|---------|
| **C#** | Main programming language |
| **.NET 10.0** | Application framework |
| **WPF (Windows Presentation Foundation)** | GUI development |
| **Visual Studio 2022** | Development environment |
| **GitHub** | Version control and repository hosting |
| **GitHub Actions** | Continuous Integration (CI) |

---

## Project Structure

```text
PROG-POE-PART-3-2026/
│
├── ChatbotGUI.xaml        # Interface layout
├── ChatbotGUI.xaml.cs     # Code-behind for GUI
├── QuizMiniGame.cs        # Quiz logic
├── TaskManager.cs         # Task management and logging
├── ActivityLog.cs         # Stores log entries
├── PROG-POE-PART-3.csproj # Project file
└── README.md              # Documentation
```

---

## System Requirements

Before running the application, ensure the following are installed:

* .NET 10.0 SDK  
* Visual Studio 2022 or later  
* Windows Operating System  

---

## Installation and Setup

### 1. Clone the Repository

git clone http://github.com/ST10466527/PROG-POE-PART-3/tree/main
```

### 2. Open the Project

Open the project in:

* Visual Studio 2022  
  OR  
* Visual Studio Code with C# extensions  

### 3. Build and Run

```bash
dotnet build
dotnet run
```

---

## Example User Interaction

```text
========================================
 CYBERSECURITY AWARENESS CHATBOT (GUI)
========================================

Bot: Welcome to the Cybersecurity Awareness Chatbot!
Bot: Starting quiz...
Bot: What should you do if an email asks for your password?
Options: Reply, Delete, Report as phishing, Ignore

You: Report as phishing
Bot: Correct! Always report suspicious emails.
```

---

## GitHub Actions Workflow

This project includes a GitHub Actions workflow that automatically:

* Restores dependencies  
* Builds the application  
* Verifies successful compilation  

The workflow runs automatically whenever changes are pushed to the repository.

---

## Outcomes When Running

* The bot welcomes the user and starts a conversation.  
* Quiz answers are checked instantly, with feedback showing if the choice is safe or unsafe.  
* Tasks can be added and displayed in the chat window.  
* The activity log shows everything the user has done, with timestamps.  
* Overall, the chatbot teaches **cybersecurity awareness** while also helping the user stay **organized**.

---

## Challenges Experienced

* Linking multiple input boxes for different features  
* Ensuring quiz logic and task management don’t conflict  
* Handling WPF layout errors and unsupported properties  
* Keeping the GUI simple but functional  

---

## Skills Developed

* Object-oriented programming in a GUI environment  
* WPF interface design and event handling  
* Task management and logging features  
* Debugging and troubleshooting in Visual Studio  
* GitHub version control and CI/CD workflows  

---

## Future Improvements

* Add multiple quiz questions with scoring  
* Allow tasks to include descriptions and due dates  
* Save tasks and logs to a file or database  
* Improve the interface with labels or watermarks for input boxes  
* Add user login and personalized task lists  

---

## Screenshots
<img width="1918" height="1015" alt="image" src="https://github.com/user-attachments/assets/31ba42e3-5003-4860-ae60-ccff20ca3264" />


---

## Presentation Video
*(Insert link to demo video here)*

---

## Author

### Silindokuhle Makunga (ST10466527)

Second-Year Diploma in Software Development  
Cape Town, South Africa  

---

## Repository Link

`http://github.com/ST10466527/PROG-POE-PART-3/tree/main

---

## License

This project is intended for educational purposes only.

---

## Final Notes

The CyberSecurity Awareness Chatbot – Part 3 demonstrates how a console chatbot can be transformed into a GUI application.  
It showcases practical software development skills while promoting cybersecurity awareness in an interactive and engaging way.
```
