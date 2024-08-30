using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuActivity
{
    public long ActivityId { get; set; }

    public string? Proceso { get; set; }

    public DateTime? Recordate { get; set; }

    public string? Usuario { get; set; }

    public decimal? Horas { get; set; }

    public string? Actividad { get; set; }

    public string? Fecha { get; set; }

    public string? Interpretacion { get; set; }

    public string? Cuenta { get; set; }

    public string? Programa { get; set; }

    public string? Clasificacion { get; set; }

    public string? Area { get; set; }

    public string? ProccesType { get; set; }

    public string? RecordSource { get; set; }

    public string Sc { get; set; } = null!;

    public string Odt { get; set; } = null!;

    public string Hdt { get; set; } = null!;

    public string? Rt { get; set; }

    public string? Bug { get; set; }

    public string Er { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string Tarea { get; set; } = null!;

    public DateTime? FechaActividad { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? AreaEjecucion { get; set; }

    public string? Tpe { get; set; }

    public string Odit { get; set; } = null!;

    public string? Imt { get; set; }

    public string Con { get; set; } = null!;

    public string Scfa { get; set; } = null!;

    public DateTime? FlokzuTimestamp { get; set; }

    public string Rpa { get; set; } = null!;

    public string Qat { get; set; } = null!;

    public string? Mes { get; set; }
}
