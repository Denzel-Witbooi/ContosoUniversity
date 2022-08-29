using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        /// <summary>
        /// This attribute allows entering the PK for 
        /// the course rather than having the database generate it.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }
        #region Modify Course entity
        /*
            The course entity has a foreign key property DepartmentID 
            which points to the related Department entity and it 
            has a Department navigation property.
         */
        #endregion
        #region Foreign key and navigation properties
        /*
           -- A course is assigned to one department, 
                so there's a DepartmentID foreign key and a 
                 Department navigation property
           -- A course can have any number of students enrolled in it, 
                so the Enrollments navigation property is a collection
         */
        #endregion
        public int DepartmentID { get; set; }

        public Department Department { get; set; }


        public ICollection<Enrollment> Enrollments { get; set; }

        /*
         * A course may be taught by multiple instructors, 
         * so the CourseAssignments navigation property is a collection
         */
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
    }
}
