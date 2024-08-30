using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class InformationEnterprise
{
    public byte EnterpriseId { get; set; }

    public string? EnterpriseName { get; set; }

    public DateOnly? RecordDate { get; set; }

    public string? RecordSource { get; set; }
}
