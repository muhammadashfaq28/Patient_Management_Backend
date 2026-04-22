# Week_7


# Patient Management API (Week 7)

## 📌 Project Overview

This project is an ASP.NET Core Web API built using Entity Framework Core. It focuses on understanding EF Core architecture, relationships, LINQ to SQL translation, and performance optimization techniques.

The API manages Patients and Appointments with proper layering and clean code practices.

---

## 🏗️ Architecture

The project follows a layered architecture:

Controller → Service → Repository → DbContext → Database

### Layers Description

* **Controller**: Handles HTTP requests and responses
* **Service**: Contains business logic and validation
* **Repository**: Handles database queries using EF Core
* **DbContext**: Manages database connection and mapping
* **DTOs**: Define clean API response structure

---

## ⚙️ Technologies Used

* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* LINQ
* Git & GitHub

---

## 📊 Database Entities

### Patient

* PatientId
* FirstName
* LastName
* Gender
* DateOfBirth
* City
* PhoneNumber
* Email

### Appointment

* AppointmentId
* AppointmentDate
* PatientId (FK)
* DoctorId (FK)

---

## 🔗 Relationships

* Patient → Appointments (1-to-Many)

---

## 🚀 API Endpoints

### 1. Get Patients with Appointments

GET /api/patient/with-appointments

### 2. Get Patients with No Appointments

GET /api/patient/no-appointments

### 3. Get Appointments by Doctor

GET /api/appointment/doctor/{doctorId}

---

## 📦 DTO Usage

DTOs are used to:

* Avoid exposing database entities
* Return only required data
* Improve performance

---

## 🔍 LINQ vs SQL

### Example 1: Appointments by Doctor

LINQ:

```csharp
.Where(a => a.DoctorId == doctorId)
```

SQL:

```sql
SELECT * FROM Appointments WHERE DoctorId = @doctorId
```

---

### Example 2: Patients with No Appointments

LINQ:

```csharp
.Where(p => !p.Appointments.Any())
```

SQL:

```sql
SELECT * FROM Patients p
LEFT JOIN Appointments a ON p.PatientId = a.PatientId
WHERE a.PatientId IS NULL
```

---

## ⚡ Performance Optimization

* Used AsNoTracking() for read-only queries
* Used Select() for projection (avoid over-fetching)
* Applied filtering before fetching data
* Avoided unnecessary tracking

---

## ⚠️ EF Core Learning Points

* Understanding DbContext lifecycle
* Entity configuration using Fluent API
* LINQ to SQL translation
* Avoiding ORM performance issues

---

## 🔐 Security

* Sensitive files excluded using .gitignore
* Connection strings not exposed

---

## 📝 Notes

* Draft Pull Request created for review
* Project demonstrates clean architecture and EF Core best practices

---

## 👨‍💻 Author

Developed as part of Week 7 EF Core assignment
