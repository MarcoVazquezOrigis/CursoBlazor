using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class InformationArea
{
    public byte AreaId { get; set; }

    public string? AreaName { get; set; }

    public byte? EnterpriseId { get; set; }

    public DateOnly? RecordDate { get; set; }

    public string? RecordSource { get; set; }
}
