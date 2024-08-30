using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class InformationObjectType
{
    public int ObjectTypeId { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? ObjectKeyword { get; set; }

    public string? ObjectType { get; set; }
}
