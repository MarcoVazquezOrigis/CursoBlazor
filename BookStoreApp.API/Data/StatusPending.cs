using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class StatusPending
{
    public long StatusId { get; set; }

    public string? StatusName { get; set; }

    public string? RecordSource { get; set; }

    public DateTime? RecordDate { get; set; }

    public DateTime? RecordLastDate { get; set; }
}
