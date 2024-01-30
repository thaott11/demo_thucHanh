using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("KhachHang")]
public partial class KhachHang
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string TenKhachHang { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? DiaChi { get; set; }

    public int? DienThoai { get; set; }

    [StringLength(50)]
    public string? DanhGia { get; set; }

    [Column("IDAdmin")]
    public int? Idadmin { get; set; }

    [ForeignKey("Idadmin")]
    [InverseProperty("KhachHangs")]
    public virtual Admin? IdadminNavigation { get; set; }
}
