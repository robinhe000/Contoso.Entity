using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ContosoDbContext context) : base(context)
        {
            var student = _context.People.OfType<Student>().FirstOrDefault(s => s.FirstName)
            return student
        }
    }
    public interface IStudentRepository : IRepository<Student>
    {

    }
}
