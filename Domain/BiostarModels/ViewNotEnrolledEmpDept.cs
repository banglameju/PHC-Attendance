using System;
using System.Collections.Generic;

namespace Domain.BiostarModels;

public partial class ViewNotEnrolledEmpDept
{
    public int NDepartmentIdn { get; set; }

    public string SDepartment { get; set; } = null!;

    public int? CountEmps { get; set; }
}
