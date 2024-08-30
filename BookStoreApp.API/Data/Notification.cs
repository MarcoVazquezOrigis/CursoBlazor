using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class Notification
{
    public long NotificationsId { get; set; }

    public string Notification1 { get; set; } = null!;

    public long RegistrantUserId { get; set; }

    public long OwnerRequestId { get; set; }

    public long? AssignamentUserId { get; set; }

    public byte NotificationActive { get; set; }

    public DateTime RecordDate { get; set; }

    public DateTime RecordLastDate { get; set; }

    public string? RecordSource { get; set; }
}
