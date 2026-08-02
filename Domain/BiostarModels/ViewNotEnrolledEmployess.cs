using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class ViewNotEnrolledEmployess
{
    public string SUserName { get; set; } = null!;

    public string SUserId { get; set; } = null!;

    public string SDepartment { get; set; } = null!;

    public byte[]? BTemplate { get; set; }

    public string? Position { get; set; }
}
