using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class InformationObjectSource
{
    public int ObjectSourceId { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? ObjectSource { get; set; }

    public int? ObjectSourceTypeId { get; set; }
}
