namespace SunShine_HRMs.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOPDONG")]
    public partial class HOPDONG
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public DateTime? NgayBatDau { get; set; }

        public DateTime? NgayKetThuc { get; set; }

        [StringLength(1000)]
        public string NoiDung { get; set; }

        [StringLength(50)]
        public string ThoiHan { get; set; }

        [StringLength(10)]
        public string IDNV { get; set; }

        public int? IDLoaiHopDong { get; set; }

        public virtual LOAIHD LOAIHD { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
