﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Aprojectbackend.Models;

public partial class TActEventReg
{
    public int FRegId { get; set; }

    public int? FActDetailId { get; set; }

    public int? FStatusId { get; set; }

    public int? FUserId { get; set; }

    public decimal? FActPayment { get; set; }

    public string FRegDate { get; set; }

    public string FDispRegNum { get; set; }

    public virtual TStatus FStatus { get; set; }

    public virtual ICollection<TRegDetail> TRegDetails { get; set; } = new List<TRegDetail>();
}