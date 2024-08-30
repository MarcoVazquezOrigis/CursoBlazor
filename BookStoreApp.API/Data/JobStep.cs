using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class JobStep
{
    public long JobStepsId { get; set; }

    public string JobKeyword { get; set; } = null!;

    public long JobPosition { get; set; }

    public string JobDescription { get; set; } = null!;

    public long StatusId { get; set; }

    public string StatusLayer { get; set; } = null!;

    public DateTime RecordDate { get; set; }

    public DateTime RecordLastDate { get; set; }

    public string? RecordSource { get; set; }

    public byte IActive { get; set; }
}
