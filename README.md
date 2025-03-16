# 🎯 Project Management System

A **web-based project management system** built with **ASP.NET Web Forms (C#) and SQL Server** to manage students, advisors, projects, and evaluations efficiently. The system enables CRUD operations on students, projects, advisors, groups, and evaluations with report generation.

## 🚀 Features

✅ **Student Management** – Add, delete, and list students  

✅ **Advisor Management** – Manage advisors, co-advisors, and industry advisors  

✅ **Project Management** – Create, delete, and list projects  

✅ **Group Creation & Management** – Assign students to projects and advisors  

✅ **Evaluation System** – Record and manage project evaluations  

✅ **Report Generation** – Generate and download reports in PDF format  

✅ **Master Page Layout** – Unified UI across all pages  

---

## 🏗️ Tech Stack

- **Frontend**: ASP.NET Web Forms (C#)
  
- **Backend**: C# (Code-behind)
  
- **Database**: Microsoft SQL Server#
  
- **Tools**: iTextSharp (for PDF reports)
  
- **Hosting**: Local IIS / Visual Studio Debugging  

---

## 🔧 Installation & Setup

### **1️⃣ Clone the Repository**
```sh
git clone https://github.com/your-username/ProjectManagementSystem.git

cd ProjectManagementSystem


2️⃣ Open in Visual Studio

Open WebSite5.sln in Visual Studio.

Restore NuGet Packages if needed.


3️⃣ Configure Database

Open SQL Server Management Studio (SSMS).

Create a database named ProjectManagement.

Run the provided SQL scripts (DatabaseSetup.sql) to create tables.


4️⃣ Update Connection String

Edit Web.config:

<connectionStrings>

    <add name="ProjectManagementDb" connectionString="Data Source=localhost\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True"/>

</connectionStrings>

