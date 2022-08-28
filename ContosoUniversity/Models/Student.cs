using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        /// <summary>
        /// The ID property is the primary key (PK) column
        /// </summary>
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        /// <summary>
        /// The Enrollments property is a navigation property.
        /// </summary>
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
