using System;
using System.Collections.Generic;

namespace Domain.CSBImportModels;

public partial class XxcsbHealthOrganization
{
    public int Id { get; set; }

    public int? OrganizationId { get; set; }

    public string? EngName { get; set; }

    public string? ArName { get; set; }

    public string? OrganizationParent { get; set; }

    public string? OrganizationChild { get; set; }

    public string? Type { get; set; }

    public DateTime InsertDate { get; set; }
}
