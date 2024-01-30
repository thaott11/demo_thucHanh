using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("NhanVien")]
public partial class NhanVien
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("ten")]
    [StringLength(50)]
    public string Ten { get; set; } = null!;

    [Column("email")]
    [StringLength(50)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [Column("sdt")]
    public int? Sdt { get; set; }

    [Column("diachi")]
    [StringLength(100)]
    public string? Diachi { get; set; }

    [Column("AdminID")]
    public int? AdminId { get; set; }

    [ForeignKey("AdminId")]
    [InverseProperty("NhanViens")]
    public virtual Admin? Admin { get; set; }
}
