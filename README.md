# AlgoWizard

![Banner](./banneraiimg.jpg)

AlgoWizard is a software application designed to educate students on the fundamental concepts of “Data Structures” through interactive learning modules, visuals, and quizzes to improve comprehension and engagement. Basic topics like Searching, Sorting, Arrays, Stacks, Queues, Linked Lists, and so on have been covered.

This application has been built as a Windows Forms application in VB.NET. It uses MySQL for data storage and retrieval. This project has been made as a part of the course CS346: Software Engineering Laboratory, Spring 24.

# Table of Contents

- [AlgoWizard](#algowizard)
- [Table of Contents](#table-of-contents)
- [Brief Overview](#brief-overview)
- [Demo](#demo)
- [Installation](#installation)
- [Data Sources](#data-sources)
- [Model](#model)
- [Testing and Evaluation](#testing-and-evaluation)
- [Deployment](#deployment)

# Brief Overview
[(Back to top)](#table-of-contents)

Key features of the Data Structures Learning Software include:

  - Step-by-step explanations of fundamental data structure concepts.
  - Interactive learning modules with visualizations and demonstrations.
  - Quizzes to test comprehension and reinforce learning.
  - Progress tracking to monitor learning achievements over time.

The Data Structures Learning Software covers the following topics:

  - Searching Algorithms
  - Sorting Algorithms
  - Arrays
  - Stacks
  - Queues
  - Linked Lists
  - Trees
  - Graphs
    
Each learning module includes instructional content, interactive demonstrations, and quizzes tailored to the specific topic.

# Demo
[(Back to top)](#table-of-contents)

Here is a short demo of the deployed web application.

https://github.com/SanKolisetty/AI-Image-Classifier/assets/95172001/0ebe3ffb-4afe-4a7b-96d3-80ce5e7ce99f

# Dependencies
- *System.Windows.Forms*: Provides classes for creating Windows-based applications.
- *MySql.Data.MySqlClient*: Enables interaction with MySQL databases.
- *MySQL Connector/NET*: The code imports MySql.Data.MySqlClient for MySQL database connectivity.

# Installation
[(Back to top)](#table-of-contents)

Open Git Bash and change the directory to the location where the repository is to be cloned. Then, type the following commands.

```shell
  git init
```
```shell
  git clone https://github.com/SanKolisetty/AlgoWizard.git
```
Now, install mysql using the following link

[MySQL installer](https://dev.mysql.com/downloads/installer/)

Database write by Sanjana

Execute the following code in terminal

```shell
  .\Assignment_2_8B\bin\Debug\Assignment_2_8B.exe

```
Finally, login or sign-up according to your requirements.

# Database Schema
- The database schema includes a table named queue containing quiz questions and options.
- It also includes a table named users to store user information and quiz progress.

# Code Structure

The code for modularity purposes is divided into the following classes

## Class: array

### Classes and Structures
1. *Array Class*:
   - This class represents the main form of the application.
   - It contains methods and event handlers for array manipulation, quiz handling, and UI interactions.

2. *Question Class*:
   - This is a nested class within the Array class.
   - It represents a quiz question with text, options, and correct answer properties.

### UI Components
1. *RichTextBox*: Used for displaying formatted text, such as code snippets and instructions.
2. *Labels*: Used for displaying array elements and index labels.
3. *Text Boxes*: Used for user input, such as array size, element values, and indices.
4. *Radio Buttons*: Used for selecting quiz options.
5. *Buttons*: Used for triggering various actions like array manipulation, quiz navigation, and submission.

### Methods and Functions
- *DisplaySubstringInDifferentFont*: Formats a specified substring within a RichTextBox control with a different font.
- *HighlightText*: Highlights specified text within a RichTextBox control.
- *BoldText*: Makes specified text within a RichTextBox control bold.
- *Load*: Initializes the form, sets default values for text boxes, and loads quiz questions.
- *declare_array_Click*: Handles the click event for declaring arrays based on user input.
- *initialize_Click*: Handles the click event for initializing array elements based on user input.
- *insert_Click*: Handles the click event for inserting elements into arrays based on user input.
- *clear_Click*: Handles the click event for clearing array elements and UI components.
- *LoadQuizQuestions*: Loads quiz questions from a MySQL database.
- *GetRandomQuestions*: Selects a random subset of quiz questions.
- *DisplayQuestion*: Displays quiz questions and options based on the current question index.
- *UpdateQuestionNumberDisplay*: Updates the display for the current question number out of total questions.
- *rbOption_CheckedChanged*: Handles radio button selection events for quiz options.
- *btnPrev_Click*: Handles the click event for navigating to the previous quiz question.
- *btnNext_Click*: Handles the click event for navigating to the next quiz question.
- *btnSubmit_Click*: Handles the click event for submitting quiz answers and displaying results.
- *ShowQuizResults*: Calculates and displays quiz results.
- *ShowQuizSection*: Displays the quiz section of the application.

### Usage:
- The application provides a GUI interface for users to interact with a array and take a quiz.
- Users can interact with various UI components to manipulate arrays, take quizzes, and navigate through quiz questions.
- They can also navigate through a series of quiz questions and submit their answers, which is then updated in their profile.

## Class: queue

### Attributes:
- queue: A Queue data structure to store integer values.
- questions: A List to hold quiz questions.
- userAnswers: A Dictionary to store user answers for the quiz.
- currentQuestionIndex: An integer representing the index of the current quiz question.

### Methods and Functions:

1. *Button1_Click*: Navigates back to the main menu form.
2. *Form2_Load*: Initializes UI elements and displays the quiz section.
3. *ShowQuizSection*: Resets quiz-related variables and loads quiz questions.
4. *LoadQuizQuestions*: Retrieves quiz questions from the database.
5. *GetRandomQuestions*: Selects a random subset of questions.
6. *DisplayQuestion*: Displays the current quiz question and options.
7. *UpdateQuestionNumberDisplay*: Updates the display of the current question number.
8. *rbOption_CheckedChanged*: Updates the user's answer when a radio button is selected.
9. *btnPrev_Click* and *btnNext_Click*: Navigates between quiz questions.
10. *btnSubmit_Click*: Displays the quiz results.
11. *queue_FormClose*: Handles form close event and navigates back to the main menu form.
12. *queue_back_Click*: Handles the "Back" button click event.
13. *Button2_Click*: Triggers the display of the quiz section.
14. *EnqueueButton_Click, **DequeueButton_Click, **FrontButton_Click, **ClearButton_Click, **RearButton_Click*: Handle queue operations.
15. *UpdateQueueDisplay*: Updates the display of the queue.
16. *GetRear*: Retrieves the rear element of the queue.
17. *TextBox_GotFocus* and *TextBox_LostFocus*: Manage text boxes' focus behavior.
18. *PictureBox1_Click*: Navigates to the profile form.

### Usage:
- The application provides a GUI interface for users to interact with a queue and take a quiz.
- Users can enqueue, dequeue, view the front and rear elements, and clear the queue.
- They can also navigate through a series of quiz questions and submit their answers.
- Quiz results are stored in the users table in the database.

## Class: stack

### Attributes:
- stack: An instance of the LimitedSizeStack(Of Integer) class, used to store integer values in a stack with a maximum size of 9.
 - _maxSize: An integer representing the maximum size of the stack.
- _stack: An instance of the Stack(Of T) class used to store elements.
  
### Methods:
1. *Button1_Click*: Event handler for the button responsible for navigating to the main menu form.
2. *Button2_Click*: Event handler for the button responsible for pushing a value onto the stack.
3. *Button3_Click*: Event handler for the button responsible for popping a value from the stack.
4. *Button4_Click*: Event handler for the button responsible for peeking at the top value of the stack.
5. *UpdateStackDisplay*: Updates the display of stack elements on the form.
6. *Form2_Load*: Event handler for loading the form; initializes form elements and loads the quiz section.
7. *Button5_Click*: Event handler for the button responsible for clearing the stack.
8. *LoadQuizQuestions*: Loads quiz questions from a MySQL database.
9. *GetRandomQuestions*: Selects a random subset of questions from the loaded questions.
10. *DisplayQuestion*: Displays a quiz question on the form.
11. *UpdateQuestionNumberDisplay*: Updates the display of the current question number.
12. *rbOption_CheckedChanged*: Event handler for radio button selection in the quiz section.
13. *btnPrev_Click*: Event handler for the "Previous" button click in the quiz section.
14. *btnNext_Click*: Event handler for the "Next" button click in the quiz section.
15. *btnSubmit_Click*: Event handler for the "Submit" button click in the quiz section.
16. *ShowQuizResults*: Calculates and displays quiz results.
17. *ShowQuizSection*: Displays the quiz section of the form.
18. *txtInput_GotFocus, **txtInput_LostFocus, **popTextBox_GotFocus, **popTextBox_LostFocus, **PeekTextBox_GotFocus, **PeekTextBox_LostFocus*: Event handlers for text box focus events.

#### Testing




#### Further Scope






