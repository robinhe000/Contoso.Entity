using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
     public class PersonRepository : Repository<People>, IPersonRepository
    {
        public PersonRepository(ContosoDbContext context) : base(context)
        {
        }

        public People GetByLastName(string lastname) 
        {
            var person = _context.People.Where(p => p.LastName == lastname).FirstOrDefault();
                return person;
        }
         
    }
    public interface IPersonRepository : IRepository<People>
    {

    }
}