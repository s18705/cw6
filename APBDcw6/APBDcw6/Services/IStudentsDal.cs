using APBDcw6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBDcw6.Services
{
    interface IStudentsDal
    {
        //Data Acces Layer

        public IEnumerable<Student> GetStudents();
        public List<Enrollment> GetEnrollment(string idStudenta);
    }
}
