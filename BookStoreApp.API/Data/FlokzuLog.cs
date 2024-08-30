using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuLog
{
    public long LogsId { get; set; }

    public string? Payload { get; set; }

    public DateTime? FlokzuTimestamp { get; set; }
}
