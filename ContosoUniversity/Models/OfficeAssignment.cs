using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        #region The Key attribute
        /* URL: https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/complex-data-model?view=aspnetcore-6.0
            - There's a one-to-zero-or-one relationship between the 
              Instructor and the OfficeAssignment entities.
            - An office assignment only exists in relation to the instructor 
              it's assigned to, and therefore its primary key is also 
              its foreign key to the Instructor entity.
            - But the Entity Framework can't automatically recognize 
              InstructorID as the primary key of this entity because 
              its name doesn't follow the ID or classnameID naming convention.
            - Therefore, the Key attribute is used to identify it as the key
         */
        #endregion
        [Key]
        public int InstructorID { get; set; }
        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }

        #region The Instructor navigation property
        /*
            -- The Instructor entity has a nullable OfficeAssignment navigation property 
                (because an instructor might not have an office assignment), 
            -- and the OfficeAssignment entity has a non-nullable 
                Instructor navigation property 
                (because an office assignment can't exist without an instructor 
            -- InstructorID is non-nullable). 
                When an Instructor entity has a related OfficeAssignment entity, 
                each entity will have a reference to the other one in its navigation property. 
         */
        #endregion
        public Instructor Instructor { get; set; }
    }
}
