using Attend4.Application.Service;

namespace Attend4.Client
{
    internal class Program
    {
        public StudentService myStudent {  get; set; }
        public ExternalService myExternal { get; set; }
        public Program()
        {
            this.myStudent = new StudentService();
            this.myExternal = new ExternalService();
        }
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("===============================================");
            Console.WriteLine("           XUSH KELIBSIZ!");
            Console.WriteLine("===============================================");
            var program = new Program();
            program.Run();
        }

        public void Run()
        {
            bool savol = false;
            while (!savol)
            { 
                savol = true;
                Console.WriteLine();
                Console.WriteLine("===============================================");
                Console.WriteLine("                 MENU");
                Console.WriteLine("===============================================");
                Console.WriteLine(" 1. ExternalAttendance ro‘yxatini chiqarish");
                Console.WriteLine(" 2. StudentAttend ro‘yxatini chiqarish");
                Console.WriteLine(" 3. Studentlar ism & familiyasini chiqarish");
                Console.WriteLine(" 4. Ko‘p qatnashgan talabalarni saralash");
                Console.WriteLine("===============================================");
                Console.Write(" Amalni tanlang: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.WriteLine();
                            myExternal.GetAllExternal();
                            Console.WriteLine();
                            if (myStudent.QaytaIshgaTushir()) { savol = false; continue; }
                            else { continue; }                                
                        }
                    case "2":
                        {
                            Console.WriteLine();
                            myStudent.GetAllStudent();
                            Console.WriteLine();
                            if (myStudent.QaytaIshgaTushir()) { savol = false; continue; }
                            else { continue; }
                        }
                    case "3":
                        {
                            Console.WriteLine();
                            myStudent.IsmFamiliyaChiqar();
                            Console.WriteLine();
                            if (myStudent.QaytaIshgaTushir()) { savol = false; continue; }
                            else { continue; }
                        }
                    case "4":
                        {
                            Console.WriteLine();
                            myStudent.EngKOpdasrgaQatnashgan();
                            Console.WriteLine();
                            if (myStudent.QaytaIshgaTushir()) { savol = false; continue; }
                            else { continue; }
                        }
                    default:
                        {
                            Console.WriteLine(" !!! Noto‘g‘ri amal tanlandi !!! ");
                            if (myStudent.QaytaIshgaTushir()) { savol = false; continue; }
                            else { continue; }
                        }
                }
            }            
        }
    }
}
