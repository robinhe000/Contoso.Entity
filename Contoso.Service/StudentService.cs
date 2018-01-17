using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service
{
    class StudentService:IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public IEnumerable<Student> GetStudents()
        {
            return _studentRepository.GetAll();
        }

        public interface IStudentService
        {
            IEnumerable<Student> GetStudent();
            Student GetStudentByLastName(string lastname);
        }
    }
}
