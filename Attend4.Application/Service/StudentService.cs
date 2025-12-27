namespace Attend4.Application.Service
{
    public class StudentService:DbContextObekt
    {
        public bool QaytaIshgaTushir()
        {
            Console.Write(" Dasturni qayta ishga tuhsirishni istaysizmi? (yes/no): ");
            return Console.ReadLine().ToLower() == "yes";
        }

        public void GetAllStudent()
        {
            foreach (var item in this._DbContext.StudentAttends)
            {
                Console.WriteLine($" Id = {item.Id}, FirstName = {item.FirstName}, LastName = {item.LastName}, Email = {item.Email}, FirstEntryTime = {item.FirstEntryTime}, LastExitTime = {item.LastExitTime}, ParticipationMinutes = {item.ParticipationMinutes} ");
            }
        }

        public void IsmFamiliyaChiqar()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("         ISM VA FAMILIYALAR");
            Console.WriteLine("===============================================");

            var newListStudent = this._DbContext.StudentAttends.OrderBy(x => x.FirstName).ToList();
            foreach (var item in newListStudent)
            {
                Console.WriteLine($"{item.Id}  |  {item.FirstName} {item.LastName}");
            }

            Console.WriteLine("===============================================");
        }


        public void EngKOpdasrgaQatnashgan()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("     ENG KO‘P QATNASHGAN TALABALAR");
            Console.WriteLine("===============================================");

            var newListStudent = this._DbContext.StudentAttends.OrderByDescending(x => x.ParticipationMinutes).ToList();
            foreach (var item in newListStudent)
            {
                Console.WriteLine($"{item.FirstName,-20} | {item.ParticipationMinutes} min");
            }

            Console.WriteLine("===============================================");
        }

    }
}
