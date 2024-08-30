using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuOdit
{
    public long OditId { get; set; }

    public string? Odit { get; set; }

    public string? Area { get; set; }

    public DateTime? FechaInicio { get; set; }

    public string? Iniciador { get; set; }

    public string? Clasificacion { get; set; }

    public string? Programa { get; set; }

    public DateTime? FechaCierre { get; set; }

    public string? Actividad { get; set; }

    public string? Cuenta { get; set; }

    public string? NoDeNodit { get; set; }

    public string? Periodo { get; set; }

    public string? TipoOdit { get; set; }

    public string? Estatus { get; set; }

    public string? Cadena { get; set; }

    public string? Asignacion { get; set; }

    public string? Observaciones { get; set; }

    public string? HorasDedicadas { get; set; }

    public string? TotalDeHoras { get; set; }

    public string? RecordSource { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? ProccesType { get; set; }

    public DateTime? FlokzuTimestamp { get; set; }

    public string? TipoDeRegistro { get; set; }
}
