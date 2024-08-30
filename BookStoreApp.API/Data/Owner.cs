using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class Owner
{
    public long OwnerId { get; set; }

    public string OwnerName { get; set; } = null!;

    public long? UserId { get; set; }

    public string? OwnerPrefix { get; set; }

    public DateTime RecordDate { get; set; }

    public DateTime RecordLastDate { get; set; }

    public byte OwnerActive { get; set; }

    public string? RecordSource { get; set; }

    public long? OwnerIdOther { get; set; }

    public string? OwnerFile { get; set; }
}
