using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class UserConfiguration
{
    public long RecordId { get; set; }

    public long UserId { get; set; }

    public string UserName { get; set; } = null!;

    public long UserProfileId { get; set; }

    public string UserProfileKeyword { get; set; } = null!;

    public byte IContactPermission { get; set; }

    public byte ICalendarPermission { get; set; }

    public byte UserActive { get; set; }

    public DateTime RecordDate { get; set; }

    public DateTime? RecordLastDate { get; set; }

    public string RecordSourse { get; set; } = null!;

    public DateTime? BirthDate { get; set; }

    public string UserFlokzu { get; set; } = null!;

    public string AreaFlokzu { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public string? FlokzuEmail { get; set; }

    public int? ISettlement { get; set; }

    public int GenderId { get; set; }

    public string? UserAccess { get; set; }

    public string? Horario { get; set; }
}
