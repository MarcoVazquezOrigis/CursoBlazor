using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuComparacion
{
    public long ActivityId { get; set; }

    public string? Proceso { get; set; }

    public string? Usuario { get; set; }

    public decimal? Horas { get; set; }

    public DateTime? FechaActividad { get; set; }

    public string? Clasificacion { get; set; }

    public string? Area { get; set; }

    public string? Actividad { get; set; }

    public string? ProccesType { get; set; }
}
