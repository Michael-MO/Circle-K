using WebService.Model;

namespace WebService.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Station")]
    public partial class Station
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Station()
        {
            Masters = new HashSet<Master>();
        }

        [Key]
        public int StationNo { get; set; }

        [StringLength(15)]
        public string PhoneNo { get; set; }

        [StringLength(70)]
        public string Address { get; set; }

        public int PostalCode { get; set; }

        public virtual City City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Master> Masters { get; set; }
    }
}
