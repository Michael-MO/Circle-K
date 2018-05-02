namespace WebService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Masters = new HashSet<Master>();
        }

        [Key]
        public int EmployeeNo { get; set; }

        [StringLength(70)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Title { get; set; }

        [StringLength(70)]
        public string Address { get; set; }

        public int PostalCode { get; set; }

        [StringLength(15)]
        public string PhoneNo { get; set; }

        [StringLength(255)]
        public string Mail { get; set; }

        public bool IsActive { get; set; }

        public int UserName { get; set; }

        [Required]
        [StringLength(255)]
        public string UserPassword { get; set; }

        [StringLength(20)]
        public string AccessLevel { get; set; }

        public virtual City City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Master> Masters { get; set; }
    }
}
