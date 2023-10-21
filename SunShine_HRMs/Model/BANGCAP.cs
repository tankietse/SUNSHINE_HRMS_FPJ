namespace SunShine_HRMs.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANGCAP")]
    public partial class BANGCAP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PK { get; set; }

        public int? ID { get; set; }

        [StringLength(50)]
        public string TenBang { get; set; }

        [StringLength(300)]
        public string NoiCap { get; set; }

        [StringLength(50)]
        public string ChuyenNganh { get; set; }

        public DateTime? Ngay { get; set; }

        [StringLength(10)]
        public string IDNV { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
