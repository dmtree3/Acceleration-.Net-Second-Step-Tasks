using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class QueryMethods
    {
        private readonly MyDbContext _dbContext;

        public QueryMethods(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Teacher[] GetAllTeachersByStudent(string studentName)
        {
            var teachers = _dbContext.Teachers
                .Where(teacher => teacher.TeacherPupils
                .All(tp => tp.Pupil.FirstName == studentName))
                .ToArray();

            return teachers;
        }
    }
}
