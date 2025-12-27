namespace Attend4.Application.Service
{
    public class ExternalService:DbContextObekt
    {
        public void GetAllExternal()
        {
            foreach (var item in this._DbContext.ExternalAttendances)
            {
                Console.WriteLine($" FullNameWithCode = {item.FullNameWithId}, Email = {item.Email}, EnterDate = {item.EnterDate}, ExitDate = {item.ExitDate}, Duration = {item.Duration}, IsHost = {item.IsHost}, IsWaiting = {item.IsWaiting}");
            }
        }
    }
}
