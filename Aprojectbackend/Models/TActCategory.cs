﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Aprojectbackend.Models;

public partial class TActCategory
{
    public int FActCategoryId { get; set; }

    public string FActCategory { get; set; }

    public virtual ICollection<TActInformation> TActInformations { get; set; } = new List<TActInformation>();
}