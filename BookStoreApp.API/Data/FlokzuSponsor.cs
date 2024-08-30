using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuSponsor
{
    public long SponsorId { get; set; }

    public DateTime Recordate { get; set; }

    public string? Area { get; set; }

    public string? Sponsor { get; set; }

    public string? Sc { get; set; }

    public DateTime? FechaAsignacion { get; set; }

    public DateTime? FechaAtencion { get; set; }

    public DateTime? FechaCierre { get; set; }

    public int? StatusId { get; set; }

    public string? Comentarios { get; set; }

    public string? RecordSource { get; set; }

    public DateTime? FlokzuTimestamp { get; set; }
}
