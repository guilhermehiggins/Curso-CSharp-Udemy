using System.Collections.Generic;
namespace ExerciciosConjuntos.Entities
{
    class Course
    {
        public Student Students { get; set; }

        public Course(Student student)
        {
            Students = student;
        }
        public override int GetHashCode()
        {
            return Students.Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Course))
            {
                return false;
            }

            Course other = obj as Course;
            return Students.Id.Equals(other.Students.Id);
        }
    }
}
