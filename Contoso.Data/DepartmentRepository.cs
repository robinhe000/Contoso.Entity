using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    class DepartmentRepository : Repository<Department> , IDepartment
    {
    }
    public interface IDepartmentRepository : IRepository
}
