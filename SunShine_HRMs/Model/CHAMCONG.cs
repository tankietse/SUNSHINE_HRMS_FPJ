namespace SunShine_HRMs.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHAMCONG")]
    public partial class CHAMCONG
    {
        public int ID { get; set; }

        public int? SoGioLam { get; set; }

        public int? SoNgayNghi { get; set; }

        public int? SoLanTre { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGian { get; set; }

        [StringLength(10)]
        public string IDNV { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
