using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class DeleteInformationDeliverable
{
    public int RecordId { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? RecordSource { get; set; }

    public int? OwnerId { get; set; }

    public int? ProgramId { get; set; }

    public string? Deliverable { get; set; }

    public int? RegistrantUserId { get; set; }

    public int? AssignedUserId { get; set; }

    public string? Periodicity { get; set; }

    public byte? ScheduledDay { get; set; }

    public int? Active { get; set; }

    public string? Period { get; set; }

    public int? DeliverableStatusId { get; set; }

    public string? Priority { get; set; }

    public DateTime? DeliverDate { get; set; }

    public string? RecordKey { get; set; }
}
