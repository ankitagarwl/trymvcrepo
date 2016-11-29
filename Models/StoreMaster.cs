namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreMaster")]
    public partial class StoreMaster
    {
        public int id { get; set; }

        [StringLength(50)]
        public string storename { get; set; }
    }
}
