﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Aprojectbackend.Models;

public partial class TActInformation
{
    public int FActId { get; set; }

    public int? FCompanyId { get; set; }

    public int? FActCategoryId { get; set; }

    public string FActName { get; set; }

    public string FActDisplayId { get; set; }

    public string FActLocation { get; set; }

    public string FActDescription { get; set; }

    public decimal? FRegFee { get; set; }

    public int? FMaxNumber { get; set; }

    public string FActUpdateDate { get; set; }

    public virtual TActCategory FActCategory { get; set; }

    public virtual ICollection<TActDetail> TActDetails { get; set; } = new List<TActDetail>();

    public virtual ICollection<TActImgDatum> TActImgData { get; set; } = new List<TActImgDatum>();
}