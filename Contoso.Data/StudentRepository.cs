using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public DbContext db;
     
        public StudentRepository(ContosoDbContext context) : base(context)
        {
            db = context;
        }
    }
    public interface IStudentRepository : IRepository<Student>
    {

    }
}
