using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class ConectionsCheck
{
    public long IdConectionsChecks { get; set; }

    public long? ConnectionId { get; set; }

    public long? ConnectionStoreId { get; set; }

    public long? ConectionCheck { get; set; }

    public long? RegistrantUserId { get; set; }

    public string? RecordSource { get; set; }

    public DateTime? RecordDate { get; set; }
}
