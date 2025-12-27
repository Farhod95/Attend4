using Attend4.Domain.Models;

namespace Attend4.Infrastructure.Data
{
    public class DbContext
    {
        public List<StudentAttend> StudentAttends { get; set; }
        public List<ExternalAttendance>  ExternalAttendances { get; set; }

        public DbContext()
        {
            this.ExternalAttendances = new List<ExternalAttendance>();
            this.StudentAttends = new List<StudentAttend>();

            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Elbek Normurodov 0001", Email = "normurodovelbek0133@gmail.com", EnterDate = DateTime.Parse("2025-12-20 07:03:00"), ExitDate = DateTime.Parse("2025-12-20 07:29:03"), Duration = 26, IsHost = "Нет", IsWaiting = "Нет" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Jamkhan Aliyev 1471", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:04:55"), ExitDate = DateTime.Parse("2025-12-20 07:05:28"), Duration = 1, IsHost = "Да", IsWaiting = "Да" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Jamkhan Aliyev 1471", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:05:28"), ExitDate = DateTime.Parse("2025-12-20 08:07:28"), Duration = 62, IsHost = "Да", IsWaiting = "Нет" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Пользователь Zoom 0000", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:06:23"), ExitDate = DateTime.Parse("2025-12-20 07:06:36"), Duration = 1, IsHost = "Да", IsWaiting = "Да" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Sardor Familiya 9999", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:06:28"), ExitDate = DateTime.Parse("2025-12-20 07:06:37"), Duration = 1, IsHost = "Да", IsWaiting = "Да" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Пользователь Zoom 0000", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:06:36"), ExitDate = DateTime.Parse("2025-12-20 07:07:20"), Duration = 1, IsHost = "Да", IsWaiting = "Нет" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Sardor Familiya 9999", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:06:37"), ExitDate = DateTime.Parse("2025-12-20 08:07:28"), Duration = 61, IsHost = "Да", IsWaiting = "Нет" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Durbek Kanalbekov 5945", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:06:38"), ExitDate = DateTime.Parse("2025-12-20 07:07:31"), Duration = 1, IsHost = "Да", IsWaiting = "Да" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Farhod Isomiddinov 1110", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:07:24"), ExitDate = DateTime.Parse("2025-12-20 07:07:33"), Duration = 1, IsHost = "Да", IsWaiting = "Да" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Tohirjon Isomiddinov 1111", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:07:31"), ExitDate = DateTime.Parse("2025-12-20 07:07:43"), Duration = 1, IsHost = "Да", IsWaiting = "Да" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Durbek Kanalbekov 5945", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:07:32"), ExitDate = DateTime.Parse("2025-12-20 08:07:27"), Duration = 60, IsHost = "Да", IsWaiting = "Нет" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Farhod Isomiddinov 1110", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:07:33"), ExitDate = DateTime.Parse("2025-12-20 08:07:27"), Duration = 60, IsHost = "Да", IsWaiting = "Нет" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Mukhammad Familiya 5674", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:07:34"), ExitDate = DateTime.Parse("2025-12-20 07:07:43"), Duration = 1, IsHost = "Да", IsWaiting = "Да" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Mukhammad Familiya 5674", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:07:44"), ExitDate = DateTime.Parse("2025-12-20 07:21:21"), Duration = 14, IsHost = "Да", IsWaiting = "Нет" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Tohirjon Isomiddinov 1111", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:07:44"), ExitDate = DateTime.Parse("2025-12-20 08:07:28"), Duration = 60, IsHost = "Да", IsWaiting = "Нет" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Eldorbek Ro'ziyev 1244", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:08:17"), ExitDate = DateTime.Parse("2025-12-20 07:08:23"), Duration = 1, IsHost = "Да", IsWaiting = "Да" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Eldorbek Ro'ziyev 1244", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:08:23"), ExitDate = DateTime.Parse("2025-12-20 08:07:28"), Duration = 60, IsHost = "Да", IsWaiting = "Нет" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "sevinch umirzoqovas 8200", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:09:27"), ExitDate = DateTime.Parse("2025-12-20 07:09:35"), Duration = 1, IsHost = "Да", IsWaiting = "Да" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "sevinch umirzoqovas 8200", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:09:36"), ExitDate = DateTime.Parse("2025-12-20 08:07:28"), Duration = 58, IsHost = "Да", IsWaiting = "Нет" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Azimjon Ergashev 8747", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:11:13"), ExitDate = DateTime.Parse("2025-12-20 07:11:25"), Duration = 1, IsHost = "Да", IsWaiting = "Да" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Azimjon Ergashev 8747", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:11:26"), ExitDate = DateTime.Parse("2025-12-20 08:07:27"), Duration = 57, IsHost = "Да", IsWaiting = "Нет" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Mohinur Muhammadjonova 2965", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:16:31"), ExitDate = DateTime.Parse("2025-12-20 07:16:51"), Duration = 1, IsHost = "Да", IsWaiting = "Да" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Mohinur Muhammadjonova 2965", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:17:03"), ExitDate = DateTime.Parse("2025-12-20 08:07:27"), Duration = 51, IsHost = "Да", IsWaiting = "Нет" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Mukhammad Familiya 5674", Email = "", EnterDate = DateTime.Parse("2025-12-20 07:21:43"), ExitDate = DateTime.Parse("2025-12-20 08:07:28"), Duration = 46, IsHost = "Да", IsWaiting = "Нет" });
            ExternalAttendances.Add(new ExternalAttendance { FullNameWithId = "Elbek Normurodov 0001", Email = "normurodovelbek0133@gmail.com", EnterDate = DateTime.Parse("2025-12-20 07:28:48"), ExitDate = DateTime.Parse("2025-12-20 08:07:16"), Duration = 39, IsHost = "Нет", IsWaiting = "Нет" });

            foreach (var item in ExternalAttendances)
            {
                var value = item.FullNameWithId.Split(" ");
                var id = value[2];
                var firstName = value[0];
                var lastName = value[1];

                var myNewStudentId = StudentAttends.FirstOrDefault(x => x.Id==id);

                if (myNewStudentId != null)
                {
                    myNewStudentId.ParticipationMinutes += item.Duration;

                    if (myNewStudentId.FirstEntryTime > item.EnterDate)
                    {
                        myNewStudentId.FirstEntryTime = item.EnterDate;
                    }
                    if (myNewStudentId.LastExitTime < item.ExitDate)
                    {
                        myNewStudentId.LastExitTime = item.ExitDate;
                    }
                }
                else
                {
                    StudentAttends.Add(new StudentAttend
                    {
                        Id = id,
                        FirstName = firstName,
                        LastName = lastName,
                        Email = item.Email,
                        FirstEntryTime = item.EnterDate,
                        LastExitTime = item.ExitDate,
                        ParticipationMinutes = item.Duration,
                    });
                }

            }
        }
    }
}
