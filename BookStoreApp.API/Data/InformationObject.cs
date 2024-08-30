using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class InformationObject
{
    public int ObjectId { get; set; }

    public DateTime? RecordDate { get; set; }

    public int? ObjectSourceId { get; set; }

    public string? Object { get; set; }

    public int? ObjectTypeId { get; set; }
}
