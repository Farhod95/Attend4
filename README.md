![Console App Demo](Assets/animation.gif)
# Attend4 Console Application

**Attend4** — bu talabalarning darsga qatnashgan vaqtlarini hisoblaydigan C# Console dasturidir.  
Dasturda `ExternalAttendance` ma'lumotlari asosida `StudentAttend` ro'yxati shakllantiriladi va turli ko‘rinishlarda konsolga chiqariladi.

---

## 📂 Loyihaning tarkibi

| Layer | Description |
|-------|-------------|
| **Attend4.Domain** | Model (Entity) classlar saqlanadi |
| **Attend4.Infrastructure** | Soxta (Fake/In-Memory) DbContext ma'lumotlar bazasi |
| **Attend4.Application** | Business logic: Students va External Attendance service |
| **Attend4.Client** | Konsol orqali foydalanuvchi interfeysi |

---

## 🧩 Model classlar

### `StudentAttend`
- Id
- FirstName
- LastName
- Email
- FirstEntryTime
- LastExitTime
- ParticipationMinutes (umumiy qatnash vaqti)

### `ExternalAttendance`
- FullNameWithId (Ism Familiya va ID)
- Email
- EnterDate
- ExitDate
- Duration (minut)
- IsHost
- IsWaiting

---

## 🗄 DbContext ishlash mantig‘i

Dastur ishga tushganda:

1️⃣ `ExternalAttendance` ma'lumotlari qo‘lda ro‘yxatga qo‘shiladi  
2️⃣ Har bir external record parsing qilinadi:

```text
FullNameWithId → FirstName, LastName, Id
