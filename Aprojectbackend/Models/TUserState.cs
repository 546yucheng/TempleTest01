﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Aprojectbackend.Models;

public partial class TUserState
{
    public int FUserStateId { get; set; }

    public string FUserState { get; set; }

    public virtual ICollection<TUser> TUsers { get; set; } = new List<TUser>();
}