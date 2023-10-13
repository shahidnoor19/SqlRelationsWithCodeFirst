namespace learningRelationInEFCore.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int GradeId { get; set; }
        public virtual Grade Grade { get; set; }


        //public StudentAddress Address { get; set; }
        //public Grade Grade { get; set; }
        //public IList<StudentCourse> StudentCourses { get; set; }

    }
}
