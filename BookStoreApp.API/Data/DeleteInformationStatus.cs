using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class DeleteInformationStatus
{
    public int StatusId { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? RecordSource { get; set; }

    public string? StatusKey { get; set; }

    public string? Status { get; set; }

    public int? Active { get; set; }

    public string? Description { get; set; }

    public int? StatusValuePercent { get; set; }
}
