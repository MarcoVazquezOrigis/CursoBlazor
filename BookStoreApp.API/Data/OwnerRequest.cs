using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class OwnerRequest
{
    public long OwnerRequestId { get; set; }

    public string RequestNumber { get; set; } = null!;

    public long RegistrantUserId { get; set; }

    public string Request { get; set; } = null!;

    public long OwnerId { get; set; }

    public long ItemProgramId { get; set; }

    public long PriorityId { get; set; }

    public long StatusId { get; set; }

    public long DepartmentId { get; set; }

    public DateTime RequestDate { get; set; }

    public DateTime? AsignationDate { get; set; }

    public DateTime? EstimationDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public DateTime? ReleasedDate { get; set; }

    public string? LastComment { get; set; }

    public string? WorkHours { get; set; }

    public long? AssignamentUserId { get; set; }

    public DateTime RecordDate { get; set; }

    public DateTime RecordLastDate { get; set; }

    public string? RecordSource { get; set; }

    public byte? OwnerRequestSync { get; set; }
}
