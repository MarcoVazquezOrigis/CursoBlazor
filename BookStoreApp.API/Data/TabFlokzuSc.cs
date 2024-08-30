using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class TabFlokzuSc
{
    public long RecordId { get; set; }

    public DateOnly? RecordDate { get; set; }

    public string? RecordSource { get; set; }

    public string? Sc { get; set; }

    public string? Scid { get; set; }

    public string? Estatus { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public DateOnly? FechaEstimada { get; set; }

    public DateOnly? FechaEntrega { get; set; }

    public DateOnly? FechaCierre { get; set; }
}
