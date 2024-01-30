using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("DonHang")]
public partial class DonHang
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("NGAYXUATDON", TypeName = "date")]
    public DateTime? Ngayxuatdon { get; set; }

    [Column("TINHTRANGDH")]
    [StringLength(50)]
    public string? Tinhtrangdh { get; set; }

    [StringLength(50)]
    public string? TenSanPham { get; set; }

    public int? SoLuongMua { get; set; }

    [StringLength(50)]
    public string? TenNguoiMua { get; set; }

    [Column("GIADH")]
    public int? Giadh { get; set; }

    [Column("GHICHU")]
    [StringLength(50)]
    public string? Ghichu { get; set; }

    [Column("IDDONHANG")]
    public int? Iddonhang { get; set; }

    [ForeignKey("Iddonhang")]
    [InverseProperty("DonHangs")]
    public virtual Admin? IddonhangNavigation { get; set; }
}
