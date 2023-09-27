using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Subject { get; set; }

        public ICollection<TeacherPupil> TeacherPupils { get; set; }
    }

    public class Pupil
    {
        public int PupilId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Class { get; set; }

        public ICollection<TeacherPupil> TeacherPupils { get; set; }
    }

    public class TeacherPupil
    {
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int PupilId { get; set; }
        public Pupil Pupil { get; set; }
    }
}
