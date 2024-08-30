using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class OwnerIntegration
{
    public int OwnerIntegrationsId { get; set; }

    public long OwnerId { get; set; }

    public string ItemOwnerProgram { get; set; } = null!;

    public long ConnectionId { get; set; }

    public string ConnectionName { get; set; } = null!;

    public DateTime IntegrationDate { get; set; }

    public long HourId { get; set; }

    public string? LastComment { get; set; }

    public string MailSubject { get; set; } = null!;

    public long? RegistrantUserId { get; set; }

    public string? RecordFile { get; set; }

    public DateTime? RecordDate { get; set; }

    public DateTime? RecordLastDate { get; set; }

    public string? RecordSource { get; set; }

    public long IntegrationStatus { get; set; }

    public int CheckReference01 { get; set; }

    public string? OwnerName { get; set; }

    public string? Mes { get; set; }
}
