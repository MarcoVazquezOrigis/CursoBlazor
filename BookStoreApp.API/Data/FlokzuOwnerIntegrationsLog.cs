using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuOwnerIntegrationsLog
{
    public long FlokzuOwnerIntegrationsLogId { get; set; }

    public long FlokzuOwnerIntegrationsId { get; set; }

    public long ItemOwnerId { get; set; }

    public string ItemOwnerName { get; set; } = null!;

    public long ItemOwnerProgramId { get; set; }

    public string ItemOwnerProgramName { get; set; } = null!;

    public long? ConnectionId { get; set; }

    public string? ConnectionNameReference { get; set; }

    public long IntegrationStatus { get; set; }

    public long HourId { get; set; }

    public string Proceso { get; set; } = null!;

    public string Periodo { get; set; } = null!;

    public string? Comentario { get; set; }

    public long? TipoDeReunionId { get; set; }

    public long RegistrantUserId { get; set; }

    public DateTime? AsignationLastDate { get; set; }

    public DateTime RecordDate { get; set; }

    public DateTime? RecordLastDate { get; set; }

    public string RecordSource { get; set; } = null!;

    public DateTime? FlokzuTimestamp { get; set; }
}
