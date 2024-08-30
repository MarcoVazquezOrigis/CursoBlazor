using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class HelpDeskActivity
{
    public long HelpDeskActivitiesId { get; set; }

    public long? ActivityType { get; set; }

    public string ActivityKeyword { get; set; } = null!;

    public string ActivityName { get; set; } = null!;

    public long? AssignamentId { get; set; }

    public DateTime RecordDate { get; set; }

    public DateTime RecordLastDate { get; set; }

    public string? RecordSource { get; set; }

    public byte IActive { get; set; }
}
