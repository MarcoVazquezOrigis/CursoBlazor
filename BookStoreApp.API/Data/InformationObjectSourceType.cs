using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class InformationObjectSourceType
{
    public int ObjectSourceTypeId { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? ObjectSourceTypeKeyword { get; set; }

    public string? ObjectSourceType { get; set; }
}
