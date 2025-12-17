## 🏥 Pharmacy Queue Management System
A full-stack application built with C#, .NET Core, Angular 19, and SQL Server, designed to efficiently manage queues in a pharmacy.

---

## 📌 Features

* **🧑‍💻 Role-based interfaces:**

  * 👤 User Interface – for customers to view queue status and join the queue.

  * 💊 Pharmacist Interface – for managing the queue and serving customers.

  * 🛠️ Admin Interface – for managing users, pharmacists, and system settings.

* **⏱️ Real-time queue management:**

  * ⚡ Instant updates – Queue updates happen instantly.

  * 🔄 Asynchronous handling – Asynchronous entry and exit handling.

  * 🌐 Synchronization – Across all interfaces to ensure up-to-date information.

* **🔒 Authentication & Security:**

  * 🛡️ JWT Token-based authentication for secure login and role-based access control.

* **🗄️ Database:**
  * 💾 SQL Server backend for reliable and scalable data storage.

  * 📊 Stores queue data, user information, and role-specific data.

---

## ⚙️ Technology Stack

**Backend:** C# with .NET Core

**Frontend:** Angular 19

**Database:** SQL Server

**Security:** JWT Token authentication

---

## 💻 Screenshots / Demo

🌐 https://github.com/milkaBlumer/pharmacyQueueManagement

---

## 🛠️ Installation & Setup

Clone the repository:

git clone <repo-link>


Set up the SQL Server database and update the connection string in appsettings.json.

---

**Run the backend:**

dotnet run


**Navigate to the Angular frontend folder and run:**

npm install
ng serve


Open the application at http://localhost:4200.

---

## **🚀 Usage**
Users can join the queue and see their position in real-time.

Pharmacists can manage the queue and serve customers efficiently.

Admins can monitor the system, manage users, and configure settings.

All actions are secured via JWT Token authentication.

---

## ❤️ Acknowledgements

Thank you for checking out this project! I hope it demonstrates clean architecture, real-time capabilities, secure authentication, and practical full-stack development skills.
