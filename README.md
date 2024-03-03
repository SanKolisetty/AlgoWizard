# AlgoWizard

![Banner](./banneraiimg.jpg)

AlgoWizard is a software application designed to educate students on the fundamental concepts of “Data Structures” through interactive learning modules, visuals, and quizzes to improve comprehension and engagement. Basic topics like Searching, Sorting, Arrays, Stacks, Queues, Linked Lists, and so on have been covered.

This application has been built as a Windows Forms application in VB.NET. It uses MySQL for data storage and retrieval. This project has been made as a part of the course CS346: Software Engineering Laboratory, Spring 24.

# Table of Contents

- [AlgoWizard](#algowizard)
- [Table of Contents](#table-of-contents)
- [Brief Overview](#brief-overview)
- [Demo](#demo)
- [Dependencies](#dependencies)
- [Installation](#installation)
- [Data Sources](#data-sources)
- [Model](#model)
- [Testing and Evaluation](#testing-and-evaluation)
- [Deployment](#deployment)

# Brief Overview
[(Back to top)](#table-of-contents)

The goal is to develop a user-friendly software solution that provides organized learning modules on a variety of data structures and algorithms. To make learning easier, the program includes step-by-step explanations, visual aids, and interactive aspects. Quizzes and assessments have been implemented to test students’ understanding and encourage learning.

Key features of the Data Structures Learning Software include:

  - Step-by-step explanations of fundamental data structure concepts.
  - Interactive learning modules with visualizations and demonstrations.
  - Quizzes to test comprehension and reinforce learning.
  - Progress tracking to monitor learning achievements over time.

The Data Structures Learning Software covers the following topics:

  - Searching Algorithms which include Bubble, Insertion and Merge Sort
  - Sorting Algorithms which include Linear and Binary Search
  - Arrays
  - Stacks
  - Queues
  - Linked Lists
    
Each learning module includes instructional content, interactive demonstrations, and quizzes tailored to the specific topic.

# Demo
[(Back to top)](#table-of-contents)

Here is a short demo of the deployed web application.

https://github.com/SanKolisetty/AI-Image-Classifier/assets/95172001/0ebe3ffb-4afe-4a7b-96d3-80ce5e7ce99f

# Dependencies
[(Back to top)](#table-of-contents)
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
The repository has been cloned in your folder. Now, we need to install the dependences. Please note that we were instructed to implement this project in Visual Studio 2010. We have used MySQL for creating databases required. Thus, install MySQL from this [link](https://dev.mysql.com/downloads/installer/) considering the requirements of your PC.

After MySQL has been installed, create the database as instructed in the SQL query uploaded in the repository.

To connect the Windows Application Form with the database in MySQL, we require MySQL Connector/NET which can be downloaded from [here](https://downloads.mysql.com/archives/c-net/). Since we had to use Visual Studio 2010, the version of the connector that works with this is 6.5.4. After installing the connector, we need to create the connection between the database and the current project. For this, open the .sln file using Visual Studio 2010 and right-click on the folder of the project and the drop-down menu given below will be shown.

![file_2024-03-03_15 01 03](https://github.com/SanKolisetty/AlgoWizard/assets/95172001/3a505397-0619-4a66-b48f-b3bb79ab147b)

Now, click on `Add Reference` and go to `Browse`. Now follow this path

```shell
  C:\Program Files (x86)\MySQL\MySQL Connector Net 6.5.4\Assemblies\v4.0
```
and select `MySQL.Data.dll`. This creates the connection we require between the Database and the Windows Application Form.

The software is all set up to run.

# Database Schema
- The database schema includes a table named queue containing quiz questions and options.
- It also includes a table named users to store user information and quiz progress.

