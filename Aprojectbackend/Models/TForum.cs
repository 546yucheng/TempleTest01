﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Aprojectbackend.Models;

public partial class TForum
{
    public int ForId { get; set; }

    public string ForTitle { get; set; }

    public string ForDescription { get; set; }

    public DateTime Created { get; set; }

    public string ImageUrl { get; set; }

    public virtual ICollection<TPost> TPosts { get; set; } = new List<TPost>();
}