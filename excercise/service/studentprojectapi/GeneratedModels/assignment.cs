﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace studentprojectapi.Models;

[Table("assignment")]
public partial class assignment
{
    [Key]
    public Guid assignmentID { get; set; }

    public Guid personID { get; set; }

    public Guid deptID { get; set; }

    [Required]
    [StringLength(25)]
    [Unicode(false)]
    public string createdby { get; set; }

    [Column(TypeName = "date")]
    public DateTime createdate { get; set; }

    [Required]
    [StringLength(25)]
    [Unicode(false)]
    public string modifiedby { get; set; }

    [Column(TypeName = "date")]
    public DateTime modifieddate { get; set; }

    [ForeignKey("deptID")]
    [InverseProperty("assignments")]
    public virtual department dept { get; set; }

    [ForeignKey("personID")]
    [InverseProperty("assignments")]
    public virtual employee person { get; set; }
}