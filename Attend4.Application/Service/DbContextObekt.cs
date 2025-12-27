using Attend4.Infrastructure.Data;

namespace Attend4.Application.Service
{
    public class DbContextObekt
    {
        public DbContext _DbContext {  get; set; }
        public DbContextObekt()
        {
            this._DbContext = new DbContext();
        }
    }
}
