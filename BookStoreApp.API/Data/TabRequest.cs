using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class TabRequest
{
    public long OwnerRequestId { get; set; }

    public string OwnerName { get; set; } = null!;

    public string? DepartmentName { get; set; }

    public string? StatusName { get; set; }

    public string UserName { get; set; } = null!;

    public int? WorkHours { get; set; }

    public string Priority { get; set; } = null!;

    public string? RequestDate { get; set; }

    public string? AsignationDate { get; set; }

    public string? EstimationDate { get; set; }

    public string? DeliveryDate { get; set; }

    public string? ReleasedDate { get; set; }
}
