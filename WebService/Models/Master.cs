namespace WebService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Spatial;

    [Table("Master")]
    public partial class Master
    {
        public int MasterID { get; set; }

        public int EmployeeNo { get; set; }

        public int StationNo { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Station Station { get; set; }
    }
}
