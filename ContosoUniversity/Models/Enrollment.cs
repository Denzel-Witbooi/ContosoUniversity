namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        /// <summary>
        /// The EnrollmentID property is the PK
        /// </summary>
        public int EnrollmentID { get; set; }

        /// <summary>
        /// The CourseID property is a FK
        /// </summary>
        public int CourseID { get; set; }

        /// <summary>
        /// The StudentID property is a foreign key (FK)
        /// </summary>
        public int StudentID { get; set; }

        /// <summary>
        /// The ? after the Grade type declaration indicates that the 
        /// Grade property is nullable
        /// null means a grade isn't known or hasn't been assigned yet.
        /// </summary>
        public Grade? Grade { get; set; }

        /// <summary>
        /// An Enrollment entity is associated with one Course entity
        /// </summary>
        public Course Course { get; set; }

        /// <summary>
        /// the property can only hold a single Student entity
        /// </summary>
        public Student Student { get; set; }
    }
}
