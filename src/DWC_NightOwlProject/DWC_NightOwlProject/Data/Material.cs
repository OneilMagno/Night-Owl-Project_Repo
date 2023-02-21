﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DWC_NightOwlProject.Data;

[Table("Material")]
public partial class Material
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(40)]
    public string Type { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime CreationDate { get; set; }

    [Column("WorldID")]
    public int WorldId { get; set; }

    [StringLength(1000)]
    public string Prompt { get; set; } = null!;

    [StringLength(1000)]
    public string Completion { get; set; } = null!;

    [Column("TemplateID")]
    public int TemplateId { get; set; }

    [ForeignKey("TemplateId")]
    [InverseProperty("Materials")]
    public virtual Template Template { get; set; } = null!;

    [ForeignKey("WorldId")]
    [InverseProperty("Materials")]
    public virtual World World { get; set; } = null!;
}